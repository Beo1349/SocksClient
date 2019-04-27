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
    public partial class TypeForm : Form
    {
        public TypeForm()
        {
            InitializeComponent();
            TypeRef.TypeServiceClient service = new TypeRef.TypeServiceClient();
            ModelType model = new ModelType(service);
            TypePresenter presenter = new TypePresenter(model, typeSetupControl1);            
        }
    }
}
