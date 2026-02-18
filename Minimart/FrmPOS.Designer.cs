using System.ComponentModel;

namespace Minimart;

partial class FrmPos {
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
        txtEmployeeID = new System.Windows.Forms.TextBox();
        groupBox1 = new System.Windows.Forms.GroupBox();
        lsvProducts = new System.Windows.Forms.ListView();
        txtTotal = new System.Windows.Forms.TextBox();
        label9 = new System.Windows.Forms.Label();
        txtQuantity = new System.Windows.Forms.TextBox();
        label8 = new System.Windows.Forms.Label();
        txtUnitPrice = new System.Windows.Forms.TextBox();
        label7 = new System.Windows.Forms.Label();
        txtProductName = new System.Windows.Forms.TextBox();
        label6 = new System.Windows.Forms.Label();
        txtProductID = new System.Windows.Forms.TextBox();
        label5 = new System.Windows.Forms.Label();
        btnAdd = new System.Windows.Forms.Button();
        btnClear = new System.Windows.Forms.Button();
        btnSave = new System.Windows.Forms.Button();
        btnCancel = new System.Windows.Forms.Button();
        label2 = new System.Windows.Forms.Label();
        txtEmployeeName = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        lblNetPrice = new System.Windows.Forms.Label();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(13, 25);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(128, 23);
        label1.TabIndex = 0;
        label1.Text = "รหัสพนักงาน";
        // 
        // txtEmployeeID
        // 
        txtEmployeeID.Location = new System.Drawing.Point(96, 21);
        txtEmployeeID.Name = "txtEmployeeID";
        txtEmployeeID.Size = new System.Drawing.Size(178, 27);
        txtEmployeeID.TabIndex = 1;
        txtEmployeeID.KeyDown += txtEmployeeID_KeyDown;
        // 
        // groupBox1
        // 
        groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        groupBox1.Controls.Add(lsvProducts);
        groupBox1.Controls.Add(txtTotal);
        groupBox1.Controls.Add(label9);
        groupBox1.Controls.Add(txtQuantity);
        groupBox1.Controls.Add(label8);
        groupBox1.Controls.Add(txtUnitPrice);
        groupBox1.Controls.Add(label7);
        groupBox1.Controls.Add(txtProductName);
        groupBox1.Controls.Add(label6);
        groupBox1.Controls.Add(txtProductID);
        groupBox1.Controls.Add(label5);
        groupBox1.Location = new System.Drawing.Point(13, 89);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(838, 349);
        groupBox1.TabIndex = 2;
        groupBox1.TabStop = false;
        groupBox1.Text = "รายการสั่งซื้อ";
        // 
        // lsvProducts
        // 
        lsvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        lsvProducts.Location = new System.Drawing.Point(6, 105);
        lsvProducts.Name = "lsvProducts";
        lsvProducts.Size = new System.Drawing.Size(826, 238);
        lsvProducts.TabIndex = 21;
        lsvProducts.UseCompatibleStateImageBehavior = false;
        lsvProducts.DoubleClick += lsvProducts_DoubleClick;
        // 
        // txtTotal
        // 
        txtTotal.Location = new System.Drawing.Point(581, 54);
        txtTotal.Name = "txtTotal";
        txtTotal.ReadOnly = true;
        txtTotal.Size = new System.Drawing.Size(122, 27);
        txtTotal.TabIndex = 20;
        // 
        // label9
        // 
        label9.Location = new System.Drawing.Point(581, 28);
        label9.Name = "label9";
        label9.Size = new System.Drawing.Size(75, 23);
        label9.TabIndex = 19;
        label9.Text = "รวมเป็นเงิน";
        // 
        // txtQuantity
        // 
        txtQuantity.Location = new System.Drawing.Point(441, 54);
        txtQuantity.Name = "txtQuantity";
        txtQuantity.Size = new System.Drawing.Size(134, 27);
        txtQuantity.TabIndex = 18;
        txtQuantity.TextChanged += txtQuantity_TextChanged;
        txtQuantity.KeyDown += txtQuantity_KeyDown;
        // 
        // label8
        // 
        label8.Location = new System.Drawing.Point(441, 28);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(75, 23);
        label8.TabIndex = 17;
        label8.Text = "จำนวน";
        // 
        // txtUnitPrice
        // 
        txtUnitPrice.Location = new System.Drawing.Point(313, 54);
        txtUnitPrice.Name = "txtUnitPrice";
        txtUnitPrice.ReadOnly = true;
        txtUnitPrice.Size = new System.Drawing.Size(122, 27);
        txtUnitPrice.TabIndex = 16;
        // 
        // label7
        // 
        label7.Location = new System.Drawing.Point(313, 28);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(75, 23);
        label7.TabIndex = 15;
        label7.Text = "ราคาขาย";
        // 
        // txtProductName
        // 
        txtProductName.Location = new System.Drawing.Point(162, 54);
        txtProductName.Name = "txtProductName";
        txtProductName.ReadOnly = true;
        txtProductName.Size = new System.Drawing.Size(145, 27);
        txtProductName.TabIndex = 14;
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(162, 28);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(75, 23);
        label6.TabIndex = 13;
        label6.Text = "ชื่อสินค้า";
        // 
        // txtProductID
        // 
        txtProductID.Location = new System.Drawing.Point(6, 54);
        txtProductID.Name = "txtProductID";
        txtProductID.Size = new System.Drawing.Size(150, 27);
        txtProductID.TabIndex = 12;
        txtProductID.KeyDown += txtProductID_KeyDown;
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(6, 28);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(75, 23);
        label5.TabIndex = 11;
        label5.Text = "รหัสสินค้า";
        // 
        // btnAdd
        // 
        btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnAdd.Location = new System.Drawing.Point(862, 107);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new System.Drawing.Size(107, 33);
        btnAdd.TabIndex = 3;
        btnAdd.Text = "เพิ่มรายการ";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // btnClear
        // 
        btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnClear.Location = new System.Drawing.Point(862, 169);
        btnClear.Name = "btnClear";
        btnClear.Size = new System.Drawing.Size(107, 33);
        btnClear.TabIndex = 4;
        btnClear.Text = "ล้าง";
        btnClear.UseVisualStyleBackColor = true;
        btnClear.Click += btnClear_Click;
        // 
        // btnSave
        // 
        btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnSave.Enabled = false;
        btnSave.Location = new System.Drawing.Point(862, 300);
        btnSave.Name = "btnSave";
        btnSave.Size = new System.Drawing.Size(135, 41);
        btnSave.TabIndex = 5;
        btnSave.Text = "บันทึก";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += btnSave_Click;
        // 
        // btnCancel
        // 
        btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnCancel.Location = new System.Drawing.Point(862, 372);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new System.Drawing.Size(135, 41);
        btnCancel.TabIndex = 6;
        btnCancel.Text = "ยกเลิก";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Click += btnCancel_Click;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(310, 25);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(75, 23);
        label2.TabIndex = 7;
        label2.Text = "ชื่อ-สกุล";
        // 
        // txtEmployeeName
        // 
        txtEmployeeName.Location = new System.Drawing.Point(371, 25);
        txtEmployeeName.Name = "txtEmployeeName";
        txtEmployeeName.ReadOnly = true;
        txtEmployeeName.Size = new System.Drawing.Size(358, 27);
        txtEmployeeName.TabIndex = 8;
        // 
        // label3
        // 
        label3.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        label3.Location = new System.Drawing.Point(735, 25);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(75, 23);
        label3.TabIndex = 9;
        label3.Text = "รวมเป็นเงิน";
        // 
        // lblNetPrice
        // 
        lblNetPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblNetPrice.Font = new System.Drawing.Font("Monocraft Nerd Font", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblNetPrice.Location = new System.Drawing.Point(816, 9);
        lblNetPrice.Name = "lblNetPrice";
        lblNetPrice.Size = new System.Drawing.Size(181, 77);
        lblNetPrice.TabIndex = 10;
        lblNetPrice.Text = "000";
        lblNetPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
        // 
        // FrmPos
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1009, 450);
        Controls.Add(lblNetPrice);
        Controls.Add(label3);
        Controls.Add(txtEmployeeName);
        Controls.Add(label2);
        Controls.Add(btnCancel);
        Controls.Add(btnSave);
        Controls.Add(btnClear);
        Controls.Add(btnAdd);
        Controls.Add(groupBox1);
        Controls.Add(txtEmployeeID);
        Controls.Add(label1);
        Text = "FrmPOS";
        Load += frmReceipt_Details_Load;
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ListView lsvProducts;

    private System.Windows.Forms.TextBox txtProductID;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtProductName;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtUnitPrice;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox txtQuantity;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox txtTotal;
    private System.Windows.Forms.Label label9;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtEmployeeName;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label lblNetPrice;

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnCancel;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtEmployeeID;

    #endregion
}