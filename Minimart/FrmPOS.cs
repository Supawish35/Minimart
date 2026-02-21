using System.ComponentModel;
using System.ComponentModel.Design;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Minimart;

public partial class FrmPos : Form {
    
    [DefaultValue(0)] public int EmpId { get; set; }
    [DefaultValue("")] public string EmpName { get; set; }
    [DefaultValue("")] public string Position { get; set; }
    [DefaultValue("")] public string UserName { get; set; }
    
    SqlConnection _conn;
    SqlTransaction _tr;
    
    public FrmPos() {
        InitializeComponent();
        EmpId = 0;
        EmpName = "";
        Position = "";
        UserName = "";
    } 
    
    private void frmReceipt_Details_Load(object sender, EventArgs e) {
        _conn = Minimart.Connect(); 
        ListViewFormat();
        ClearProductData();
        txtEmployeeID.Text = this.EmpId > 0 ? this.EmpId.ToString() : "";
        txtEmployeeName.Text = this.EmpName;
        if (EmpId > 0) {
            LoadEmployeeById(EmpId);
        }
        if (EmpId > 0) {
            txtProductID.Focus();
            txtProductID.SelectAll();
        } else {
            txtEmployeeID.Focus();
            txtEmployeeID.SelectAll();
        }
    }
    private void LoadEmployeeById(int employeeId) {
        if (employeeId <= 0) {
            return;
        }

        string sql = "Select EmployeeID, Title+FirstName+space(2)+LastName EmpName, Position"
                     + " from Employees"
                     + " Where EmployeeID = @EmployeeID";
        SqlCommand comm = new SqlCommand(sql, _conn);
        comm.Parameters.AddWithValue("@EmployeeID", employeeId);

        if (_conn.State != ConnectionState.Open) {
            _conn.Open();
        }

        SqlDataReader dr = comm.ExecuteReader();
        if (dr.HasRows) {
            DataTable dt = new DataTable();
            dt.Load(dr);
            txtEmployeeID.Text = dt.Rows[0][0].ToString();
            txtEmployeeName.Text = dt.Rows[0][1].ToString();
        } else {
            ClearEmployeeData();
        }

        dr.Close();
        _conn.Close();
    }
    private void ClearProductData() 
    {
        txtProductID.Text = "";
        txtProductName.Text = "";
        txtUnitPrice.Text = "0";
        txtQuantity.Text = "1";
        txtTotal.Text = "0";
    }

    private void ListViewFormat() 
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

    private void ClearEmployeeData() //à¹€à¸„à¸¥à¸¢à¸µ à¸£à¸Šà¹Œ à¸­à¸·à¹ˆ à¹à¸¥à¸°à¸£à¸«à¸±à¸ªà¸žà¸™à¸±à¸à¸‡à¸²à¸™
    {
        txtEmployeeID.Text = "";
        txtEmployeeName.Text = "";
    }

    private void CalculateTotal() //à¹€à¸­à¸²à¹„à¸§à¹‰à¸„ à¸²à¸™à¸§à¸“à¸£à¸²à¸„à¸²à¸£à¸§à¸¡à¸‚à¸­à¸‡à¹à¸•à¹ˆà¸¥à¸°à¸£à¸²à¸¢à¸à¸²à¸£
    {
        double total = Convert.ToDouble(txtUnitPrice.Text) * Convert.ToDouble(txtQuantity.Text);
        txtTotal.Text = total.ToString("#,##0.00");
        txtProductID.Focus();
        txtProductID.SelectAll();
    }

    private void CalculateNetPrice() //à¹€à¸­à¸²à¹„à¸§à¹‰à¸„ à¸²à¸™à¸§à¸“à¸£à¸²à¸„à¸²à¸£à¸§à¸¡à¸—à¸±à¹‰à¸‡à¸«à¸¡à¸”
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
            MessageBox.Show("à¹„à¸¡à¹ˆà¸žà¸šà¸£à¸«à¸±à¸ªà¸ªà¸´à¸™à¸„à¹‰à¸²à¸™à¸µà¹‰", "à¸œà¸´à¸”à¸žà¸¥à¸²à¸”");
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
        //à¹€à¸¡à¸·à¹ˆà¸­ Double click à¸šà¸™à¸‚à¸­à¹‰à¸¡à¸¥à¸¹ à¸ªà¸™à¸´ à¸„à¸²à¹‰à¸ˆà¸°à¸¥à¸šà¸ªà¸™à¸´ à¸„à¸²à¹‰à¸­à¸­à¸à¸ˆà¸²à¸à¸£à¸²à¸¢à¸à¸²à¸£
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
        if (MessageBox.Show("à¸•à¹‰à¸­à¸‡à¸à¸²à¸£à¸šà¸±à¸™à¸—à¸¶à¸à¸ªà¸´à¸™à¸„à¹‰à¸²à¸™à¸µà¹‰à¸«à¸£à¸·à¸­à¹„à¸¡à¹ˆ", "à¹‚à¸›à¸£à¸”à¸¢à¸·à¸™à¸¢à¸±à¸™", MessageBoxButtons.YesNo) ==
            DialogResult.No) {
            return;
        }

