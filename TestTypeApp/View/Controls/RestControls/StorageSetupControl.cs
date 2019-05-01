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
using TestTypeApp.Client.RestTypes;

namespace TestTypeApp
{
    public partial class StorageSetupControl : UserControl,IItemView<CStorage>
    {
        public StorageSetupControl()
        {
            InitializeComponent();
        }

        public event EventHandler<EventArgs> Refresh;
        public event EventHandler<EventArgs> Save;
        public event EventHandler<EventArgs> Delete;
        public event EventHandler<EventArgs> Add;
        public event EventHandler<EventArgs> getCurrentItem;

        CStorage currentItem;

        public IList<CStorage> ItemList
        {
           set
            {
                    typesListBox.DataSource = value;
                    typesListBox.DisplayMember = "socksName";
                    typesListBox.ValueMember = "id";
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Save(this, e);
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Refresh(this, e);
            typesListBox_SelectedIndexChanged(sender, e);
        }

        private void typesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            typeControl1.DataSource = (CStorage)typesListBox.SelectedItem;
        }

        public CStorage CurrentItem
        {
            get { return (CStorage)typesListBox.SelectedItem; }
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
