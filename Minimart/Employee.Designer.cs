using System.ComponentModel;

namespace Minimart;

partial class Employee {
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
        dgvProducts = new System.Windows.Forms.DataGridView();
        label2 = new System.Windows.Forms.Label();
        txtSearch = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        btnAdd = new System.Windows.Forms.Button();
        btnDel = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
        SuspendLayout();
        // 
        // dgvProducts
        // 
        dgvProducts.AllowUserToAddRows = false;
        dgvProducts.AllowUserToDeleteRows = false;
        dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
        dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvProducts.Location = new System.Drawing.Point(12, 62);
        dgvProducts.Name = "dgvProducts";
        dgvProducts.ReadOnly = true;
        dgvProducts.RowHeadersWidth = 51;
        dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvProducts.Size = new System.Drawing.Size(866, 394);
        dgvProducts.TabIndex = 0;
        dgvProducts.CellDoubleClick += dgvProducts_CellDoubleClick;
        dgvProducts.CellMouseUp += dgvProducts_CellMouseUp;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        label2.ForeColor = System.Drawing.Color.Blue;
        label2.Location = new System.Drawing.Point(12, 16);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(138, 28);
        label2.TabIndex = 2;
        label2.Text = "ข้อมูลพนักงาน";
        // 
        // txtSearch
        // 
        txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        txtSearch.Location = new System.Drawing.Point(366, 13);
        txtSearch.Name = "txtSearch";
        txtSearch.Size = new System.Drawing.Size(316, 27);
        txtSearch.TabIndex = 3;
        txtSearch.TextChanged += txtSearch_TextChanged;
        // 
        // label3
        // 
        label3.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        label3.AutoSize = true;
        label3.Location = new System.Drawing.Point(267, 16);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(93, 20);
        label3.TabIndex = 4;
        label3.Text = "ค้นหาพนักงาน";
        // 
        // btnAdd
        // 
        btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnAdd.Location = new System.Drawing.Point(711, 12);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new System.Drawing.Size(56, 29);
        btnAdd.TabIndex = 5;
        btnAdd.Text = "เพิ่ม";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // btnDel
        // 
        btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnDel.Location = new System.Drawing.Point(804, 12);
        btnDel.Name = "btnDel";
        btnDel.Size = new System.Drawing.Size(56, 29);
        btnDel.TabIndex = 5;
        btnDel.Text = "ลบ";
        btnDel.UseVisualStyleBackColor = true;
        btnDel.Click += btnDel_Click;
        // 
        // Employee
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)255)), ((int)((byte)192)));
        ClientSize = new System.Drawing.Size(899, 468);
        Controls.Add(btnDel);
        Controls.Add(btnAdd);
        Controls.Add(label3);
        Controls.Add(txtSearch);
        Controls.Add(label2);
        Controls.Add(dgvProducts);
        Text = "จัดการข้อมูลพนักงาน";
        Load += Employee_Load;
        ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

        #endregion

        private DataGridView dgvProducts;
        private System.Windows.Forms.Label label2;
        private TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private Button btnAdd;
        private Button btnDel;
}
