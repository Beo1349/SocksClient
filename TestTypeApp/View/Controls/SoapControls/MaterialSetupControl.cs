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
    public partial class MaterialSetupControl : UserControl,IItemView<CMaterial>
    {
        public MaterialSetupControl()
        {
            InitializeComponent();
        }

        public event EventHandler<EventArgs> Refresh;
        public event EventHandler<EventArgs> Save;
        public event EventHandler<EventArgs> Delete;
        public event EventHandler<EventArgs> Add;
        CMaterial currentItem;

        public IList<CMaterial> ItemList
        {
           set
            {
                    typesListBox.DataSource = value;
                    typesListBox.DisplayMember = "Name";
                    typesListBox.ValueMember = "Id";
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
            materialControl1.DataSource = (CMaterial)typesListBox.SelectedItem;
        }

        public CMaterial CurrentItem
        {
            get { return (CMaterial)typesListBox.SelectedItem; }
            set { typesListBox.SelectedItem = value; }
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
