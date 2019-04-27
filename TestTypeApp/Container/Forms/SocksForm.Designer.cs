namespace TestTypeApp
{
    partial class SocksForm
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
            this.recentlyUsedItemsComboBox1 = new DevExpress.XtraReports.UserDesigner.RecentlyUsedItemsComboBox();
            this.designRepositoryItemComboBox1 = new DevExpress.XtraReports.UserDesigner.DesignRepositoryItemComboBox();
            this.socksSetupControl1 = new SocksSetupControl(); //sock
            ((System.ComponentModel.ISupportInitialize)(this.recentlyUsedItemsComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.designRepositoryItemComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // recentlyUsedItemsComboBox1
            // 
            this.recentlyUsedItemsComboBox1.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.recentlyUsedItemsComboBox1.AppearanceDropDown.Options.UseFont = true;
            this.recentlyUsedItemsComboBox1.AutoHeight = false;
            this.recentlyUsedItemsComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.recentlyUsedItemsComboBox1.DropDownRows = 12;
            this.recentlyUsedItemsComboBox1.Name = "recentlyUsedItemsComboBox1";
            // 
            // designRepositoryItemComboBox1
            // 
            this.designRepositoryItemComboBox1.AutoHeight = false;
            this.designRepositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.designRepositoryItemComboBox1.Name = "designRepositoryItemComboBox1";
            // socksSetupControl1
            //
            this.socksSetupControl1.AccessibleName = "";
            this.socksSetupControl1.CurrentItem = null;
            this.socksSetupControl1.Location = new System.Drawing.Point(12, 8);
            this.socksSetupControl1.Name = "socksSetupControl1";
            this.socksSetupControl1.Size = new System.Drawing.Size(667, 196);
            this.socksSetupControl1.TabIndex = 1;
            // 
            // SocksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 195);
            this.Controls.Add(this.socksSetupControl1);
            this.Name = "SocksForm";
            this.Text = "SocksForm";
            ((System.ComponentModel.ISupportInitialize)(this.recentlyUsedItemsComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.designRepositoryItemComboBox1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private SocksSetupControl socksSetupControl1;
        private DevExpress.XtraReports.UserDesigner.RecentlyUsedItemsComboBox recentlyUsedItemsComboBox1;
        private DevExpress.XtraReports.UserDesigner.DesignRepositoryItemComboBox designRepositoryItemComboBox1;

    }
}

