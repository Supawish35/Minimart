using System.ComponentModel;

namespace Minimart;

partial class FrmEditProduct {
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
        groupBox2 = new GroupBox();
            label11 = new Label();
            label10 = new Label();
            radDiscontinued = new RadioButton();
            radContinued = new RadioButton();
            groupBox1 = new GroupBox();
            cboCategory = new ComboBox();
            label5 = new Label();
            txtProductName = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label8 = new Label();
            label3 = new Label();
            txtUnitsInStock = new TextBox();
            label6 = new Label();
            label9 = new Label();
            label4 = new Label();
            label2 = new Label();
            txtUnitPrice = new TextBox();
            label1 = new Label();
            txtProductID = new TextBox();
            btnClear = new Button();
            label21 = new Label();
            label7 = new Label();
            btnSave = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(radDiscontinued);
            groupBox2.Controls.Add(radContinued);
            groupBox2.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox2.Location = new Point(248, 330);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(340, 135);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            groupBox2.Text = "สถานะของสินค้า";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(154, 90);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(153, 25);
            label11.TabIndex = 23;
            label11.Text = "radDiscontinued";
            label11.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(178, 44);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(130, 25);
            label10.TabIndex = 23;
            label10.Text = "radContinued";
            label10.Visible = false;
            // 
            // radDiscontinued
            // 
            radDiscontinued.AutoSize = true;
            radDiscontinued.Location = new Point(34, 87);
            radDiscontinued.Margin = new Padding(4, 5, 4, 5);
            radDiscontinued.Name = "radDiscontinued";
            radDiscontinued.Size = new Size(117, 29);
            radDiscontinued.TabIndex = 22;
            radDiscontinued.TabStop = true;
            radDiscontinued.Text = "เลิกจำหน่าย";
            radDiscontinued.UseVisualStyleBackColor = true;
            // 
            // radContinued
            // 
            radContinued.AutoSize = true;
            radContinued.Location = new Point(34, 40);
            radContinued.Margin = new Padding(4, 5, 4, 5);
            radContinued.Name = "radContinued";
            radContinued.Size = new Size(125, 29);
            radContinued.TabIndex = 21;
            radContinued.TabStop = true;
            radContinued.Text = "จำหน่ายปกติ";
            radContinued.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboCategory);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtUnitsInStock);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtUnitPrice);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtProductID);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox1.Location = new Point(39, 14);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(549, 306);
            groupBox1.TabIndex = 36;
            groupBox1.TabStop = false;
            groupBox1.Text = "จัดการข้อมูลสินค้า";
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(147, 235);
            cboCategory.Margin = new Padding(4, 5, 4, 5);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(260, 33);
            cboCategory.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(358, 90);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(151, 25);
            label5.TabIndex = 6;
            label5.Text = "txtProductName";
            label5.Visible = false;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(147, 88);
            txtProductName.Margin = new Padding(4, 5, 4, 5);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(260, 30);
            txtProductName.TabIndex = 16;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 12F);
            label14.ForeColor = Color.Red;
            label14.Location = new Point(413, 244);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(124, 25);
            label14.TabIndex = 6;
            label14.Text = "cboCategory";
            label14.Visible = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 12F);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(358, 188);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(142, 25);
            label13.TabIndex = 6;
            label13.Text = "txtUnitsInStock";
            label13.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(56, 197);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(63, 25);
            label8.TabIndex = 15;
            label8.Text = "จำนวน";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 148);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(47, 25);
            label3.TabIndex = 14;
            label3.Text = "ราคา";
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(147, 186);
            txtUnitsInStock.Margin = new Padding(4, 5, 4, 5);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(116, 30);
            txtUnitsInStock.TabIndex = 3;
            txtUnitsInStock.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(358, 144);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(110, 25);
            label6.TabIndex = 7;
            label6.Text = "txtUnitPrice";
            label6.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1, 247);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(109, 25);
            label9.TabIndex = 3;
            label9.Text = "ประเภทสินค้า";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(342, 45);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(118, 25);
            label4.TabIndex = 6;
            label4.Text = "txtProductID";
            label4.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 99);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 3;
            label2.Text = "ชื่อสินค้า";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(147, 137);
            txtUnitPrice.Margin = new Padding(4, 5, 4, 5);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(116, 30);
            txtUnitPrice.TabIndex = 2;
            txtUnitPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 50);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 1;
            label1.Text = "รหัสสินค้า";
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(147, 38);
            txtProductID.Margin = new Padding(4, 5, 4, 5);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(185, 30);
            txtProductID.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(320, 498);
            btnClear.Margin = new Padding(4, 5, 4, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 34);
            btnClear.TabIndex = 37;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft Sans Serif", 12F);
            label21.ForeColor = Color.Red;
            label21.Location = new Point(316, 535);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(86, 25);
            label21.TabIndex = 38;
            label21.Text = "btnClear";
            label21.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(182, 535);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(85, 25);
            label7.TabIndex = 38;
            label7.Text = "btnSave";
            label7.Visible = false;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(186, 498);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 34);
            btnSave.TabIndex = 37;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmEditProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(602, 570);
            Controls.Add(btnSave);
            Controls.Add(label7);
            Controls.Add(btnClear);
            Controls.Add(label21);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmEditProducts";
            Text = "แบบฟอร์มข้อมูลสินค้า";
            Load += frmEditProducts_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private GroupBox groupBox2;
        private Label label11;
        private Label label10;
        private RadioButton radDiscontinued;
        private RadioButton radContinued;
        private GroupBox groupBox1;
        private ComboBox cboCategory;
        private Label label5;
        private TextBox txtProductName;
        private Label label14;
        private Label label13;
        private Label label8;
        private Label label3;
        private TextBox txtUnitsInStock;
        private Label label6;
        private Label label9;
        private Label label4;
        private Label label2;
        private TextBox txtUnitPrice;
        private Label label1;
        private TextBox txtProductID;
        private Button btnClear;
        private Label label21;
        private Label label7;
        private Button btnSave;

    }
    

    