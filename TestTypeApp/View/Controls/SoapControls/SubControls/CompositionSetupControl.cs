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
    public partial class CompositionSetupControl : UserControl,IItemView<CComposition>, INotifyPropertyChanged
    {
        public CompositionSetupControl()
        {
            InitializeComponent();
            PropertyChanged += CType_PropertyChanged;
        }

        private void CType_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (currentSocks != null)
            {
                materials = compositions.Where(n => n.socks.id == currentSocks.id).Select(n => n.material).ToList();
                materialListBox.DataSource = materials;
            }
        }

        public event EventHandler<EventArgs> Refresh;
        public event EventHandler<EventArgs> Save;
        public event EventHandler<EventArgs> Delete;
        public event EventHandler<EventArgs> Add;
        public event EventHandler<EventArgs> getCurrentItem;

        CComposition currentItem;
        CSocks currentSocks;
        List<MaterialRef.material> materials;
        IList<CComposition> compositions;
        List<CComposition> currentcompositions;

        public IList<CComposition> ItemList
        {
           set
            {
                compositions = value;
            }
            get
            {
                return compositions;
            }
        }
        public CComposition currentComposition
        {
            set
            {
                currentItem = value;
            }
            get
            {
                return currentItem;
            }
        }
        public IList<CComposition> datacomposition
        {
            set
            {
                materialListBox.DataSource = value;
                materialListBox.DisplayMember = "materialName";
                materialListBox.ValueMember = "Id";
                if (materialListBox.SelectedItem != null)
                {
                    CurrentItem = (materialListBox.SelectedItem as CComposition);
                    trackBar1.Maximum = 100;
                    trackBar1.Value = (materialListBox.SelectedItem as CComposition).percentage;
                    int max = 0;
                    compositions.Where(n => n.socks.id == (materialListBox.SelectedItem as CComposition).socks.id).ToList().ForEach(s => max += s.percentage);
                    max = 100 - max + trackBar1.Value;
                    trackBar1.Maximum = max;
                    textEdit1.Text = trackBar1.Value.ToString();
                }
                else
                {
                    trackBar1.Value = 0;
                    textEdit1.Text = "0";
                }
            }
            get
            {
                return (IList<CComposition>)materialListBox.DataSource;
            }
        }

        public void Save_Click(object sender, EventArgs e)
        {
            Save(this, e);
        }
        public void RefreshButton_Click(object sender, EventArgs e)
        {
            Refresh(this, e);
        }

        private void materialListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

                if (materialListBox.SelectedItem != null)
                {
                    trackBar1.Maximum = 100;
                    trackBar1.Value = (materialListBox.SelectedItem as CComposition).percentage;
                    int max = 0;
                    compositions.Where(n => n.socks.id == (materialListBox.SelectedItem as CComposition).socks.id).ToList().ForEach(s => max += s.percentage);
                    max = 100 - max + trackBar1.Value;
                    trackBar1.Maximum = max;
                    textEdit1.Text = trackBar1.Value.ToString();
                }
                else
                {
                    trackBar1.Value = 0;
                    textEdit1.Text = "0";
                }
        }
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (materialListBox.SelectedItem != null)
            {
                trackBar1.Maximum = 100;
                (materialListBox.SelectedItem as CComposition).percentage = trackBar1.Value;
                int max = 0;
                compositions.Where(n => n.socks.id == (materialListBox.SelectedItem as CComposition).socks.id).ToList().ForEach(s => max += s.percentage);
                max = 100 - max + trackBar1.Value;
                trackBar1.Maximum = max;
                textEdit1.Text = trackBar1.Value.ToString();
            }
            else
            {
                trackBar1.Value = 0;
                textEdit1.Text = "0";
            }
        }

        public CComposition CurrentItem
        {
            get { return (CComposition)materialListBox.SelectedItem; }
            set { materialListBox.SelectedItem = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public CSocks SocksItem
        {
            get { return currentSocks; }
            set { currentSocks = value; new PropertyChangedEventArgs("SocksItem"); }
        }

        public void DeleteButton_Click(object sender, EventArgs e)
        {
            Delete(this, e);
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Add(this, e);

        }
    }
}
