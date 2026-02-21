namespace Minimart;

public partial class Main : Form {
    public Main() {
        InitializeComponent();
    }

    private void OpenChildForm(Form formName) {
        foreach (Form f in this.MdiChildren) {
            if (f.GetType() == formName.GetType()) {
                f.Activate();
                return;
            }
        }

        formName.MdiParent = this;
        formName.WindowState = FormWindowState.Maximized;
        formName.Show();
    }

    private void productToolStripMenuItem_Click(object sender, EventArgs e) {
        OpenChildForm(new Products());
    }

    private void categoryToolStripMenuItem_Click(object sender, EventArgs e) {
        OpenChildForm(new Category());
    }

    private void employeeToolStripMenuItem_Click(object sender, EventArgs e) {
        OpenChildForm(new Employee());
    }

    private void pOSToolStripMenuItem_Click(object sender, EventArgs e) {
        OpenChildForm(new FrmPos());
    }
}