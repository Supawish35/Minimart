using System.ComponentModel;

namespace Minimart;

partial class ProductByCategory {
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
        dgvCategory = new System.Windows.Forms.DataGridView();
        dgvProduct = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
        SuspendLayout();
        // 
        // dgvCategory
        // 
        dgvCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left));
        dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvCategory.Location = new System.Drawing.Point(12, 12);
        dgvCategory.Name = "dgvCategory";
        dgvCategory.RowHeadersWidth = 51;
        dgvCategory.Size = new System.Drawing.Size(371, 426);
        dgvCategory.TabIndex = 0;
        dgvCategory.Text = "dataGridView1";
        dgvCategory.CellClick += dgvCategory_CellContentClick;
        // 
        // dgvProduct
        // 
        dgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvProduct.Location = new System.Drawing.Point(392, 12);
        dgvProduct.Name = "dgvProduct";
        dgvProduct.RowHeadersWidth = 51;
        dgvProduct.Size = new System.Drawing.Size(401, 426);
        dgvProduct.TabIndex = 1;
        dgvProduct.Text = "dataGridView2";
        // 
        // ProductByCategory
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(805, 450);
        Controls.Add(dgvProduct);
        Controls.Add(dgvCategory);
        Text = "Product_By_Category";
        Load += ProductByCategory_Load;
        ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridView dgvCategory;
    private System.Windows.Forms.DataGridView dgvProduct;

    #endregion
}