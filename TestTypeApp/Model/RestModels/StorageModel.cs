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

namespace TestTypeApp
{
    public class StorageModel : IBaseModel<CStorage>
    {
        StorageRestClient service;
        BindingList<CStorage> types;
        List<CStorage> toSave;
        List<int> toDelete;  

        public StorageModel(StorageRestClient service)
        {
            this.service = service;

            types = new BindingList<CStorage>();
            toSave = new List<CStorage>();
            toDelete = new List<int>();
            types.ListChanged += types_ListChanged;
        }

        private void types_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemChanged || 
                e.ListChangedType == ListChangedType.ItemAdded)
            {
                if(e.OldIndex != -1)
                { 
                    toSave.Add(types[e.OldIndex]);
                    toSave = toSave.Distinct().ToList();
                }
                
            }
           
        }

        public void Reload()
        {
            try
            {
                types.ListChanged -= types_ListChanged;

                toDelete.Clear();
                toSave.Clear();
                types.Clear();
                this.service.readAll().ForEach(n => types.Add(n));
                types.ListChanged += types_ListChanged;


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
                service.save(toSave);

                service.delete(toDelete);
                Reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Delete(CStorage c)
        {
            try
            {
                toDelete.Add(c.id);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Add()
        {
            try
            {
                CStorage t = new CStorage();
                types.Add(t);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Add(CStorage c)
        {
            throw new NotImplementedException();
        }

        public BindingList<CStorage> ItemList
        {
            get
            {
                return types;
            }
            set
            {
                types = value;
            }
        }

    }
}
