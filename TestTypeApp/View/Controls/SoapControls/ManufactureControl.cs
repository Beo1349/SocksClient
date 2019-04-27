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

namespace TestTypeApp.View
{
    public partial class ManufactureControl : UserControl
    {
        public ManufactureControl()
        {
            InitializeComponent();
        }

        CManufacture type;
        public CManufacture DataSource
        {
            set 
            {
                if (value != null && type != value)
                {
                    if (type!=null) type.PropertyChanged -= type_PropertyChanged;
                    type = value;
                    manufactureNameEdit.Text = type.Name;
                    type.PropertyChanged += type_PropertyChanged;
                }
            }
            get { return type; }
        }

        private void type_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Name")
            {
                manufactureNameEdit.Text = type.Name;
            }
            else
            {
                throw new NotImplementedException("Unsupported property: " + e.PropertyName);
            }
            
        }

        private void manufactureNameEdit_EditValueChanged(object sender, EventArgs e)
        {
             type.Name = manufactureNameEdit.Text;
        }
    }
}
