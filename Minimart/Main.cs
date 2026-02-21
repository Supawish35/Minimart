namespace Minimart;

public partial class Main : Form {
    private int _employeeId;
    private string _employeeName;
    private string _position;

    public Main() {
        InitializeComponent();
        _employeeId = -1;
        _employeeName = "";
        _position = "";
    }

    public Main(int employeeId, string employeeName, string position) {
        InitializeComponent();
        _employeeId = employeeId;
        _employeeName = employeeName;
        _position = position;
    }

    private void Main_Load(object sender, EventArgs e) {
        ShowStartMenu();
        Authorize();
    }

    private void Authorize() {
        bool canManage = _position == "Sale Manager" || _position == "Manager";

        mnuCRUD.Visible = canManage;
        mnuProduct.Visible = canManage;
        mnuCategory.Visible = canManage;
        mnuEmployee.Visible = canManage;
        mnuEmployeeSale.Visible = canManage;
        mnuPos.Visible = !canManage;

        mnuReport.Visible = true;
        mnuLogout.Visible = true;
    }

    private void mnuPos_Click(object sender, EventArgs e) {
        OpenChildForm<FrmPos>(form => {
            form.EmpId = _employeeId;
            form.EmpName = _employeeName;
            form.Position = _position;
        });
    }

    private void mnuCategory_Click(object sender, EventArgs e) {
        OpenChildForm<Category>();
    }

    private void mnuProduct_Click(object sender, EventArgs e) {
        OpenChildForm<Products>();
    }

    private void mnuEmployee_Click(object sender, EventArgs e) {
        OpenChildForm<Employee>();
    }

    private void mnuProductByCategory_Click(object sender, EventArgs e) {
        OpenChildForm<ProductByCategory>();
    }

    private void mnuEmployeeSale_Click(object sender, EventArgs e) {
        OpenChildForm<EmployeeSale>();
    }

    private void mnuLogin_Click(object sender, EventArgs e) {
        MessageBox.Show("Already logged in.", "Info",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void mnuLogout_Click(object sender, EventArgs e) {
        _employeeId = -1;
        _employeeName = "";
        _position = "";
        Application.Restart();
    }

    private T OpenChildForm<T>(Action<T>? configure = null) where T : Form, new() {
        foreach (Form child in MdiChildren.ToArray()) {
            child.Close();
        }

        T form = new T {
            MdiParent = this,
            WindowState = FormWindowState.Maximized
        };

        configure?.Invoke(form);
        form.Show();
        return form;
    }

    private void ShowStartMenu() {
        foreach (var form in MdiChildren) {
            form.Close();
        }
    }
}

