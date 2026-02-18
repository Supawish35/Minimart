using System.ComponentModel;

namespace Minimart;

partial class Products {
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
            dgvProducts = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtSearch = new TextBox();
            label3 = new Label();
            btnAdd = new Button();
            btnDel = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(12, 62);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(866, 394);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellDoubleClick += dgvProducts_CellDoubleClick;
            dgvProducts.CellMouseUp += dgvProducts_CellMouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(636, 390);
            label1.Name = "label1";
            label1.Size = new Size(123, 28);
            label1.TabIndex = 1;
            label1.Text = "dgvProducts";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(12, 16);
            label2.Name = "label2";
            label2.Size = new Size(113, 28);
            label2.TabIndex = 2;
            label2.Text = "ข้อมูลสินค้า";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Location = new Point(366, 13);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(316, 27);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(284, 16);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 4;
            label3.Text = "ค้นหาสินค้า";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Location = new Point(711, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(56, 29);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "เพิ่ม";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDel
            // 
            btnDel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDel.Location = new Point(804, 12);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(56, 29);
            btnDel.TabIndex = 5;
            btnDel.Text = "ลบ";
            btnDel.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(701, 44);
            label4.Name = "label4";
            label4.Size = new Size(79, 28);
            label4.TabIndex = 6;
            label4.Text = "btnAdd";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(786, 44);
            label5.Name = "label5";
            label5.Size = new Size(71, 28);
            label5.TabIndex = 7;
            label5.Text = "btnDel";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(577, 43);
            label6.Name = "label6";
            label6.Size = new Size(93, 28);
            label6.TabIndex = 8;
            label6.Text = "txtSearch";
            label6.Visible = false;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(899, 468);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnDel);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(txtSearch);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvProducts);
            Name = "frmProducts";
            Text = "จัดการข้อมูลสินค้า";
            Load += frmProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private DataGridView dgvProducts;
        private Label label1;
        private Label label2;
        private TextBox txtSearch;
        private Label label3;
        private Button btnAdd;
        private Button btnDel;
        private Label label4;
        private Label label5;
        private Label label6;
    
}