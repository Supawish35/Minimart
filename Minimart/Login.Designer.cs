using System.ComponentModel;

namespace Minimart;

partial class Login {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        label1 = new System.Windows.Forms.Label();
        txtUsername = new System.Windows.Forms.TextBox();
        btnAccept = new System.Windows.Forms.Button();
        btnCancel = new System.Windows.Forms.Button();
        txtPassword = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(186, 168);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(77, 19);
        label1.TabIndex = 0;
        label1.Text = "Username";
        // 
        // txtUsername
        // 
        txtUsername.Location = new System.Drawing.Point(267, 165);
        txtUsername.Name = "txtUsername";
        txtUsername.Size = new System.Drawing.Size(426, 27);
        txtUsername.TabIndex = 1;
        // 
        // btnAccept
        // 
        btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
        btnAccept.Location = new System.Drawing.Point(360, 242);
        btnAccept.Name = "btnAccept";
        btnAccept.Size = new System.Drawing.Size(84, 36);
        btnAccept.TabIndex = 3;
        btnAccept.Text = "ลงชื่อ";
        btnAccept.UseVisualStyleBackColor = true;
        btnAccept.Click += btnAccept_Click;
        // 
        // btnCancel
        // 
        btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        btnCancel.Location = new System.Drawing.Point(483, 242);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new System.Drawing.Size(88, 36);
        btnCancel.TabIndex = 4;
        btnCancel.Text = "ยกเลิก";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Click += btnCancel_Click;
        // 
        // txtPassword
        // 
        txtPassword.Location = new System.Drawing.Point(267, 198);
        txtPassword.Name = "txtPassword";
        txtPassword.Size = new System.Drawing.Size(426, 27);
        txtPassword.TabIndex = 2;
        txtPassword.UseSystemPasswordChar = true;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(186, 201);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(77, 19);
        label2.TabIndex = 4;
        label2.Text = "Password";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(415, 129);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(77, 19);
        label3.TabIndex = 6;
        label3.Text = "Login";
        // 
        // Login
        // 
        AcceptButton = btnAccept;
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        CancelButton = btnCancel;
        ClientSize = new System.Drawing.Size(950, 585);
        Controls.Add(label3);
        Controls.Add(txtPassword);
        Controls.Add(label2);
        Controls.Add(btnCancel);
        Controls.Add(btnAccept);
        Controls.Add(txtUsername);
        Controls.Add(label1);
        Text = "Login";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtUsername;
    private System.Windows.Forms.Button btnAccept;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Label label2;

    #endregion
}