using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTypeApp.Client.RestTypes;
using TestTypeApp.Client.RestTypes.ServiceTypes.SubTypes;
using TestTypeApp.REST;

namespace TestTypeApp.Model.RestModels
{
    public class CompositionModel : IBaseModel<CComposition>
    {
        CompositionRestClient client;
        BindingList<CComposition> compositions;
        List<CComposition> compositionsCopy = new List<CComposition>();
        List<CComposition> toSave;
        List<int> toDelete;

        public CompositionModel(CompositionRestClient client)
        {
            this.client = client;
            compositionsCopy = client.readAll();
            compositions = new BindingList<CComposition>();
            toSave = new List<CComposition>();
            toDelete = new List<int>();
            compositions.ListChanged += compositions_ListChanged;
        }

        private void compositions_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemChanged ||
                e.ListChangedType == ListChangedType.ItemAdded)
            {
                if (e.OldIndex != -1)
                {
                    toSave.Add(compositions[e.OldIndex]);
                    toSave = toSave.Distinct().ToList();
                }

            }
            if (e.ListChangedType == ListChangedType.ItemDeleted)
            {
                    toDelete.Add(compositionsCopy[e.NewIndex].id);
                    toDelete = toDelete.Distinct().ToList();            
            }

        }

        public void Reload()
        {
            try
            {
                compositions.ListChanged -= compositions_ListChanged;

                toDelete.Clear();
                toSave.Clear();
                compositions.Clear();
                this.client.readAll().ForEach(n => compositions.Add(n));
                compositions.ListChanged += compositions_ListChanged;


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
                compositionsCopy = client.readAll();
                Reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Delete(CComposition c)
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
                CComposition t = new CComposition();
                compositions.Add(t);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Add(CComposition composition)
        {
            try
            {
                 CComposition t = new CComposition() { materialName = "some text"};
                composition.id = 0;
                composition.percentage = 0;
                compositions.Add(t);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public BindingList<CComposition> ItemList
        {
            get
            {
                return compositions;
            }
            set
            {
                compositions = value;
            }
        }
    }
}
