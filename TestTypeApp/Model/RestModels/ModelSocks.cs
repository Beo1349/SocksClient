using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTypeApp.Client;
using TestTypeApp.Client.RestTypes;
using TestTypeApp.REST;
using Color = TestTypeApp.Client.RestTypes.ServiceTypes.SubTypes.Color;

namespace TestTypeApp
{
    public class ModelSocks : IBaseModel<CSocks>
    {
        SocksRestClient client;
        BindingList<CSocks> socks;
        List<CSocks> toSave;
        List<int> toDelete;

        public ModelSocks(SocksRestClient client)
        {
            this.client = client;
            socks = new BindingList<CSocks>();
            toSave = new List<CSocks>();
            toDelete = new List<int>();
            socks.ListChanged += socks_ListChanged;
        }

        private void socks_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemChanged ||
                e.ListChangedType == ListChangedType.ItemAdded)
            {
                if (e.OldIndex != -1)
                {
                    toSave.Add(socks[e.OldIndex]);
                    toSave = toSave.Distinct().ToList();
                }

            }

        }

        public void Reload()
        {
            try
            {
                socks.ListChanged -= socks_ListChanged;

                toDelete.Clear();
                toSave.Clear();
                socks.Clear();
               this.client.readAll().ForEach(n => socks.Add(n));
                socks.ListChanged += socks_ListChanged;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void Save()
        {
            try
            {
                client.save(toSave);

                client.delete(toDelete);
                Reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Delete(CSocks c)
        {
            try
            {
                toDelete.Add(c.id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Add()
        {
            try
            {
                CSocks t = new CSocks();
                t.name = "some socks";
                t.color = new Color() { falpha = -16777216, value = 0 };
                t.size = 15;
                socks.Add(t);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Add(CSocks c)
        {
            throw new NotImplementedException();
        }

        public BindingList<CSocks> ItemList
        {
            get
            {
                return socks;
            }
            set
            {
                socks = value;
            }
        }
    }
}
