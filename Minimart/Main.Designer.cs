using System.ComponentModel;

namespace Minimart;

partial class Main {
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
        menuStrip1 = new System.Windows.Forms.MenuStrip();
        mnuCRUD = new System.Windows.Forms.ToolStripMenuItem();
        mnuProduct = new System.Windows.Forms.ToolStripMenuItem();
        mnuEmployee = new System.Windows.Forms.ToolStripMenuItem();
        mnuCategory = new System.Windows.Forms.ToolStripMenuItem();
        mnuReport = new System.Windows.Forms.ToolStripMenuItem();
        mnuProductByCategory = new System.Windows.Forms.ToolStripMenuItem();
        mnuEmployeeSale = new System.Windows.Forms.ToolStripMenuItem();
        mnuPos = new System.Windows.Forms.ToolStripMenuItem();
        mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        mnuLogin = new System.Windows.Forms.ToolStripMenuItem();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
        menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuCRUD, mnuReport, mnuPos, mnuLogout, toolStripMenuItem1 });
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new System.Drawing.Size(1007, 28);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // mnuCRUD
        // 
        mnuCRUD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuProduct, mnuEmployee, mnuCategory });
        mnuCRUD.Name = "mnuCRUD";
        mnuCRUD.Size = new System.Drawing.Size(95, 24);
        mnuCRUD.Text = "จัดการข้อมูล";
        // 
        // mnuProduct
        // 
        mnuProduct.Name = "mnuProduct";
        mnuProduct.Size = new System.Drawing.Size(239, 26);
        mnuProduct.Text = "จัดการข้อมูลสินค้า";
        mnuProduct.Click += mnuProduct_Click;
        // 
        // mnuEmployee
        // 
        mnuEmployee.Name = "mnuEmployee";
        mnuEmployee.Size = new System.Drawing.Size(239, 26);
        mnuEmployee.Text = "จัดการข้อมูลพนักงาน";
        mnuEmployee.Click += mnuEmployee_Click;
        // 
        // mnuCategory
        // 
        mnuCategory.Name = "mnuCategory";
        mnuCategory.Size = new System.Drawing.Size(239, 26);
        mnuCategory.Text = "จัดการข้อมูลประเภทสินค้า";
        mnuCategory.Click += mnuCategory_Click;
        // 
        // mnuReport
        // 
        mnuReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuProductByCategory, mnuEmployeeSale });
        mnuReport.Name = "mnuReport";
        mnuReport.Size = new System.Drawing.Size(86, 24);
        mnuReport.Text = "แสดงข้อมูล";
        // 
        // mnuProductByCategory
        // 
        mnuProductByCategory.Name = "mnuProductByCategory";
        mnuProductByCategory.Size = new System.Drawing.Size(229, 26);
        mnuProductByCategory.Text = "แสดงข้อมูลตามประเภท";
        mnuProductByCategory.Click += mnuProductByCategory_Click;
        // 
        // mnuEmployeeSale
        // 
        mnuEmployeeSale.Name = "mnuEmployeeSale";
        mnuEmployeeSale.Size = new System.Drawing.Size(229, 26);
        mnuEmployeeSale.Text = "แสดงข้อมูลตามพนักงาน";
        mnuEmployeeSale.Click += mnuEmployeeSale_Click;
        // 
        // mnuPos
        // 
        mnuPos.Name = "mnuPos";
        mnuPos.Size = new System.Drawing.Size(104, 24);
        mnuPos.Text = "จำหน่ายสินค้า";
        mnuPos.Click += mnuPos_Click;
        // 
        // mnuLogout
        // 
        mnuLogout.Name = "mnuLogout";
        mnuLogout.Size = new System.Drawing.Size(101, 24);
        mnuLogout.Text = "ออกจากระบบ";
        mnuLogout.Click += mnuLogout_Click;
        // 
        // toolStripMenuItem1
        // 
        toolStripMenuItem1.Name = "toolStripMenuItem1";
        toolStripMenuItem1.Size = new System.Drawing.Size(14, 24);
        // 
        // mnuLogin
        // 
        mnuLogin.Name = "mnuLogin";
        mnuLogin.Size = new System.Drawing.Size(80, 24);
        mnuLogin.Text = "เข้าสู่ระบบ";
        mnuLogin.Click += mnuLogin_Click;
        // 
        // Main
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1007, 577);
        Controls.Add(menuStrip1);
        IsMdiContainer = true;
        MainMenuStrip = menuStrip1;
        Text = "ระบบร้านสะดวกซื้อขนาดเล็ก";
        Load += Main_Load;
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

    private System.Windows.Forms.ToolStripMenuItem mnuLogout;
    private System.Windows.Forms.ToolStripMenuItem mnuLogin;

    private System.Windows.Forms.ToolStripMenuItem mnuProductByCategory;
    private System.Windows.Forms.ToolStripMenuItem mnuEmployeeSale;

    private System.Windows.Forms.ToolStripMenuItem mnuProduct;
    private System.Windows.Forms.ToolStripMenuItem mnuEmployee;
    private System.Windows.Forms.ToolStripMenuItem mnuCategory;

    private System.Windows.Forms.ToolStripMenuItem mnuPos;

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem mnuCRUD;
    private System.Windows.Forms.ToolStripMenuItem mnuReport;

    #endregion
}