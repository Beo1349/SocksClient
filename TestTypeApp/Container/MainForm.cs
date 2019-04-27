using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTypeApp.REST;
using TestTypeApp.Test.IoC;

namespace TestTypeApp
{
    public partial class MainForm : Form
    {
        private readonly IFormOpener formOpener;
        private Form form;

        public MainForm(IFormOpener formOpener)
        {
            this.formOpener = formOpener;
            this.InitializeComponent();
        }
        private void typesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form = this.formOpener.ShowModelessForm<TypeForm>();
            form.MdiParent = this;
            form.Show();
        }

        private void manufactureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form = this.formOpener.ShowModelessForm<ManufactureForm>();
            form.MdiParent = this;
            form.Show();
        }

        private void materialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form = this.formOpener.ShowModelessForm<MaterialForm>();
            form.MdiParent = this;
            form.Show();
        }

        private void socksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form = this.formOpener.ShowModelessForm<SocksForm>();
            form.MdiParent = this;
            form.Show();
        }
    }
}
