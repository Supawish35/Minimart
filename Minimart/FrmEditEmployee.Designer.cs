using System.ComponentModel;

namespace Minimart;

partial class FrmEditEmployee {
    private IContainer components = null;

    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent() {
        labelHeader = new Label();
        labelEmployeeId = new Label();
        txtEmployeeId = new TextBox();
        labelTitle = new Label();
        txtTitle = new TextBox();
        labelFirstName = new Label();
        txtFirstName = new TextBox();
        labelLastName = new Label();
        txtLastName = new TextBox();
        labelPosition = new Label();
        txtPosition = new TextBox();
        labelUsername = new Label();
        txtUsername = new TextBox();
        labelPassword = new Label();
        txtPassword = new TextBox();
        btnSave = new Button();
        btnClear = new Button();
        btnCancel = new Button();
        SuspendLayout();
        // 
        // labelHeader
        // 
        labelHeader.AutoSize = true;
        labelHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        labelHeader.ForeColor = Color.Blue;
        labelHeader.Location = new Point(12, 15);
        labelHeader.Name = "labelHeader";
        labelHeader.Size = new Size(137, 28);
        labelHeader.TabIndex = 0;
        labelHeader.Text = "ข้อมูลพนักงาน";
        // 
        // labelEmployeeId
        // 
        labelEmployeeId.AutoSize = true;
        labelEmployeeId.Location = new Point(12, 60);
        labelEmployeeId.Name = "labelEmployeeId";
        labelEmployeeId.Size = new Size(91, 20);
        labelEmployeeId.TabIndex = 1;
        labelEmployeeId.Text = "EmployeeID";
        // 
        // txtEmployeeId
        // 
        txtEmployeeId.Location = new Point(130, 57);
        txtEmployeeId.Name = "txtEmployeeId";
        txtEmployeeId.ReadOnly = true;
        txtEmployeeId.Size = new Size(180, 27);
        txtEmployeeId.TabIndex = 2;
        // 
        // labelTitle
        // 
        labelTitle.AutoSize = true;
        labelTitle.Location = new Point(12, 97);
        labelTitle.Name = "labelTitle";
        labelTitle.Size = new Size(37, 20);
        labelTitle.TabIndex = 3;
        labelTitle.Text = "Title";
        // 
        // txtTitle
        // 
        txtTitle.Location = new Point(130, 94);
        txtTitle.Name = "txtTitle";
        txtTitle.Size = new Size(180, 27);
        txtTitle.TabIndex = 4;
        // 
        // labelFirstName
        // 
        labelFirstName.AutoSize = true;
        labelFirstName.Location = new Point(12, 134);
        labelFirstName.Name = "labelFirstName";
        labelFirstName.Size = new Size(75, 20);
        labelFirstName.TabIndex = 5;
        labelFirstName.Text = "FirstName";
        // 
        // txtFirstName
        // 
        txtFirstName.Location = new Point(130, 131);
        txtFirstName.Name = "txtFirstName";
        txtFirstName.Size = new Size(260, 27);
        txtFirstName.TabIndex = 6;
        // 
        // labelLastName
        // 
        labelLastName.AutoSize = true;
        labelLastName.Location = new Point(12, 171);
        labelLastName.Name = "labelLastName";
        labelLastName.Size = new Size(74, 20);
        labelLastName.TabIndex = 7;
        labelLastName.Text = "LastName";
        // 
        // txtLastName
        // 
        txtLastName.Location = new Point(130, 168);
        txtLastName.Name = "txtLastName";
        txtLastName.Size = new Size(260, 27);
        txtLastName.TabIndex = 8;
        // 
        // labelPosition
        // 
        labelPosition.AutoSize = true;
        labelPosition.Location = new Point(12, 208);
        labelPosition.Name = "labelPosition";
        labelPosition.Size = new Size(61, 20);
        labelPosition.TabIndex = 9;
        labelPosition.Text = "Position";
        // 
        // txtPosition
        // 
        txtPosition.Location = new Point(130, 205);
        txtPosition.Name = "txtPosition";
        txtPosition.Size = new Size(260, 27);
        txtPosition.TabIndex = 10;
        // 
        // labelUsername
        // 
        labelUsername.AutoSize = true;
        labelUsername.Location = new Point(12, 245);
        labelUsername.Name = "labelUsername";
        labelUsername.Size = new Size(73, 20);
        labelUsername.TabIndex = 11;
        labelUsername.Text = "Username";
        // 
        // txtUsername
        // 
        txtUsername.Location = new Point(130, 242);
        txtUsername.Name = "txtUsername";
        txtUsername.Size = new Size(260, 27);
        txtUsername.TabIndex = 12;
        // 
        // labelPassword
        // 
        labelPassword.AutoSize = true;
        labelPassword.Location = new Point(12, 282);
        labelPassword.Name = "labelPassword";
        labelPassword.Size = new Size(70, 20);
        labelPassword.TabIndex = 13;
        labelPassword.Text = "Password";
        // 
        // txtPassword
        // 
        txtPassword.Location = new Point(130, 279);
        txtPassword.Name = "txtPassword";
        txtPassword.Size = new Size(260, 27);
        txtPassword.TabIndex = 14;
        txtPassword.UseSystemPasswordChar = true;
        // 
        // btnSave
        // 
        btnSave.Location = new Point(130, 328);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(94, 29);
        btnSave.TabIndex = 15;
        btnSave.Text = "Save";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += btnSave_Click;
        // 
        // btnClear
        // 
        btnClear.Location = new Point(230, 328);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(94, 29);
        btnClear.TabIndex = 16;
        btnClear.Text = "Clear";
        btnClear.UseVisualStyleBackColor = true;
        btnClear.Click += btnClear_Click;
        // 
        // btnCancel
        // 
        btnCancel.Location = new Point(330, 328);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(94, 29);
        btnCancel.TabIndex = 17;
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Click += btnCancel_Click;
        // 
        // FrmEditEmployee
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(255, 255, 192);
        ClientSize = new Size(444, 375);
        Controls.Add(btnCancel);
        Controls.Add(btnClear);
        Controls.Add(btnSave);
        Controls.Add(txtPassword);
        Controls.Add(labelPassword);
        Controls.Add(txtUsername);
        Controls.Add(labelUsername);
        Controls.Add(txtPosition);
        Controls.Add(labelPosition);
        Controls.Add(txtLastName);
        Controls.Add(labelLastName);
        Controls.Add(txtFirstName);
        Controls.Add(labelFirstName);
        Controls.Add(txtTitle);
        Controls.Add(labelTitle);
        Controls.Add(txtEmployeeId);
        Controls.Add(labelEmployeeId);
        Controls.Add(labelHeader);
        Name = "FrmEditEmployee";
        Text = "แก้ไขข้อมูลพนักงาน";
        Load += FrmEditEmployee_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelHeader;
    private Label labelEmployeeId;
    private TextBox txtEmployeeId;
    private Label labelTitle;
    private TextBox txtTitle;
    private Label labelFirstName;
    private TextBox txtFirstName;
    private Label labelLastName;
    private TextBox txtLastName;
    private Label labelPosition;
    private TextBox txtPosition;
    private Label labelUsername;
    private TextBox txtUsername;
    private Label labelPassword;
    private TextBox txtPassword;
    private Button btnSave;
    private Button btnClear;
    private Button btnCancel;
}

