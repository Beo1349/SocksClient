namespace TestTypeApp.Container.Forms
{
    partial class StorageForm
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
            this.storageSetupControl1 = new TestTypeApp.StorageSetupControl();
            this.SuspendLayout();
            // 
            // storageSetupControl1
            // 
            this.storageSetupControl1.AccessibleName = "";
            this.storageSetupControl1.CurrentItem = null;
            this.storageSetupControl1.Location = new System.Drawing.Point(12, 12);
            this.storageSetupControl1.Name = "storageSetupControl1";
            this.storageSetupControl1.Size = new System.Drawing.Size(652, 274);
            this.storageSetupControl1.TabIndex = 0;
            // 
            // StorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 330);
            this.Controls.Add(this.storageSetupControl1);
            this.Name = "StorageForm";
            this.Text = "StorageForm";
            this.ResumeLayout(false);

        }

        #endregion

        private StorageSetupControl storageSetupControl1;
    }
}