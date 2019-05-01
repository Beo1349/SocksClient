namespace TestTypeApp
{
    partial class SocksSetupControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SocksSetupControl));
            this.typesListBox = new System.Windows.Forms.ListBox();
            this.AddButton = new DevExpress.XtraEditors.SimpleButton();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.DeleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.RefreshButton = new DevExpress.XtraEditors.SimpleButton();
            this.socksControl1 = new TestTypeApp.View.SocksControl();
            this.SuspendLayout();
            // 
            // typesListBox
            // 
            this.typesListBox.FormattingEnabled = true;
            this.typesListBox.Location = new System.Drawing.Point(8, 11);
            this.typesListBox.Name = "typesListBox";
            this.typesListBox.Size = new System.Drawing.Size(308, 160);
            this.typesListBox.TabIndex = 1;
            this.typesListBox.SelectedIndexChanged += new System.EventHandler(this.typesListBox_SelectedIndexChanged);
            // 
            // AddButton
            // 
            this.AddButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.AddButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.ImageOptions.Image")));
            this.AddButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.AddButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AddButton.Location = new System.Drawing.Point(146, 177);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(63, 63);
            this.AddButton.TabIndex = 7;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.SaveButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.ImageOptions.Image")));
            this.SaveButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.SaveButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SaveButton.Location = new System.Drawing.Point(215, 177);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(63, 63);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Click += new System.EventHandler(this.Save_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.DeleteButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.ImageOptions.Image")));
            this.DeleteButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.DeleteButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DeleteButton.Location = new System.Drawing.Point(77, 177);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(63, 63);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.RefreshButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.ImageOptions.Image")));
            this.RefreshButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.RefreshButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RefreshButton.Location = new System.Drawing.Point(8, 177);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(63, 63);
            this.RefreshButton.TabIndex = 4;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // socksControl1
            // 
            this.socksControl1.DataSource = null;
            this.socksControl1.Location = new System.Drawing.Point(322, 11);
            this.socksControl1.Name = "socksControl1";
            this.socksControl1.Size = new System.Drawing.Size(234, 237);
            this.socksControl1.TabIndex = 8;
            // 
            // SocksSetupControl
            // 
            this.AccessibleName = "socksControl1";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.socksControl1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.typesListBox);
            this.Name = "SocksSetupControl";
            this.Size = new System.Drawing.Size(568, 260);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox typesListBox;
        private DevExpress.XtraEditors.SimpleButton AddButton;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private DevExpress.XtraEditors.SimpleButton DeleteButton;
        private DevExpress.XtraEditors.SimpleButton RefreshButton;
        private View.SocksControl socksControl1;
    }
}
