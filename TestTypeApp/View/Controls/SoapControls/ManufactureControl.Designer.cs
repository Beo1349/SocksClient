namespace TestTypeApp.View
{
    partial class ManufactureControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.manufactureNameEdit = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.manufactureNameEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type name:";
            // 
            // manufactureNameEdit
            // 
            this.manufactureNameEdit.Location = new System.Drawing.Point(15, 26);
            this.manufactureNameEdit.Name = "manufactureNameEdit";
            this.manufactureNameEdit.Size = new System.Drawing.Size(203, 20);
            this.manufactureNameEdit.TabIndex = 1;
            this.manufactureNameEdit.EditValueChanged += new System.EventHandler(this.manufactureNameEdit_EditValueChanged);
            // 
            // TypeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.manufactureNameEdit);
            this.Controls.Add(this.label1);
            this.Name = "TypeControl";
            this.Size = new System.Drawing.Size(236, 64);
            ((System.ComponentModel.ISupportInitialize)(this.manufactureNameEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit manufactureNameEdit;
    }
}
