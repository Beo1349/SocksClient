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
        CSocks currentItem;

        public IList<CSocks> ItemList
        {
            set
            {
                //TreeNode node = new TreeNode(Name = "Socks");
                //typesListBox.Nodes.Add(node);
                //value.ToList().ForEach(n => typesListBox.Nodes[0].Nodes.Add(new TreeNode(Name = n.name)));
                //for (int i = 0; i < typesListBox.Nodes[0].Nodes.Count; i++)
                //{
                //    typesListBox.Nodes[0].Nodes[i].Nodes.Add(new TreeNode(Name = "test"));
                //}

                typesListBox.DataSource = value;
                typesListBox.DisplayMember = "Name";
                typesListBox.ValueMember = "Id";

                //typesListBox.Columns[0].Visible = false;
                //DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn() { DataSource = value };
                //typesListBox.Columns.Add(column);

                //  typesListBox.Columns[3].ValueType = typeof(String);
                //    typesListBox.DisplayMember += "Name";
                //    typesListBox.DisplayMember += "size";
                //   typesListBox.ValueMember = "Id";
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
            socksControl1.DataSource = (CSocks)typesListBox.SelectedItem;
            //socksControl2.DataSource = (CSocks)typesListBox.SelectedItem;
        }

        public CSocks CurrentItem
        {
              get { return (CSocks)typesListBox.SelectedItem; }
              set { typesListBox.SelectedItem = value; }
           //   get { return new CSocks(); }
          //    set {  }
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
