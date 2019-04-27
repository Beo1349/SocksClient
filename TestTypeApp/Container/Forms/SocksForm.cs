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
    public partial class SocksForm : Form
    {
        public SocksForm()
        {
            InitializeComponent();
            SocksRestClient service = new SocksRestClient();
            ModelSocks model = new ModelSocks(service);
            SocksPresenter presenter = new SocksPresenter(model, socksSetupControl1);            
        }
    }
}
