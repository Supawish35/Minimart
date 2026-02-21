using System.Data;
using Microsoft.Data.SqlClient;

namespace Minimart;

public partial class Products : Form {
    public Products() {
        InitializeComponent();
    }
    private SqlConnection? _conn;

    //ประกาศตัวแปรเพื่อเก็บข้อมูลสินค้าที่เลือกทำงาน
    string _productId = string.Empty;
    string _productName = string.Empty;
    double _unitPrice = 0;
    int _unitsInStock = 0;
    int _categoryId = 0;
    string _categoryName = string.Empty;
    int _discontinued = 0;

    private void frmProducts_Load(object sender, EventArgs e) {
        _conn = Minimart.Connect(); //เรียกใช้ฟังก์ชันเชื่อมต่อฐานข้อมูล
        string sql = "select productID,ProductName,UnitPrice,UnitsInStock"
                     + " ,c.CategoryID,CategoryName,discontinued "
                     + " from products p join Categories c "
                     + " on p.CategoryID = c.CategoryID"; //คำสั่ง SQL สำหรับดึงข้อมูลจากตาราง Products
        ShowData(sql, dgvProducts);
    }

    private void ShowData(string sql, DataGridView dgv) {
        SqlCommand cmd = new SqlCommand(sql, _conn); //สร้างคำสั่ง SQL
        SqlDataAdapter da = new SqlDataAdapter(cmd); //สร้างตัวดึงข้อมูล
        DataSet ds = new DataSet(); //สร้างตัวเก็บข้อมูล
        da.Fill(ds); //ดึงข้อมูลใส่ตัวเก็บข้อมูล
        dgv.DataSource = ds.Tables[0]; //แสดงข้อมูลใน DataGridView
    }

    private void txtSearch_TextChanged(object sender, EventArgs e) {
        SearchProduct(txtSearch.Text);
    }

    private void SearchProduct(string text) {
        string sql = "Select productID,productName,UnitPrice,UnitsInStock,"
                     + " p.CategoryID, CategoryName,Discontinued"
                     + " from products p inner join Categories c on p.CategoryID = c.CategoryID"
                     + " where productName  like '%'+@str+'%'  "
                     + " or CategoryName like '%'+@str+'%'";
        SqlCommand cmd = new SqlCommand(sql, _conn); //สร้างคำสั่ง SQL
        cmd.Parameters.AddWithValue("@str", text);
        SqlDataAdapter da = new SqlDataAdapter(cmd); //สร้างตัวดึงข้อมูล
        DataSet ds = new DataSet(); //สร้างตัวเก็บข้อมูล
        da.Fill(ds); //ดึงข้อมูลใส่ตัวเก็บข้อมูล
        dgvProducts.DataSource = ds.Tables[0]; //แสดงข้อมูลใน DataGridView
    }

    private void btnAdd_Click(object sender, EventArgs e) {
        FrmEditProduct f = new FrmEditProduct();
        f.Status = "insert";
        f.ShowDialog();

        //โหลดข้อมูลใหม่หลังจากเพิ่มข้อมูลส มิฉะนั้นข้อมูลตัวใหม่จะไม่แสดง
        string sql = "select productID,ProductName,UnitPrice,UnitsInStock"
                     + " ,c.CategoryID,CategoryName,discontinued"
                     + " from products p join Categories c "
                     + " on p.CategoryID = c.CategoryID"; //คำสั่ง SQL สำหรับดึงข้อมูลจากตาราง Products
        ShowData(sql, dgvProducts);
    }

    private void dgvProducts_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e) {
        _productId = dgvProducts.CurrentRow.Cells[0].Value.ToString();
        _productName = dgvProducts.CurrentRow.Cells[1].Value.ToString();
        _unitPrice = Convert.ToDouble(dgvProducts.CurrentRow.Cells[2].Value);
        _unitsInStock = Convert.ToInt16(dgvProducts.CurrentRow.Cells[3].Value);
        _categoryId = Convert.ToInt16(dgvProducts.CurrentRow.Cells[4].Value);
        _categoryName = dgvProducts.CurrentRow.Cells[5].Value.ToString();
        _discontinued = Convert.ToInt16(dgvProducts.CurrentRow.Cells[6].Value);
    }

    private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
        _productId = dgvProducts.CurrentRow.Cells[0].Value.ToString();
        _productName = dgvProducts.CurrentRow.Cells[1].Value.ToString();
        _unitPrice = Convert.ToDouble(dgvProducts.CurrentRow.Cells[2].Value);
        _unitsInStock = Convert.ToInt16(dgvProducts.CurrentRow.Cells[3].Value);
        _categoryId = Convert.ToInt16(dgvProducts.CurrentRow.Cells[4].Value);
        _categoryName = dgvProducts.CurrentRow.Cells[5].Value.ToString();
        _discontinued = Convert.ToInt16(dgvProducts.CurrentRow.Cells[6].Value);

        FrmEditProduct f = new FrmEditProduct();
        f.ProductId = _productId;
        f.CatProductName = _productName;
        f.UnitPrice = _unitPrice;
        f.UnitsInStock = _unitsInStock;
        f.CategoryId = _categoryId;
        f.CategoryName = _categoryName;
        f.Discontinued = _discontinued;
        f.Status = "update";
        f.ShowDialog();

        string sql = "Select productID, productName, UnitPrice, UnitsInStock, "
                     + " p.CategoryID, CategoryName, Discontinued"
                     + " from products p inner join Categories c on p.CategoryID = c.CategoryID";
        ShowData(sql, dgvProducts);
    }
}