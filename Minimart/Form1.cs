using Microsoft.Data.SqlClient;
using System.Data;

namespace Minimart;

public partial class Form1 : Form {
    private SqlConnection? _conn;
    
    public Form1()
    {
        InitializeComponent();
    }
    
    private void Form1_Load(object sender, EventArgs e)
    {
        _conn = Minimart.Connect(); 
        string sql = "Select * from Products";
        ShowData1(sql, dataGridView1);
    }

    private void ShowData1(string sql, DataGridView dgv)
    {
        SqlCommand cmd = new SqlCommand(sql, _conn); //ÊÃéÒ§¤ÓÊÑè§ SQL
        SqlDataAdapter da = new SqlDataAdapter(cmd); //ÊÃéÒ§µÑÇ´Ö§¢éÍÁÙÅ
        DataSet ds = new DataSet(); //ÊÃéÒ§µÑÇà¡çº¢éÍÁÙÅ
        da.Fill(ds, "products"); //´Ö§¢éÍÁÙÅãÊèµÑÇà¡çº¢éÍÁÙÅ
        dgv.DataSource = ds.Tables["products"]; //áÊ´§¢éÍÁÙÅã¹ DataGridView
    }

    private void ShowData()
    {
        string sql = "select productID,ProductName,UnitPrice,UnitsInStock"
                     + " ,c.CategoryID,CategoryName "
                     + " from products p join Categories c "
                     + " on p.CategoryID = c.CategoryID"; 
        SqlCommand cmd = new SqlCommand(sql, _conn); 
        SqlDataAdapter da = new SqlDataAdapter(cmd); 
        DataSet ds = new DataSet(); 
        da.Fill(ds, "products");
        dgvProducts.DataSource = ds.Tables["products"];
    }
    
}