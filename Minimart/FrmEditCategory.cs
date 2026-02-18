using System.ComponentModel;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Minimart;

public partial class FrmEditCategory : Form {
    private SqlConnection? _conn;

    [DefaultValue(0)]
    public int CategoryId { get; set; } 

    [DefaultValue("")]
    public string CategoryName { get; set; } 

    [DefaultValue("")] // You can set a string default too
    public string Status { get; set; }
    
    [DefaultValue("")]
    public string Description { get; set; }


    public FrmEditCategory() {
        InitializeComponent();
        CategoryId = 0;
        CategoryName = "";
        Description = "";
        Status = "";
    }
    
    private void frmEditCategory_Load(object sender, EventArgs e) {
        _conn = Minimart.Connect();
        //นำข้อมูลเริ่มต้นที่ส่งมาจากฟอร์มหลักมาแสดง
        txtCategoryID.Text = CategoryId.ToString();
        txtCategoryName.Text = CategoryName;
        txtDescription.Text = Description;

        txtCategoryID.Enabled = false;
        txtCategoryName.Focus();
    }

    private void btnClear_Click(object sender, EventArgs e) {
        txtCategoryID.Text = CategoryId.ToString();
        txtCategoryName.Text = CategoryName;
        txtDescription.Text = Description;
    }

    private void btnSave_Click(object sender, EventArgs e) {
        if (Status == "Insert") {
            InsertData();
        } else if (Status == "Update") {
            UpdateData();
        }
    }

    private void UpdateData() {
        string sql = "Update Categories set CategoryName = @CategoryName,"
                     + " Description = @Description "
                     + " Where categoryID = @CategoryID";
        SqlCommand cmd = new SqlCommand(sql, _conn);
        cmd.Parameters.AddWithValue("@CategoryName", txtCategoryName.Text.Trim());
        cmd.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());
        cmd.Parameters.AddWithValue("@CategoryID", Convert.ToInt32(txtCategoryID.Text.Trim()));
        if (_conn.State != ConnectionState.Open) {
            _conn.Open();
        }

        int row = cmd.ExecuteNonQuery();
        if (row > 0) {
            MessageBox.Show("ปรับปรุงข้อมูลเรียบร้อยแล้ว");
        } else {
            MessageBox.Show("ไม่สามารถปรับปรุงข้อมูลได้");
        }

        this.Close();
    }

    private void InsertData() {
        string sql = "INSERT INTO Categories (CategoryName, Description) "
                     + "VALUES (@CategoryName, @Description)";
        SqlCommand cmd = new SqlCommand(sql, _conn);
        cmd.Parameters.AddWithValue("@CategoryName", txtCategoryName.Text.Trim());
        cmd.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());
        if (_conn.State != ConnectionState.Open) {
            _conn.Open();
        }

        int row = cmd.ExecuteNonQuery();
        if (row > 0) {
            MessageBox.Show("เพิ่มข้อมูลเรียบร้อยแล้ว");
        } else {
            MessageBox.Show("ไม่สามารถเพิ่มข้อมูลได้");
        }

        this.Close();
    }
}