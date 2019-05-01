namespace TestTypeApp
{
    partial class MainForm
    {
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.socksDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manufactureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.socksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.socksDBToolStripMenuItem,
            this.restServicesToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // socksDBToolStripMenuItem
            // 
            this.socksDBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typesToolStripMenuItem,
            this.manufactureToolStripMenuItem,
            this.materialToolStripMenuItem});
            this.socksDBToolStripMenuItem.Name = "socksDBToolStripMenuItem";
            this.socksDBToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.socksDBToolStripMenuItem.Text = "SoapServices";
            // 
            // typesToolStripMenuItem
            // 
            this.typesToolStripMenuItem.Name = "typesToolStripMenuItem";
            this.typesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.typesToolStripMenuItem.Text = "Types";
            this.typesToolStripMenuItem.Click += new System.EventHandler(this.typesToolStripMenuItem_Click);
            // 
            // manufactureToolStripMenuItem
            // 
            this.manufactureToolStripMenuItem.Name = "manufactureToolStripMenuItem";
            this.manufactureToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.manufactureToolStripMenuItem.Text = "Manufacture";
            this.manufactureToolStripMenuItem.Click += new System.EventHandler(this.manufactureToolStripMenuItem_Click);
            // 
            // materialToolStripMenuItem
            // 
            this.materialToolStripMenuItem.Name = "materialToolStripMenuItem";
            this.materialToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.materialToolStripMenuItem.Text = "Material";
            this.materialToolStripMenuItem.Click += new System.EventHandler(this.materialToolStripMenuItem_Click);
            // 
            // restServicesToolStripMenuItem
            // 
            this.restServicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.socksToolStripMenuItem,
            this.storageToolStripMenuItem});
            this.restServicesToolStripMenuItem.Name = "restServicesToolStripMenuItem";
            this.restServicesToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.restServicesToolStripMenuItem.Text = "RestServices";
            // 
            // socksToolStripMenuItem
            // 
            this.socksToolStripMenuItem.Name = "socksToolStripMenuItem";
            this.socksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.socksToolStripMenuItem.Text = "Socks";
            this.socksToolStripMenuItem.Click += new System.EventHandler(this.socksToolStripMenuItem_Click);
            // 
            // storageToolStripMenuItem
            // 
            this.storageToolStripMenuItem.Name = "storageToolStripMenuItem";
            this.storageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.storageToolStripMenuItem.Text = "Storage";
            this.storageToolStripMenuItem.Click += new System.EventHandler(this.storageToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem socksDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manufactureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem socksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
    }
}