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
        BindingList<CSocks> types;
        List<CSocks> toSave;
        List<int> toDelete;
       // TestTypeApp.Client.Converter<CSocks, CSocks> converter;

        public ModelSocks(SocksRestClient client)
        {
            this.client = client;

            types = new BindingList<CSocks>();
            toSave = new List<CSocks>();
            toDelete = new List<int>();
         //   converter = new TestTypeApp.Client.Converter<CSocks, CSocks>();
            types.ListChanged += types_ListChanged;
        }

        private void types_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemChanged ||
                e.ListChangedType == ListChangedType.ItemAdded)
            {
                //toSave.Clear();
                if (e.OldIndex != -1)
                {
                    //types[e.OldIndex].Manufacture.id = 1;
                 //   types[e.OldIndex].Name = "fwefw";
                    //types[e.OldIndex].Size = 14;
                    //types[e.OldIndex].Type.id = 177;
                    //types[e.OldIndex].Type.name = "fref";
                    //types[e.OldIndex].Manufacture.name = "dewf";
                    toSave.Add(types[e.OldIndex]);
                    toSave = toSave.Distinct().ToList();
                    //  toDelete.Add(types[e.OldIndex].Id);
                }
                //  toSave.Add(types[e.NewIndex]);
                //    
                //  MessageBox.Show(types.Count.ToString());

            }
            //if (e.ListChangedType == ListChangedType.ItemDeleted)
            //{

            //}

        }

        public void Reload()
        {
            try
            {
                types.ListChanged -= types_ListChanged;

                toDelete.Clear();
                toSave.Clear();
                types.Clear();
               // converter.toClientType(this.client.DbTest())
               //   .ForEach(n => types.Add(n));
               this.client.readAll().ForEach(n => types.Add(n));
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
                // client.delete(toDelete.FirstOrDefault());
                // Reload();
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
                t.name = "some text";
                ManufactureRef.manufacture m = new ManufactureRef.manufacture();
                m.name = "some text";
                TypeRef.type ct = new TypeRef.type();
                ct.name = "some text";
                Color c = new Color();
                c.falpha = 0;
                c.value = 0;

                t.color = c;
                t.manufacture = m;
                t.type = ct;
                // t.Id = 100;

                //MessageBox.Show(t.Name);
                //toSave.Add(t);
                //toSave = toSave.Distinct().ToList();
                types.Add(t);
                //Reload();
                // MessageBox.Show("Ok!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public BindingList<CSocks> ItemList
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

        public List<CSocks> SaveList
        {
            get
            {
                return toSave;
            }
            set
            {
                toSave = value;
            }
        }

        public List<int> DeleteList
        {
            get
            {
                return toDelete;
            }
            set
            {
                toDelete = value;
            }
        }

    }
}
