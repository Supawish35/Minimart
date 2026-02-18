using System.ComponentModel;

namespace Minimart;

partial class Catagory {
    /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            dgvCategory = new DataGridView();
            label1 = new Label();
            txtSearch = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnInsert = new Button();
            btnDelete = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            SuspendLayout();
            // 
            // dgvCategory
            // 
            dgvCategory.AllowUserToAddRows = false;
            dgvCategory.AllowUserToDeleteRows = false;
            dgvCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Location = new Point(31, 130);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.ReadOnly = true;
            dgvCategory.RowHeadersWidth = 51;
            dgvCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategory.Size = new Size(796, 407);
            dgvCategory.TabIndex = 0;
            dgvCategory.CellDoubleClick += dgvCategory_CellDoubleClick;
            dgvCategory.CellMouseUp += dgvCategory_CellMouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 70);
            label1.Name = "label1";
            label1.Size = new Size(124, 28);
            label1.TabIndex = 1;
            label1.Text = "ค้นหาหมวดหมู่";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(203, 67);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(319, 34);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(410, 70);
            label2.Name = "label2";
            label2.Size = new Size(112, 32);
            label2.TabIndex = 3;
            label2.Text = "txtSearch";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 14F);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(660, 472);
            label3.Name = "label3";
            label3.Size = new Size(150, 32);
            label3.TabIndex = 3;
            label3.Text = "dgvCategory";
            label3.Visible = false;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(559, 62);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(117, 36);
            btnInsert.TabIndex = 4;
            btnInsert.Text = "เพิ่ม";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(720, 63);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(85, 36);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "ลบ";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 14F);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(567, 101);
            label4.Name = "label4";
            label4.Size = new Size(109, 32);
            label4.TabIndex = 3;
            label4.Text = "btnInsert";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 14F);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(702, 102);
            label5.Name = "label5";
            label5.Size = new Size(120, 32);
            label5.TabIndex = 3;
            label5.Text = "btnDelete";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 16F);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(165, 37);
            label6.TabIndex = 5;
            label6.Text = "frmCategory";
            label6.Visible = false;
            // 
            // frmCategory
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(850, 558);
            Controls.Add(label6);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(dgvCategory);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "frmCategory";
            Text = "frmCategory";
            Load += frmCategory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCategory;
        private Label label1;
        private TextBox txtSearch;
        private Label label2;
        private Label label3;
        private Button btnInsert;
        private Button btnDelete;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}