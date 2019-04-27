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

namespace TestTypeApp.View
{
    public partial class SocksControl : UserControl
    {
        public SocksControl()
        {
            InitializeComponent();
            TypeRef.TypeServiceClient serviceType = new TypeRef.TypeServiceClient();
            ComboBox1.DataSource = serviceType.readAll().ToList();
            ComboBox1.DisplayMember = "name";
            ComboBox1.ValueMember = "id";
            ManufactureRef.ManufactureServiceClient serviceManufacture = new ManufactureRef.ManufactureServiceClient();
            ComboBox2.DataSource = serviceManufacture.readAll().ToList();
            ComboBox2.DisplayMember = "name";
            ComboBox2.ValueMember = "id";
        }

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
                    socksTypeEdit.Text = type.type.name;
                    socksManufactureEdit.Text = type.manufacture.name;
                    socksColourvalueEdit.Text = type.color.value.ToString();
                    socksColourfalphaEdit.Text = type.color.falpha.ToString();
                    socksSizeEdit.Text = type.size.ToString();
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
                socksTypeEdit.Text = type.name;
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
            TypeRef.type t = new TypeRef.type();
            t.id = type.type.id;
            t.name = socksTypeEdit.Text;
            type.type = t;
        }
        private void socksManufactureEdit_EditValueChanged(object sender, EventArgs e)
        {
            ManufactureRef.manufacture t = new ManufactureRef.manufacture();
            t.id = type.manufacture.id;
            t.name = socksManufactureEdit.Text;
            type.manufacture = t;
        }
        private void socksColourvalueEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Color t = new Color();
                t.falpha = type.color.falpha;
                t.value = Int32.Parse(socksColourvalueEdit.Text);
                type.color = t;
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
                Color t = new Color();
                t.value = type.color.value;
                t.falpha = Double.Parse(socksColourfalphaEdit.Text);
                type.color = t;
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
                type.size = Double.Parse(socksSizeEdit.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypeRef.type fromcombo = (TypeRef.type)ComboBox1.SelectedItem;
            TypeRef.type t = new TypeRef.type();
            t.id = fromcombo.id;
            t.name = fromcombo.name;
            type.type = t;
            socksTypeEdit.Text = fromcombo.name;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManufactureRef.manufacture fromcombo = (ManufactureRef.manufacture)ComboBox2.SelectedItem;
            ManufactureRef.manufacture t = new ManufactureRef.manufacture();
            t.id = fromcombo.id;
            t.name = fromcombo.name;
            type.manufacture = t;
            socksManufactureEdit.Text = fromcombo.name;
        }
    }
}
