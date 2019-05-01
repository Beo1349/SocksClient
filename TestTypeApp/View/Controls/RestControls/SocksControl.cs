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
using Color = TestTypeApp.Client.RestTypes.ServiceTypes.SubTypes.Color;
using TestTypeApp.REST;

namespace TestTypeApp.View
{
    public partial class SocksControl : UserControl
    {
        List<CComposition> compositions;
        public SocksControl()
        {
            InitializeComponent();
        }
        public 

        CSocks type;
        public CSocks DataSource
        {
            set 
            {
                if (value != null && type != value)
                {
                    if (type!=null) type.PropertyChanged -= type_PropertyChanged;
                    type = value;

                    socksNameEdit.Text = type.name;
                    socksTypeEdit.Text = type.type?.name;
                    socksManufactureEdit.Text = type.manufacture?.name;
                    socksColourvalueEdit.Text = type.color?.value.ToString();
                    socksColourfalphaEdit.Text = type.color?.falpha.ToString();
                    socksSizeEdit.Text = type?.size.ToString();

                    type.PropertyChanged += type_PropertyChanged;

                }
            }
            get { return type; }
        }

        private void type_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "name")
            {
                socksNameEdit.Text = type.name;                
            }
            else if(e.PropertyName == "type")
            {
                //ComboBox1.SelectedText = type.type.name;
                socksTypeEdit.Text = type.type.name;
            }
            else if(e.PropertyName == "manufacture")
            {
                socksManufactureEdit.Text = type.manufacture.name;
            }
            else if(e.PropertyName == "color")
            {
                socksColourvalueEdit.Text = type.color.value.ToString();
                socksColourfalphaEdit.Text = type.color.falpha.ToString();
            }
            else if(e.PropertyName == "size")
            {
                socksSizeEdit.Text = type.size.ToString();
            }
            else
            {
                throw new NotImplementedException("Unsupported property: " + e.PropertyName);
            }
            
        }

        private void socksNameEdit_EditValueChanged(object sender, EventArgs e)
        {
             type.name = socksNameEdit.Text;
        }
        private void socksTypeEdit_EditValueChanged(object sender, EventArgs e)
        {
            if(type.id != 0)
            {
                TypeRef.type t = new TypeRef.type();
                t.id = type.type.id;
                t.name = socksTypeEdit?.Text;
                type.type = t;
            }


        }
        private void socksManufactureEdit_EditValueChanged(object sender, EventArgs e)
        {
            if(type.id != 0)
            {
                ManufactureRef.manufacture t = new ManufactureRef.manufacture();
                t.id = type.manufacture.id;
                t.name = socksManufactureEdit?.Text;
                type.manufacture = t;
            }
        }
        private void socksColourvalueEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if(type.id != 0)
                {
                    Color t = new Color();
                    t.falpha = type.color.falpha;
                    t.value = Int32.Parse(socksColourvalueEdit.Text);
                    type.color = t;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void socksColourfalphaEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if(type.id != 0)
                {
                    Color t = new Color();
                    t.value = type.color.value;
                    t.falpha = Double.Parse(socksColourfalphaEdit.Text);
                    type.color = t;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void socksSizeEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if(type.id != 0)
                type.size = Double.Parse(socksSizeEdit?.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
