using System.Data;
using Microsoft.Data.SqlClient;

namespace Minimart;

public partial class ProductByCategory : Form {
    private SqlConnection _conn;

    public ProductByCategory() {
        InitializeComponent();
        _conn = Minimart.Connect();
    }

    private void ProductByCategory_Load(object sender, EventArgs e) {
        ValidateCategory();
    }

    private void ShowProduct(int categoryId) {
        SqlCommand cmd = new SqlCommand();

        if (categoryId == 0) {
            string sql = "Select ProductID, ProductName, UnitPrice, UnitsInStock From Products";

            cmd = new SqlCommand(sql, _conn);
        } else {
            string sql =
                "Select ProductID, ProductName, UnitPrice, UnitsInStock From Products Where CategoryID=@CategoryID";

            cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@CategoryID", categoryId);
        }

        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        
        dgvProduct.DataSource = ds.Tables[0];
    }

    private void ValidateCategory() {
        SqlCommand cmd = new SqlCommand();

        string sql = "Select CategoryID, CategoryName From Categories";
        cmd = new SqlCommand(sql, _conn);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);

        DataRow dr = ds.Tables[0].NewRow();
        dr["CategoryID"] = 0;
        dr["CategoryName"] = "Show All";

        ds.Tables[0].Rows.InsertAt(dr, 0);

        dgvCategory.DataSource = ds.Tables[0];
    }

    private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e) {
        if (e.RowIndex >= 0) {
            var cellValue = dgvCategory.Rows[e.RowIndex].Cells[0].Value;

            if (cellValue != null && int.TryParse(cellValue.ToString(), out int cateId)) {
                ShowProduct(cateId);
            }
        }
    }
}