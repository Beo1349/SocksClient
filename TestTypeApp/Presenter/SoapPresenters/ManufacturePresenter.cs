using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTypeApp.Client;
using TestTypeApp.View;

namespace TestTypeApp.Presenter
{
    class ManufacturePresenter : IPresenter
    {
        IBaseModel<CManufacture> model;
        IItemView<CManufacture> view;
        CManufacture current;

        public ManufacturePresenter(IBaseModel<CManufacture> model, IItemView<CManufacture> view)
        {
            this.model = model;
            this.view = view;
            model.Reload();
            view.ItemList = model.ItemList;
            view.Refresh += view_Refresh;
            view.Save += view_Save;
            view.Delete += view_Delete;
            view.Add += view_Add;
        }

        private void view_Add(object sender, EventArgs e)
        {

            model.Add();
            view.CurrentItem = model.ItemList.First(n => n == model.ItemList.LastOrDefault());
            current = view.CurrentItem;
        }

        void view_Delete(object sender, EventArgs e)
        {
            model.Delete(view.CurrentItem);
            model.ItemList.Remove(view.CurrentItem);
            //model.Reload();
            if (view.CurrentItem != null)
            {
                if (model.ItemList.First() != view.CurrentItem)
                    view.CurrentItem = model.ItemList.First(n => n.Id == model.ItemList.FirstOrDefault().Id);
                else view.CurrentItem = model.ItemList[0];
                current = view.CurrentItem;

            }
        }

        void view_Save(object sender, EventArgs e)
        {
            model.Save();
        }

        void view_Refresh(object sender, EventArgs e)
        {
            if (view.CurrentItem != null)
                current = view.CurrentItem;
            model.Reload();
            if (model.ItemList.Select(n => n.Id).Contains(current.Id))
                view.CurrentItem = model.ItemList.First(n => n.Id == current.Id);
            else
                view.CurrentItem = model.ItemList.First(n => n.Id == model.ItemList.Last().Id);
        }
    }
}

