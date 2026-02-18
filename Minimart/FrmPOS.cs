using System.ComponentModel;
using System.ComponentModel.Design;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Minimart;

public partial class FrmPos : Form {
    public FrmPos() {
        InitializeComponent();
        EmpId = 0;
        EmpName = "";
        Position = "";
        UserName = "";
    } //ประกาศ Property ส าหรับเก็บขอ้ มลู ถา้หากมกี าร Login ผ่าน

    [DefaultValue(0)] public int EmpId { get; set; }
    [DefaultValue("")] public string EmpName { get; set; }
    [DefaultValue("")] public string Position { get; set; }
    [DefaultValue("")] public string UserName { get; set; }

//ประกาศตัวแปรเชอื่ มต่อ
    SqlConnection _conn;
    SqlTransaction _tr;

    private void frmReceipt_Details_Load(object sender, EventArgs e) {
        _conn = Minimart.Connect(); //เปลี่ยนตามของตัวเอง
        ListViewFormat();
        ClearProductData();
        txtEmployeeID.Text = this.EmpId.ToString();
        txtEmployeeName.Text = this.EmpName;
        if (EmpId > 0) {
            txtProductID.Focus();
            txtProductID.SelectAll();
        } else {
            txtEmployeeID.Focus();
            txtEmployeeID.SelectAll();
        }
    }

    private void ClearProductData() //เคลียร์ข ้อมูลใน Textbox รายการสนิ คา้
    {
        txtProductID.Text = "";
        txtProductName.Text = "";
        txtUnitPrice.Text = "0";
        txtQuantity.Text = "1";
        txtTotal.Text = "0";
    }

    private void ListViewFormat() //ส าหรับจัดรูปแบบ ListView
    {
        lsvProducts.Columns.Add("รหัสสินค้า", 120, HorizontalAlignment.Left);
        lsvProducts.Columns.Add("สินค้า", 170, HorizontalAlignment.Left);
        lsvProducts.Columns.Add("ราคา", 120, HorizontalAlignment.Right);
        lsvProducts.Columns.Add("จำนวน", 75, HorizontalAlignment.Right);
        lsvProducts.Columns.Add("รวมเป็นเงิน", 100, HorizontalAlignment.Right);
        lsvProducts.View = View.Details;
        lsvProducts.GridLines = true;
        lsvProducts.FullRowSelect = true;
    }

    private void ClearEmployeeData() //เคลยี รช์ อื่ และรหัสพนักงาน
    {
        txtEmployeeID.Text = "";
        txtEmployeeName.Text = "";
    }

    private void CalculateTotal() //เอาไว้ค านวณราคารวมของแต่ละรายการ
    {
        double total = Convert.ToDouble(txtUnitPrice.Text) * Convert.ToDouble(txtQuantity.Text);
        txtTotal.Text = total.ToString("#,##0.00");
        txtProductID.Focus();
        txtProductID.SelectAll();
    }

    private void CalculateNetPrice() //เอาไว้ค านวณราคารวมทั้งหมด
    {
        double tmpNetPrice = 0.0;
        for (int i = 0; i <= lsvProducts.Items.Count - 1; i++) {
            tmpNetPrice += Convert.ToDouble(lsvProducts.Items[i].SubItems[4].Text);
        }

        lblNetPrice.Text = tmpNetPrice.ToString("#,##0.00");
    }

    private void txtEmployeeID_KeyDown(object sender, KeyEventArgs e) {
        if (e.KeyCode == Keys.Enter) {
            string sql = "Select EmployeeID, Title+FirstName+space(2)+LastName EmpName, Position"
                         + " from Employees"
                         + " Where EmployeeID = @EmployeeID";
            SqlCommand comm = new SqlCommand(sql, _conn);
            comm.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text);
            
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows) {
                DataTable dt = new DataTable();
                dt.Load(dr);
                txtEmployeeID.Text = dt.Rows[0][0].ToString();
                txtEmployeeName.Text = dt.Rows[0][1].ToString();
                txtProductID.Focus();
            } else {
                ClearEmployeeData();
                txtEmployeeID.Focus();
            }

