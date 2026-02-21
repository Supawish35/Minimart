using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Minimart;

public partial class FrmEditEmployee : Form {
    public FrmEditEmployee() {
        InitializeComponent();

        EmployeeId = 0;
        Title = "";
        FirstName = "";
        LastName = "";
        Position = "";
        Username = "";
        Password = "";
        Status = "";
    }

    [DefaultValue(0)] public int EmployeeId { get; set; }
    [DefaultValue("")] public string Title { get; set; }
    [DefaultValue("")] public string FirstName { get; set; }
    [DefaultValue("")] public string LastName { get; set; }
    [DefaultValue("")] public string Position { get; set; }
    [DefaultValue("")] public string Username { get; set; }
    [DefaultValue("")] public string Password { get; set; }
    [DefaultValue("")] public string Status { get; set; } // insert, update

    private SqlConnection? _conn;

    private void FrmEditEmployee_Load(object sender, EventArgs e) {
        _conn = Minimart.Connect();

        txtEmployeeId.Text = EmployeeId <= 0 ? "" : EmployeeId.ToString();
        txtTitle.Text = Title;
        txtFirstName.Text = FirstName;
        txtLastName.Text = LastName;
        txtPosition.Text = Position;
        txtUsername.Text = Username;
        txtPassword.Text = Password;

        txtEmployeeId.Enabled = false;
        txtTitle.Focus();
    }

    private void btnClear_Click(object sender, EventArgs e) {
        if (Status == "insert") {
            txtEmployeeId.Text = "";
            txtTitle.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPosition.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
        } else {
            txtEmployeeId.Text = EmployeeId <= 0 ? "" : EmployeeId.ToString();
            txtTitle.Text = Title;
            txtFirstName.Text = FirstName;
            txtLastName.Text = LastName;
            txtPosition.Text = Position;
            txtUsername.Text = Username;
            txtPassword.Text = Password;
        }
    }

    private void btnCancel_Click(object sender, EventArgs e) {
        Close();
    }

    private void btnSave_Click(object sender, EventArgs e) {
        if (_conn == null) {
            return;
        }

        if (!ValidateInput()) {
            return;
        }

        if (Status == "insert") {
            InsertEmployee();
        } else if (Status == "update") {
            UpdateEmployee();
        }

        Close();
    }

    private bool ValidateInput() {
        if (txtTitle.Text.Trim() == "") {
            MessageBox.Show("กรุณากรอกคำนำหน้า");
            txtTitle.Focus();
            return false;
        }

        if (txtFirstName.Text.Trim() == "") {
            MessageBox.Show("กรุณากรอกชื่อ");
            txtFirstName.Focus();
            return false;
        }

        if (txtLastName.Text.Trim() == "") {
            MessageBox.Show("กรุณากรอกนามสกุล");
            txtLastName.Focus();
            return false;
        }

        if (txtPosition.Text.Trim() == "") {
            MessageBox.Show("กรุณากรอกตำแหน่ง");
            txtPosition.Focus();
            return false;
        }

        if (txtUsername.Text.Trim() == "") {
            MessageBox.Show("กรุณากรอก Username");
            txtUsername.Focus();
            return false;
        }

        if (txtPassword.Text.Trim() == "") {
            MessageBox.Show("กรุณากรอก Password");
            txtPassword.Focus();
            return false;
        }

        return true;
    }

    private void InsertEmployee() {
        if (_conn == null) {
            return;
        }

        string sql =
            "INSERT INTO Employees (Title, FirstName, LastName, Position, Username, Password) " +
            "VALUES (@Title, @FirstName, @LastName, @Position, @Username, @Password)";

        using SqlCommand cmd = new SqlCommand(sql, _conn);
        cmd.Parameters.AddWithValue("@Title", txtTitle.Text.Trim());
        cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
        cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
        cmd.Parameters.AddWithValue("@Position", txtPosition.Text.Trim());
        cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
        cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

        try {
            if (_conn.State != ConnectionState.Open) {
                _conn.Open();
            }

            cmd.ExecuteNonQuery();
        }
        catch (SqlException ex) {
            MessageBox.Show(ex.Message, "เกิดข้อผิดพลาด");
        }
    }

    private void UpdateEmployee() {
        if (_conn == null) {
            return;
        }

        string sql =
            "UPDATE Employees SET Title = @Title, FirstName = @FirstName, LastName = @LastName, " +
            "Position = @Position, Username = @Username, Password = @Password " +
            "WHERE EmployeeID = @EmployeeID";

        using SqlCommand cmd = new SqlCommand(sql, _conn);
        cmd.Parameters.AddWithValue("@EmployeeID", EmployeeId);
        cmd.Parameters.AddWithValue("@Title", txtTitle.Text.Trim());
        cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
        cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
        cmd.Parameters.AddWithValue("@Position", txtPosition.Text.Trim());
        cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
        cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

        try {
            if (_conn.State != ConnectionState.Open) {
                _conn.Open();
            }

            cmd.ExecuteNonQuery();
        }
        catch (SqlException ex) {
            MessageBox.Show(ex.Message, "เกิดข้อผิดพลาด");
        }
    }
}

