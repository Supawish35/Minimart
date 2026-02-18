using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Minimart;

public partial class FrmEditProduct : Form {
    public FrmEditProduct() {
        InitializeComponent();
        ProductId = "";
        CategoryId = 0;
        UnitPrice = 0.0;
        UnitsInStock = 0;
        CategoryId = 0;
        Discontinued = 0;
    }

    [DefaultValue("")]
    public string ProductId { get; set; }
    
    [DefaultValue("")]
    public string CatProductName { get; set; }
    
    [DefaultValue(0.0)]
    public double UnitPrice { get; set; }
    
    [DefaultValue(0)]
    public int UnitsInStock { get; set; }
    
    [DefaultValue(0)]
    public int CategoryId { get; set; }
    
    [DefaultValue("")]
    public string CategoryName { get; set; }
    
    [DefaultValue(0)]
    public int Discontinued { get; set; }
    [DefaultValue("")]

    public string Status { get; set; } //  insert, update

    SqlConnection? _conn; //ประกาศตัวแปรเชื่อมต่อ

    private void frmEditProducts_Load(object sender, EventArgs e) {
        //เชื่อมต่อฐานข้อมูล
        _conn = Minimart.Connect();
        SetCbo();
        //นำข้อมูลที่ถูกส่งมาไปแสดงผลในฟอร์ม
        txtProductID.Text = ProductId;
        txtProductName.Text = CatProductName;
        txtUnitPrice.Text = UnitPrice.ToString();
        txtUnitsInStock.Text = UnitsInStock.ToString();
        cboCategory.SelectedValue = CategoryId; //กำหนดให้ ComboBox แสดงผล
        if (Discontinued == 1) {
            radDiscontinued.Checked = true;
        } else {
            radContinued.Checked = true;
        }
    }

    private void SetCbo() {
        string sql = "Select CategoryID,CategoryName from Categories";
        SqlDataAdapter da = new SqlDataAdapter(sql, _conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        cboCategory.DataSource = ds.Tables[0];
        cboCategory.ValueMember = "CategoryID"; //กำหนดคอลัมน์ที่เป็นค่ารหัส
        cboCategory.DisplayMember = "CategoryName"; //กำหนดข้อมูลที่แสดงผล
    }

    private void btnSave_Click(object sender, EventArgs e) {
        if (Status == "insert") {
            InsertData();
        } else if (Status == "update") {
            UpdateData();
        }

        this.Close(); //เมื่อเพิ่มหรือแก้ไขแล้วควรปิดหน้าต่างฟอร์มออกไป
    }

    private void UpdateData() {
        if (!CheckInputData()) {
            return; //หมายความว่า ถ้า checkInputData() มีค่าเป็น False จะจบโค้ดตรงนี้
        }

        string sql = "update products set productName = @productName, UnitPrice= @unitPrice,"
                     + " UnitsInStock =@UnitsInStock,CategoryID=@CategoryID,Discontinued =@Discontinued"
                     + " where productID = @productID";
        SqlCommand comm = new SqlCommand(sql, _conn);
        comm.Parameters.AddWithValue("@productID", txtProductID.Text.Trim());
        comm.Parameters.AddWithValue("@productName", txtProductName.Text.Trim());
        comm.Parameters.AddWithValue("@unitPrice", txtUnitPrice.Text);
        comm.Parameters.AddWithValue("@UnitsInStock", txtUnitsInStock.Text);

        comm.Parameters.AddWithValue("@CategoryID", cboCategory.SelectedValue); //เอาค่ารหัสที่ได้จากการเลือกใน comboBox
        if (radContinued.Checked) {
            comm.Parameters.AddWithValue("@Discontinued", 0);
        } else if (radDiscontinued.Checked) {
            comm.Parameters.AddWithValue("@Discontinued", 1);
        }

        if (_conn.State != ConnectionState.Open) {
            _conn.Open();
        }

        try {
            comm.ExecuteNonQuery();
        }
        catch (Exception ex) {
            string msg = ex.Message;
            MessageBox.Show(msg, "เกิดข้อผิดพลาด");
        }

        _conn.Close();
    }

    private bool CheckInputData() {
        //ตรวจสอบรหัสสินค้าไม่ให้เป็นที่ว่าง
        if (txtProductID.Text.Trim() == "") {
            MessageBox.Show("รหัสสินค้าต้องไม่เป็นที่ว่าง", "เกิดข้อผิดพลาด");
            return false;
        }

        //ตรวจสอบชื่อสินค้า
        if (txtProductName.Text.Trim() == "") {
            MessageBox.Show("ชื่อสินค้าต้องไม่เป็นที่ว่าง", "เกิดข้อผิดพลาด");
            return false;
        }

        //ตรวจสอบราคากรอกเป็นตัวเลขหรือไม่
        double x = 0.00;
        if (!double.TryParse(txtUnitPrice.Text, out x)) {
            MessageBox.Show("ราคาสินค้าเกิดข้อผิดพลาด", "เกิดข้อผิดพลาด");
            return false;
        }

        //ตรวจสอบจำนวนว่าเป็นจำนวนเต็มหรือไม่
        int y = 0;
        if (!int.TryParse(txtUnitsInStock.Text, out y)) {
            MessageBox.Show("จำนวนสินค้าผิดพลาด", "เกิดข้อผิดพลาด");
            return false;
        }

        return true;
    }


    private void InsertData() {
        if (!CheckInputData()) {
            return; //หมายความว่า ถ ้า checkInputData() มีค่าเป็น False จะจบโค้ดตรงนี้
        }

        string sql = "insert into Products "
                     + "values(@productID, @productName, @unitPrice, @UnitsInStock, @CategoryID, @Discontinued)";
        SqlCommand comm = new SqlCommand(sql, _conn);
        comm.Parameters.AddWithValue("@productID", txtProductID.Text.Trim());
        comm.Parameters.AddWithValue("@productName", txtProductName.Text.Trim());
        comm.Parameters.AddWithValue("@unitPrice", txtUnitPrice.Text);
        comm.Parameters.AddWithValue("@UnitsInStock", txtUnitsInStock.Text);
        comm.Parameters.AddWithValue("@CategoryID", cboCategory.SelectedValue); //เอาค่ารหัสที่ได้จากการเลือกใน comboBox
        if (radContinued.Checked) {
            comm.Parameters.AddWithValue("@Discontinued", 0);
        } else if (radDiscontinued.Checked) {
            comm.Parameters.AddWithValue("@Discontinued", 1);
        }

        if (_conn.State != ConnectionState.Open) {
            _conn.Open();
        }

        try {
            comm.ExecuteNonQuery();
        }
        catch (Exception ex) {
            string msg = ex.Message;
            MessageBox.Show(msg, "เกิดข้อผิดพลาด");
        }

        _conn.Close();
    }
}