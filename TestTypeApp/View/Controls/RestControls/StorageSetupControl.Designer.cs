namespace TestTypeApp
{
    partial class StorageSetupControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StorageSetupControl));
            this.typesListBox = new System.Windows.Forms.ListBox();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.RefreshButton = new DevExpress.XtraEditors.SimpleButton();
            this.typeControl1 = new TestTypeApp.View.StorageControl();
            this.SuspendLayout();
            // 
            // typesListBox
            // 
            this.typesListBox.FormattingEnabled = true;
            this.typesListBox.Location = new System.Drawing.Point(8, 11);
            this.typesListBox.Name = "typesListBox";
            this.typesListBox.Size = new System.Drawing.Size(308, 238);
            this.typesListBox.TabIndex = 1;
            this.typesListBox.SelectedIndexChanged += new System.EventHandler(this.typesListBox_SelectedIndexChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.SaveButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.ImageOptions.Image")));
            this.SaveButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.SaveButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SaveButton.Location = new System.Drawing.Point(401, 188);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(63, 63);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Click += new System.EventHandler(this.Save_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.RefreshButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.ImageOptions.Image")));
            this.RefreshButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.RefreshButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RefreshButton.Location = new System.Drawing.Point(532, 186);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(63, 63);
            this.RefreshButton.TabIndex = 4;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // typeControl1
            // 
            this.typeControl1.DataSource = null;
            this.typeControl1.Location = new System.Drawing.Point(332, 8);
            this.typeControl1.Name = "typeControl1";
            this.typeControl1.Size = new System.Drawing.Size(236, 174);
            this.typeControl1.TabIndex = 2;
            // 
            // StorageSetupControl
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.typeControl1);
            this.Controls.Add(this.typesListBox);
            this.Name = "StorageSetupControl";
            this.Size = new System.Drawing.Size(667, 274);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox typesListBox;
        private View.StorageControl typeControl1;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private DevExpress.XtraEditors.SimpleButton RefreshButton;
    }
}
