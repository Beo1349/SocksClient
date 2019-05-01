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
    public partial class ComboMaterialsSetup : UserControl,IItemView<CMaterial>
    {
        public ComboMaterialsSetup()
        {
            InitializeComponent();
        }

        public event EventHandler<EventArgs> Refresh;
        public event EventHandler<EventArgs> Save;
        public event EventHandler<EventArgs> Delete;
        public event EventHandler<EventArgs> Add;
        public event EventHandler<EventArgs> getCurrentItem;
        CMaterial currentItem;

        public IList<CMaterial> ItemList
        {
           set
            {
                comboBox1.DataSource = value;
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Id";

            }
            get
            {
                return (IList <CMaterial>)comboBox1.Items;
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

        private void typesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //typeControl1.DataSource = (CMaterial)typesListBox.SelectedItem;
        }

        public CMaterial CurrentItem
        {
            get { return (CMaterial)comboBox1.SelectedItem; }
            set { comboBox1.SelectedItem = value; }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Delete(this, e);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Add(this, e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentItem = (CMaterial)comboBox1.SelectedItem;
            getCurrentItem(this, e);
        }
    }
}
