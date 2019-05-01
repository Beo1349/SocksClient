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

namespace TestTypeApp.Container.Forms
{
    public partial class StorageForm : Form
    {
        public StorageForm()
        {
            InitializeComponent();
            StorageRestClient service = new StorageRestClient();
            StorageModel model = new StorageModel(service);
            StoragePresenter presenter = new StoragePresenter(model, storageSetupControl1);
        }
    }
}
