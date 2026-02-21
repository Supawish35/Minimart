using System.Data;
using Microsoft.Data.SqlClient;

namespace Minimart;

public partial class EmployeeSale : Form {
    private readonly SqlConnection _conn;

    public EmployeeSale() {
        InitializeComponent();
        _conn = Minimart.Connect();
    }

    private void EmployeeSale_Load(object sender, EventArgs e) {
        ShowEmployees();
        ShowSales(0);
    }

    private void ShowEmployees() {
        string sql = "Select EmployeeID, Title + FirstName + space(2) + LastName as EmployeeName From Employees Order by EmployeeID";
        SqlCommand cmd = new SqlCommand(sql, _conn);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);

        DataRow dr = ds.Tables[0].NewRow();
        dr["EmployeeID"] = 0;
        dr["EmployeeName"] = "Show All";
        ds.Tables[0].Rows.InsertAt(dr, 0);

        dgvEmployee.DataSource = ds.Tables[0];
    }

    private void ShowSales(int employeeId) {
        string sql =
            "Select e.EmployeeID, " +
            "       e.Title + e.FirstName + space(2) + e.LastName as EmployeeName, " +
            "       Count(r.ReceiptID) as TotalReceipts, " +
            "       IsNull(Sum(r.TotalCash), 0) as TotalSales " +
            "From Employees e " +
            "Left Join Receipts r on e.EmployeeID = r.EmployeeID " +
            "Where (@EmployeeID = 0 or e.EmployeeID = @EmployeeID) " +
            "Group By e.EmployeeID, e.Title, e.FirstName, e.LastName " +
            "Order By e.EmployeeID";

        SqlCommand cmd = new SqlCommand(sql, _conn);
        cmd.Parameters.AddWithValue("@EmployeeID", employeeId);

        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);

        dgvSale.DataSource = ds.Tables[0];
    }

    private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e) {
        if (e.RowIndex < 0) {
            return;
        }

        var cellValue = dgvEmployee.Rows[e.RowIndex].Cells[0].Value;
        if (cellValue == null) {
            return;
        }

        if (int.TryParse(cellValue.ToString(), out int employeeId)) {
            ShowSales(employeeId);
        }
    }
}

