using System.ComponentModel;
using Microsoft.Data.SqlClient;

namespace Minimart;

public partial class Login : Form {
    private SqlConnection _conn;
    
    [DefaultValue(-1)] public int EmployeeId  {get; set;}
    [DefaultValue("")] public string EmployeeName {get; set;}
    [DefaultValue("")] public string Position {get; set;}
    
    public Login() {
        InitializeComponent();
        _conn = Minimart.Connect();
        EmployeeId = -1;
        EmployeeName = string.Empty;
        Position = string.Empty;
    }
    
    

    private void btnAccept_Click(object sender, EventArgs e) {
        string username = txtUsername.Text.Trim();
        string password = txtPassword.Text.Trim();

        if (_conn.State == System.Data.ConnectionState.Closed) {
            _conn.Open();
        }

        string sql = "Select EmployeeID, SaleName = title + firstname + space(2) + LastName, Position From Employees " +
                     "Where username = @username and Password = @password";
        
        SqlCommand cmd = new SqlCommand(sql, _conn);
        cmd.Parameters.AddWithValue("@username", username);
        cmd.Parameters.AddWithValue("@password", password);
        SqlDataReader reader = cmd.ExecuteReader();
        if (reader.Read()) {
            EmployeeId = reader.GetInt32(0);
            EmployeeName = reader.GetString(1);
            Position = reader.GetString(2);
            this.DialogResult = DialogResult.OK;
            this.Close();
        } else {
            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }
    }

    private void btnCancel_Click(object sender, EventArgs e) {
        this.Close();
    }
}