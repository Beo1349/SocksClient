using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTypeApp.Client;
using TestTypeApp.Client.RestTypes;

namespace TestTypeApp.View
{
    public partial class StorageControl : UserControl
    {
        public StorageControl()
        {
            InitializeComponent();
        }

        CStorage type;
        public CStorage DataSource
        {
            set 
            {
                if (value != null && type != value)
                {
                    if (type!=null) type.PropertyChanged -= type_PropertyChanged;
                    type = value;
                    typeNameEdit.Text = type.usage.ToString();
                    try
                    {
                        dateTimePicker1.Value = DateTime.Parse(type?.added);
                        dateTimePicker2.Value = DateTime.Parse(type?.retired);
                    }
                    catch {
                        dateTimePicker1.Value = DateTime.Now;
                        dateTimePicker2.Value = DateTime.Now;
                    }
                    type.PropertyChanged += type_PropertyChanged;
                }
            }
            get { return type; }
        }

        private void type_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "socks")
            {
                typeNameEdit.Text = type.usage.ToString();
                dateTimePicker1.Value = DateTime.Parse(type?.added);
                dateTimePicker2.Value = DateTime.Parse(type?.retired);
            }
            else if (e.PropertyName == "added")
            {
                dateTimePicker1.Value = DateTime.Parse(type?.added);
            }
            else if(e.PropertyName == "retired")
            {
                dateTimePicker2.Value = DateTime.Parse(type?.retired);
            }
            else if(e.PropertyName == "usage")
            {
                typeNameEdit.Text = type.usage.ToString();
            }
            else
            {
                throw new NotImplementedException("Unsupported property: " + e.PropertyName);
            }
            
        }

        private void typeNameEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                type.usage = Int32.Parse(typeNameEdit.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
             
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            type.added = dateTimePicker1?.Value.ToShortDateString();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            type.retired = dateTimePicker2?.Value.ToShortDateString();
        }
    }
}
