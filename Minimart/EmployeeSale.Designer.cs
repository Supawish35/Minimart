using System.ComponentModel;

namespace Minimart;

partial class EmployeeSale {
    private IContainer components = null;

    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent() {
        dgvEmployee = new DataGridView();
        dgvSale = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvSale).BeginInit();
        SuspendLayout();
        // 
        // dgvEmployee
        // 
        dgvEmployee.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left)));
        dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvEmployee.Location = new Point(12, 12);
        dgvEmployee.Name = "dgvEmployee";
        dgvEmployee.RowHeadersWidth = 51;
        dgvEmployee.Size = new Size(371, 426);
        dgvEmployee.TabIndex = 0;
        dgvEmployee.CellClick += dgvEmployee_CellClick;
        // 
        // dgvSale
        // 
        dgvSale.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right)));
        dgvSale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvSale.Location = new Point(392, 12);
        dgvSale.Name = "dgvSale";
        dgvSale.RowHeadersWidth = 51;
        dgvSale.Size = new Size(486, 426);
        dgvSale.TabIndex = 1;
        // 
        // EmployeeSale
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(890, 450);
        Controls.Add(dgvSale);
        Controls.Add(dgvEmployee);
        Name = "EmployeeSale";
        Text = "Employee Sale";
        Load += EmployeeSale_Load;
        ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvSale).EndInit();
        ResumeLayout(false);
    }

    private DataGridView dgvEmployee;
    private DataGridView dgvSale;

    #endregion
}

