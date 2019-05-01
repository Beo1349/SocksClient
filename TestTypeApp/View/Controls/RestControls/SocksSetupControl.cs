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
    public partial class SocksSetupControl : UserControl,IItemView<CSocks>
    {
        public SocksSetupControl()
        {
            InitializeComponent();

        }

        public event EventHandler<EventArgs> Refresh;
        public event EventHandler<EventArgs> Save;
        public event EventHandler<EventArgs> Delete;
        public event EventHandler<EventArgs> Add;
        public event EventHandler<EventArgs> getCurrentItem;
        public event EventHandler<EventArgs> saveHandler;
        public event EventHandler<EventArgs> refreshHandler;

        CSocks currentItem;

        public IList<CSocks> ItemList
        {
            set
            {
                typesListBox.DataSource = value;
                typesListBox.DisplayMember = "name";
                typesListBox.ValueMember = "id";
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Save(this, e);
            saveHandler(sender, e);
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Refresh(this, e);
            typesListBox_SelectedIndexChanged(sender, e);
            refreshHandler(this, e);
        }

        private void typesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                socksControl1.DataSource = (CSocks)typesListBox.SelectedItem;
                currentItem = (CSocks)typesListBox.SelectedItem;
                getCurrentItem(sender, e);
        }

        public CSocks CurrentItem
        {
              get { return (CSocks)typesListBox.SelectedItem; }
              set { typesListBox.SelectedItem = value;  }
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