            dr.Close();
            _conn.Close();
        }
    }

    private void txtProductID_KeyDown(object sender, KeyEventArgs e) {
        if (e.KeyCode == Keys.Enter) {
            e.SuppressKeyPress = true;
            LookupProductById(txtProductID.Text);
        }
    }

    private void LookupProductById(string rawProductId) {
        string productId = rawProductId.Trim();
        txtProductID.Text = productId;
        if (productId == "") {
            ClearProductData();
            txtProductID.Focus();
            txtProductID.SelectAll();
            return;
        }

        string sql = "Select ProductID, ProductName,UnitPrice,UnitsInStock"
                     + " from Products where productID = @ProductID";
        SqlCommand comm = new SqlCommand(sql, _conn);
        comm.Parameters.AddWithValue("@ProductID", productId);
        _conn.Open();

        SqlDataReader dr = comm.ExecuteReader();

        if (dr.HasRows) {
            DataTable dt = new DataTable();
            dt.Load(dr);
            txtProductID.Text = dt.Rows[0][0].ToString();
            txtProductName.Text = dt.Rows[0][1].ToString();
            txtUnitPrice.Text = dt.Rows[0][2].ToString();
            CalculateTotal();
            txtQuantity.Focus();
            txtQuantity.SelectAll();
            
            add_product();
        } else {
            MessageBox.Show("ไม่พบรหัสสินค้านี้", "ผิดพลาด");
            ClearProductData();
            txtProductID.Focus();
            txtProductID.SelectAll();
        }

        dr.Close();
        _conn.Close();
    }

    private void txtQuantity_TextChanged(object sender, EventArgs e) {
        if (txtQuantity.Text.Trim() == "") txtQuantity.Text = "1";
        if (Convert.ToInt16(txtQuantity.Text) == 0) txtQuantity.Text = "1";
        CalculateTotal();
    }

    private void btnAdd_Click(object sender, EventArgs e) {
        add_product();
    }

    private void btnClear_Click(object sender, EventArgs e) {
        ClearProductData();
    }

    private void lsvProducts_DoubleClick(object sender, EventArgs e) {
        //เมื่อ Double click บนขอ้มลู สนิ คา้จะลบสนิ คา้ออกจากรายการ
        for (int i = 0; i <= lsvProducts.SelectedItems.Count - 1; i++) {
            ListViewItem lvi = lsvProducts.SelectedItems[i];
            lsvProducts.Items.Remove(lvi);
        }

        CalculateNetPrice();
        txtProductID.Focus();
        txtProductID.SelectAll();
    }

    private void btnCancel_Click(object sender, EventArgs e) {
        lsvProducts.Clear();
        ClearProductData();
        ListViewFormat();
        lblNetPrice.Text = "0.00";
        txtProductID.Focus();
        txtProductID.SelectAll();
    }

    private void btnSave_Click(object sender, EventArgs e) {
        if (MessageBox.Show("ต้องการบันทึกสินค้านี้หรือไม่", "โปรดยืนยัน", MessageBoxButtons.YesNo) ==
            DialogResult.No) {
            return;
        }

        int lastOrderId = 0; //เอาไว้เก็บรหัสที่เพิ่มล่าสุด
        if (lsvProducts.Items.Count > 0) {
//ประกาศเริ่ม Transaction
            _conn.Open();
            _tr = _conn.BeginTransaction();
//เพิ่มข ้อมูล Receipt
            SqlCommand comm = new SqlCommand("InsertReceipts", _conn, _tr);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@ReceiptDate", DateTime.Today);
            comm.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text);
            comm.Parameters.AddWithValue("@TotalCash", lblNetPrice.Text);
            comm.ExecuteNonQuery();
//อ่านข ้อมูล รหัสของ Receipt รายการล่าสุดไว้ในตัวแปร LastOrderID
            string sql = "Select top 1 ReceiptID from Receipts Order by ReceiptID desc";

            SqlCommand comm1 = new SqlCommand(sql, _conn, _tr);
            SqlDataReader dr = comm1.ExecuteReader();
            if (dr.HasRows) {
                dr.Read();
                lastOrderId = dr.GetInt32(dr.GetOrdinal("ReceiptID"));
            }

            dr.Close();
//เพมิ่ รายการสนิ คา้ใน Details โดยใชร้หัส LastOrderID
            string ls = "";
            for (int i = 0; i <= lsvProducts.Items.Count - 1; i++) {
                SqlCommand comm3 = new SqlCommand("InsertDetails", _conn, _tr);
                comm3.CommandType = CommandType.StoredProcedure;
                comm3.Parameters.AddWithValue("@ReceiptID", lastOrderId);
                comm3.Parameters.AddWithValue("@productID", lsvProducts.Items[i].SubItems[0].Text);
                comm3.Parameters.AddWithValue("@UnitPrice", lsvProducts.Items[i].SubItems[2].Text);
                comm3.Parameters.AddWithValue("@Quantity", lsvProducts.Items[i].SubItems[3].Text);
                comm3.ExecuteNonQuery();
                ls += lsvProducts.Items[i].SubItems[0].Text + "--";
                ls += lsvProducts.Items[i].SubItems[1].Text + "--";
                ls += lsvProducts.Items[i].SubItems[2].Text + "--";
                ls += lsvProducts.Items[i].SubItems[3].Text + "--";
                ls += lsvProducts.Items[i].SubItems[4].Text + Environment.NewLine;
            }

            _tr.Commit();
            _conn.Close();
            string msg = "รหัสการขาย" + lastOrderId.ToString() + Environment.NewLine
                         + ls
                         + "ยอดรวม " + lblNetPrice.Text;
            MessageBox.Show("บันทึกรายการสินค้านี้เรียบร้อย" + msg, "ผลการทำงาน");
        }

        btnCancel.PerformClick(); //ค าสงั่ นี้สงั่ ใหร้ะบบคลกิป่มุ btnCancel เพื่อเริ่มรายการใหม่
    }

    private void txtQuantity_KeyDown(object sender, KeyEventArgs e) {
        if (e.KeyCode == Keys.Enter) {
            btnAdd.PerformClick(); //สงั่ กดป่มุ เพมิ่ ทันที
        }
    }

    private void add_product() {
        if (txtProductID.Text.Trim() == "" || txtProductName.Text.Trim() == "") {
            txtProductID.Focus();
            txtProductID.SelectAll();
            return;
        }

        if (Convert.ToInt16(txtQuantity.Text) == 0) {
            txtProductID.Focus();
            txtProductID.SelectAll();
            return;
        }

        ListViewItem lvi;

        string tmpProductId = "";

        for (int i = 0; i <= lsvProducts.Items.Count - 1; i++) {
            tmpProductId = lsvProducts.Items[i].SubItems[0].Text;
            if (txtProductID.Text == tmpProductId) {
                int qty = Convert.ToInt16(lsvProducts.Items[i].SubItems[3].Text)
                          + Convert.ToInt16(txtQuantity.Text);
                double newTotal = Convert.ToDouble(lsvProducts.Items[i].SubItems[4].Text)
                                  + Convert.ToDouble(txtTotal.Text);
                lsvProducts.Items[i].SubItems[3].Text = qty.ToString();
                lsvProducts.Items[i].SubItems[4].Text = newTotal.ToString("#,##0.00");
                ClearProductData();
                CalculateTotal();
                CalculateNetPrice();
                return;
            }
        }

        string[] anyData;
        anyData = new string[] {
            txtProductID.Text, txtProductName.Text, txtUnitPrice.Text,
            txtQuantity.Text, txtTotal.Text
        };
        lvi = new ListViewItem(anyData);
        lsvProducts.Items.Add(lvi);

        CalculateNetPrice();
        ClearProductData();
        btnSave.Enabled = true;
        txtProductID.Focus();
        txtProductID.SelectAll();
    }
}