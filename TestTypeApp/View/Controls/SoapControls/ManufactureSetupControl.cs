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
using TestTypeApp.View;

namespace TestTypeApp
{
    public partial class ManufactureSetupControl : UserControl,IItemView<CManufacture>
    {
        public ManufactureSetupControl()
        {
            InitializeComponent();
        }

        public event EventHandler<EventArgs> Refresh;
        public event EventHandler<EventArgs> Save;
        public event EventHandler<EventArgs> Delete;
        public event EventHandler<EventArgs> Add;
        CManufacture currentItem;

        public IList<CManufacture> ItemList
        {
           set
            {
                   manufactureListBox.DataSource = value;
                   manufactureListBox.DisplayMember = "Name";
                   manufactureListBox.ValueMember = "Id";
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Save(this, e);
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Refresh(this, e);
        }

        private void manufactureListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            manufactureControl1.DataSource = (CManufacture)manufactureListBox.SelectedItem;
        }

        public CManufacture CurrentItem
        {
            get { return (CManufacture)manufactureListBox.SelectedItem; }
            set { manufactureListBox.SelectedItem = value; }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Delete(this, e);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Add(this, e);
        }
    }
}
