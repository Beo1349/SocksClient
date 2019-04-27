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
    public partial class MaterialForm : Form
    {
        public MaterialForm()
        {
            InitializeComponent();
            MaterialRef.MaterialServiceClient service = new MaterialRef.MaterialServiceClient();
            ModelMaterial model = new ModelMaterial(service);
            MaterialPresenter presenter = new MaterialPresenter(model, materialSetupControl1);            
        }
    }
}
