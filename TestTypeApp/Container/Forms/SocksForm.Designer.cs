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
            this.comboMaterialsSetup1 = new TestTypeApp.ComboMaterialsSetup();
            this.compositionSetupControl1 = new TestTypeApp.CompositionSetupControl();
            this.comboTypeSetup1 = new TestTypeApp.ComboTypeSetup();
            this.comboManufactureSetup1 = new TestTypeApp.ComboManufactureSetup();
            this.socksSetupControl1 = new TestTypeApp.SocksSetupControl();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            // 
            // comboMaterialsSetup1
            // 
            this.comboMaterialsSetup1.AccessibleName = "";
            this.comboMaterialsSetup1.CurrentItem = null;
            this.comboMaterialsSetup1.Location = new System.Drawing.Point(766, 44);
            this.comboMaterialsSetup1.Name = "comboMaterialsSetup1";
            this.comboMaterialsSetup1.Size = new System.Drawing.Size(98, 28);
            this.comboMaterialsSetup1.TabIndex = 4;
            this.comboMaterialsSetup1.getCurrentItem += new System.EventHandler<System.EventArgs>(this.comboMaterialsSetup1_getCurrentItem);
            // 
            // compositionSetupControl1
            // 
            this.compositionSetupControl1.AccessibleName = "";
            this.compositionSetupControl1.currentComposition = null;
            this.compositionSetupControl1.CurrentItem = null;
            this.compositionSetupControl1.datacomposition = null;
            this.compositionSetupControl1.ItemList = null;
            this.compositionSetupControl1.Location = new System.Drawing.Point(577, 14);
            this.compositionSetupControl1.Name = "compositionSetupControl1";
            this.compositionSetupControl1.Size = new System.Drawing.Size(278, 253);
            this.compositionSetupControl1.SocksItem = null;
            this.compositionSetupControl1.TabIndex = 3;
            // 
            // comboTypeSetup1
            // 
            this.comboTypeSetup1.AccessibleName = "";
            this.comboTypeSetup1.CurrentItem = null;
            this.comboTypeSetup1.Location = new System.Drawing.Point(473, 88);
            this.comboTypeSetup1.Name = "comboTypeSetup1";
            this.comboTypeSetup1.Size = new System.Drawing.Size(98, 28);
            this.comboTypeSetup1.TabIndex = 2;
            this.comboTypeSetup1.getCurrentItem += new System.EventHandler<System.EventArgs>(this.comboTypeSetup1_getCurrentItem);
            // 
            // comboManufactureSetup1
            // 
            this.comboManufactureSetup1.AccessibleName = "";
            this.comboManufactureSetup1.CurrentItem = null;
            this.comboManufactureSetup1.Location = new System.Drawing.Point(473, 163);
            this.comboManufactureSetup1.Name = "comboManufactureSetup1";
            this.comboManufactureSetup1.Size = new System.Drawing.Size(98, 28);
            this.comboManufactureSetup1.TabIndex = 1;
            this.comboManufactureSetup1.getCurrentItem += new System.EventHandler<System.EventArgs>(this.comboManufactureSetup1_getCurrentItem);
            // 
            // socksSetupControl1
            // 
            this.socksSetupControl1.AccessibleName = "socksControl1";
            this.socksSetupControl1.AutoSize = true;
            this.socksSetupControl1.CurrentItem = null;
            this.socksSetupControl1.Location = new System.Drawing.Point(12, 14);
            this.socksSetupControl1.Name = "socksSetupControl1";
            this.socksSetupControl1.Size = new System.Drawing.Size(559, 251);
            this.socksSetupControl1.TabIndex = 5;
            this.socksSetupControl1.getCurrentItem += new System.EventHandler<System.EventArgs>(this.socksSetupControl1_getCurrentItem);
            this.socksSetupControl1.saveHandler += new System.EventHandler<System.EventArgs>(this.socksSetupControl1_saveHandler);
            this.socksSetupControl1.refreshHandler += new System.EventHandler<System.EventArgs>(this.socksSetupControl1_refreshHandler);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(780, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "AddMaterial";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(780, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Change";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(766, 180);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "DeleteMaterial";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SocksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 324);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboMaterialsSetup1);
            this.Controls.Add(this.compositionSetupControl1);
            this.Controls.Add(this.comboTypeSetup1);
            this.Controls.Add(this.comboManufactureSetup1);
            this.Controls.Add(this.socksSetupControl1);
            this.Name = "SocksForm";
            this.Text = "SocksForm";
            ((System.ComponentModel.ISupportInitialize)(this.recentlyUsedItemsComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.designRepositoryItemComboBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraReports.UserDesigner.RecentlyUsedItemsComboBox recentlyUsedItemsComboBox1;
        private DevExpress.XtraReports.UserDesigner.DesignRepositoryItemComboBox designRepositoryItemComboBox1;
        private ComboManufactureSetup comboManufactureSetup1;
        private ComboTypeSetup comboTypeSetup1;
        private CompositionSetupControl compositionSetupControl1;
        private ComboMaterialsSetup comboMaterialsSetup1;
        private SocksSetupControl socksSetupControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

