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
        productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        pOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
        menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { productToolStripMenuItem, categoryToolStripMenuItem, employeeToolStripMenuItem, pOSToolStripMenuItem });
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new System.Drawing.Size(1007, 28);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // productToolStripMenuItem
        // 
        productToolStripMenuItem.Name = "productToolStripMenuItem";
        productToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
        productToolStripMenuItem.Text = "Product";
        productToolStripMenuItem.Click += productToolStripMenuItem_Click;
        // 
        // categoryToolStripMenuItem
        // 
        categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
        categoryToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
        categoryToolStripMenuItem.Text = "Category";
        categoryToolStripMenuItem.Click += categoryToolStripMenuItem_Click;
        // 
        // employeeToolStripMenuItem
        // 
        employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
        employeeToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
        employeeToolStripMenuItem.Text = "Employee";
        employeeToolStripMenuItem.Click += employeeToolStripMenuItem_Click;
        // 
        // pOSToolStripMenuItem
        // 
        pOSToolStripMenuItem.Name = "pOSToolStripMenuItem";
        pOSToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
        pOSToolStripMenuItem.Text = "POS";
        pOSToolStripMenuItem.Click += pOSToolStripMenuItem_Click;
        // 
        // Main
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1007, 577);
        Controls.Add(menuStrip1);
        IsMdiContainer = true;
        MainMenuStrip = menuStrip1;
        Text = "Main";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ToolStripMenuItem pOSToolStripMenuItem;

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;

    #endregion
}