        int lastOrderId = 0; //à¹€à¸­à¸²à¹„à¸§à¹‰à¹€à¸à¹‡à¸šà¸£à¸«à¸±à¸ªà¸—à¸µà¹ˆà¹€à¸žà¸´à¹ˆà¸¡à¸¥à¹ˆà¸²à¸ªà¸¸à¸”
        if (lsvProducts.Items.Count > 0) {
//à¸›à¸£à¸°à¸à¸²à¸¨à¹€à¸£à¸´à¹ˆà¸¡ Transaction
            _conn.Open();
            _tr = _conn.BeginTransaction();
//à¹€à¸žà¸´à¹ˆà¸¡à¸‚ à¹‰à¸­à¸¡à¸¹à¸¥ Receipt
            SqlCommand comm = new SqlCommand("InsertReceipts", _conn, _tr);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@ReceiptDate", DateTime.Today);
            comm.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text);
            comm.Parameters.AddWithValue("@TotalCash", lblNetPrice.Text);
            comm.ExecuteNonQuery();
//à¸­à¹ˆà¸²à¸™à¸‚ à¹‰à¸­à¸¡à¸¹à¸¥ à¸£à¸«à¸±à¸ªà¸‚à¸­à¸‡ Receipt à¸£à¸²à¸¢à¸à¸²à¸£à¸¥à¹ˆà¸²à¸ªà¸¸à¸”à¹„à¸§à¹‰à¹ƒà¸™à¸•à¸±à¸§à¹à¸›à¸£ LastOrderID
            string sql = "Select top 1 ReceiptID from Receipts Order by ReceiptID desc";

            SqlCommand comm1 = new SqlCommand(sql, _conn, _tr);
            SqlDataReader dr = comm1.ExecuteReader();
            if (dr.HasRows) {
                dr.Read();
                lastOrderId = dr.GetInt32(dr.GetOrdinal("ReceiptID"));
            }

            dr.Close();
//à¹€à¸žà¸¡à¸´à¹ˆ à¸£à¸²à¸¢à¸à¸²à¸£à¸ªà¸™à¸´ à¸„à¸²à¹‰à¹ƒà¸™ Details à¹‚à¸”à¸¢à¹ƒà¸Šà¸£à¹‰à¸«à¸±à¸ª LastOrderID
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
            string msg = "à¸£à¸«à¸±à¸ªà¸à¸²à¸£à¸‚à¸²à¸¢" + lastOrderId.ToString() + Environment.NewLine
                         + ls
                         + "à¸¢à¸­à¸”à¸£à¸§à¸¡ " + lblNetPrice.Text;
            MessageBox.Show("à¸šà¸±à¸™à¸—à¸¶à¸à¸£à¸²à¸¢à¸à¸²à¸£à¸ªà¸´à¸™à¸„à¹‰à¸²à¸™à¸µà¹‰à¹€à¸£à¸µà¸¢à¸šà¸£à¹‰à¸­à¸¢" + msg, "à¸œà¸¥à¸à¸²à¸£à¸—à¸³à¸‡à¸²à¸™");
        }

        btnCancel.PerformClick(); //à¸„ à¸²à¸ªà¸‡à¸±à¹ˆ à¸™à¸µà¹‰à¸ªà¸‡à¸±à¹ˆ à¹ƒà¸«à¸£à¹‰à¸°à¸šà¸šà¸„à¸¥à¸à¸´à¸›à¹ˆà¸¡à¸¸ btnCancel à¹€à¸žà¸·à¹ˆà¸­à¹€à¸£à¸´à¹ˆà¸¡à¸£à¸²à¸¢à¸à¸²à¸£à¹ƒà¸«à¸¡à¹ˆ
    }

    private void txtQuantity_KeyDown(object sender, KeyEventArgs e) {
        if (e.KeyCode == Keys.Enter) {
            btnAdd.PerformClick(); //à¸ªà¸‡à¸±à¹ˆ à¸à¸”à¸›à¹ˆà¸¡à¸¸ à¹€à¸žà¸¡à¸´à¹ˆ à¸—à¸±à¸™à¸—à¸µ
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

