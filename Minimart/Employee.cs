using Microsoft.Data.SqlClient;
using System.Data;

namespace Minimart;

public partial class Employee : Form {
    public Employee() {
        InitializeComponent();
    }

    private SqlConnection? _conn;

    private int _employeeId;
    private string _title = string.Empty;
    private string _firstName = string.Empty;
    private string _lastName = string.Empty;
    private string _position = string.Empty;
    private string _username = string.Empty;
    private string _password = string.Empty;

    private void Employee_Load(object sender, EventArgs e) {
        _conn = Minimart.Connect();
        LoadEmployees("");
    }

    private void LoadEmployees(string search) {
        if (_conn == null) {
            return;
        }

        string sql =
            "SELECT EmployeeID, Title, FirstName, LastName, Position, Username, Password " +
            "FROM Employees " +
            "WHERE (@search = '' " +
            "   OR Title LIKE @like " +
            "   OR FirstName LIKE @like " +
            "   OR LastName LIKE @like " +
            "   OR Position LIKE @like " +
            "   OR Username LIKE @like " +
            "   OR CONVERT(varchar(20), EmployeeID) LIKE @like) " +
            "ORDER BY EmployeeID";

        using SqlCommand cmd = new SqlCommand(sql, _conn);
        cmd.Parameters.AddWithValue("@search", search);
        cmd.Parameters.AddWithValue("@like", "%" + search + "%");

        using SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        dgvProducts.DataSource = dt;

        if (dgvProducts.Columns["Password"] != null) {
            dgvProducts.Columns["Password"].Visible = false;
        }
    }

    private void CaptureSelectedEmployee() {
        if (dgvProducts.CurrentRow == null) {
            return;
        }

        _employeeId = Convert.ToInt32(dgvProducts.CurrentRow.Cells["EmployeeID"].Value);
        _title = dgvProducts.CurrentRow.Cells["Title"].Value?.ToString() ?? "";
        _firstName = dgvProducts.CurrentRow.Cells["FirstName"].Value?.ToString() ?? "";
        _lastName = dgvProducts.CurrentRow.Cells["LastName"].Value?.ToString() ?? "";
        _position = dgvProducts.CurrentRow.Cells["Position"].Value?.ToString() ?? "";
        _username = dgvProducts.CurrentRow.Cells["Username"].Value?.ToString() ?? "";
        _password = dgvProducts.CurrentRow.Cells["Password"].Value?.ToString() ?? "";
    }

    private void txtSearch_TextChanged(object sender, EventArgs e) {
        LoadEmployees(txtSearch.Text.Trim());
    }

    private void btnAdd_Click(object sender, EventArgs e) {
        FrmEditEmployee f = new FrmEditEmployee {
            EmployeeId = 0,
            Title = "",
            FirstName = "",
            LastName = "",
            Position = "",
            Username = "",
            Password = "",
            Status = "insert"
        };
        f.ShowDialog();

        LoadEmployees(txtSearch.Text.Trim());
    }

    private void dgvProducts_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e) {
        CaptureSelectedEmployee();
    }

    private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
        CaptureSelectedEmployee();
        if (_employeeId <= 0) {
            return;
        }

        FrmEditEmployee f = new FrmEditEmployee {
            EmployeeId = _employeeId,
            Title = _title,
            FirstName = _firstName,
            LastName = _lastName,
            Position = _position,
            Username = _username,
            Password = _password,
            Status = "update"
        };
        f.ShowDialog();

        LoadEmployees(txtSearch.Text.Trim());
    }

    private void btnDel_Click(object sender, EventArgs e) {
        if (_conn == null) {
            return;
        }

        CaptureSelectedEmployee();
        if (_employeeId <= 0) {
            MessageBox.Show("กรุณาเลือกพนักงานที่ต้องการลบ");
            return;
        }

        DialogResult dr = MessageBox.Show(
            "ต้องการลบพนักงานใช่หรือไม่?",
            "ยืนยันการลบ",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (dr != DialogResult.Yes) {
            return;
        }

        try {
            if (_conn.State != ConnectionState.Open) {
                _conn.Open();
            }

            using SqlCommand cmd = new SqlCommand("DELETE FROM Employees WHERE EmployeeID = @EmployeeID", _conn);
            cmd.Parameters.AddWithValue("@EmployeeID", _employeeId);
            cmd.ExecuteNonQuery();
        }
        catch (SqlException ex) {
            MessageBox.Show(ex.Message, "เกิดข้อผิดพลาด");
        }

        _employeeId = 0;
        _title = "";
        _firstName = "";
        _lastName = "";
        _position = "";
        _username = "";
        _password = "";

        LoadEmployees(txtSearch.Text.Trim());
    }
}

