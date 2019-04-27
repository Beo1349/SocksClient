using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTypeApp.Presenter;
using TestTypeApp.REST;

namespace TestTypeApp
{
    public partial class ManufactureForm : Form
    {
        public ManufactureForm()
        {
            InitializeComponent();
            ManufactureRef.ManufactureServiceClient service = new ManufactureRef.ManufactureServiceClient();
            ModelManufacture model = new ModelManufacture(service);
            ManufacturePresenter presenter = new ManufacturePresenter(model, manufactureSetupControl1);

            //TestRestClient client = new TestRestClient();
           // MessageBox.Show(client.DbTest("some text"));
            
        }
    }
}
