using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTypeApp.Model.RestModels;
using TestTypeApp.Presenter;
using TestTypeApp.Presenter.RestPresenters;
using TestTypeApp.REST;

namespace TestTypeApp
{
    public partial class CompositionForm : Form
    {
        public CompositionForm()
        {
            InitializeComponent();
            CompositionRestClient client = new CompositionRestClient();
            CompositionModel model = new CompositionModel(client);
            CompositionPresenter presenter = new CompositionPresenter(model, compostionSetupControl1);            
        }
    }
}
