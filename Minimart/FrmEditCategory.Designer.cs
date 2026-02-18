using System.ComponentModel;

namespace Minimart;

partial class FrmEditCatagory {
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
     private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCategoryID = new TextBox();
            txtCategoryName = new TextBox();
            txtDescription = new TextBox();
            btnSave = new Button();
            btnClear = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 66);
            label1.Name = "label1";
            label1.Size = new Size(155, 28);
            label1.TabIndex = 0;
            label1.Text = "รหัสหมวดหมู่สินค้า";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 118);
            label2.Name = "label2";
            label2.Size = new Size(146, 28);
            label2.TabIndex = 1;
            label2.Text = "ชื่อหมวดหมู่สินค้า";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 170);
            label3.Name = "label3";
            label3.Size = new Size(96, 28);
            label3.TabIndex = 2;
            label3.Text = "รายละเอียด";
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(204, 69);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(125, 34);
            txtCategoryID.TabIndex = 3;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(203, 118);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(125, 34);
            txtCategoryName.TabIndex = 4;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(200, 169);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(242, 101);
            txtDescription.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(183, 297);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 41);
            btnSave.TabIndex = 6;
            btnSave.Text = "บันทึก";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(293, 297);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 42);
            btnClear.TabIndex = 7;
            btnClear.Text = "ล้างฟอร์ม";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 14F);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(335, 69);
            label4.Name = "label4";
            label4.Size = new Size(160, 32);
            label4.TabIndex = 8;
            label4.Text = "txtCategoryID";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 14F);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(334, 120);
            label5.Name = "label5";
            label5.Size = new Size(201, 32);
            label5.TabIndex = 8;
            label5.Text = "txtCategoryName";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 14F);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(416, 229);
            label6.Name = "label6";
            label6.Size = new Size(162, 32);
            label6.TabIndex = 8;
            label6.Text = "txtDescription";
            label6.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 14F);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(165, 350);
            label7.Name = "label7";
            label7.Size = new Size(100, 32);
            label7.TabIndex = 8;
            label7.Text = "btnSave";
            label7.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 14F);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(293, 350);
            label8.Name = "label8";
            label8.Size = new Size(104, 32);
            label8.TabIndex = 8;
            label8.Text = "btnClear";
            label8.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 16F);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(18, 9);
            label9.Name = "label9";
            label9.Size = new Size(211, 37);
            label9.TabIndex = 9;
            label9.Text = "frmEditCategory";
            label9.Visible = false;
            // 
            // frmEditCategory
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(639, 400);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(txtDescription);
            Controls.Add(txtCategoryName);
            Controls.Add(txtCategoryID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "frmEditCategory";
            Text = "frmEditCategory";
            Load += frmEditCategory_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCategoryID;
        private TextBox txtCategoryName;
        private TextBox txtDescription;
        private Button btnSave;
        private Button btnClear;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
}