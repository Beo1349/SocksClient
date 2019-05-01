using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTypeApp.Client;
using TestTypeApp.Client.RestTypes;
using TestTypeApp.Model.RestModels;
using TestTypeApp.Presenter;
using TestTypeApp.Presenter.RestPresenters;
using TestTypeApp.REST;

namespace TestTypeApp
{
    public partial class SocksForm : Form
    {
        List<CComposition> compositions;
        TestTypeApp.Client.Converter<TypeRef.type, CType> converterType = new Client.Converter<TypeRef.type, CType>();
        TestTypeApp.Client.Converter<ManufactureRef.manufacture, CManufacture> converterManufacture = new Client.Converter<ManufactureRef.manufacture, CManufacture>();
        TestTypeApp.Client.Converter<MaterialRef.material, CMaterial> converterMaterial = new Client.Converter<MaterialRef.material, CMaterial>();
        public SocksForm()
        {
            InitializeComponent();

            SocksRestClient service = new SocksRestClient();
            TypeRef.TypeServiceClient typeServiceClient = new TypeRef.TypeServiceClient();
            ManufactureRef.ManufactureServiceClient manufactureServiceClient = new ManufactureRef.ManufactureServiceClient();
            CompositionRestClient compositionRestClient = new CompositionRestClient();
            MaterialRef.MaterialServiceClient materialServiceClient = new MaterialRef.MaterialServiceClient();

            ModelSocks model = new ModelSocks(service);
            ModelType modeltype = new ModelType(typeServiceClient);
            ModelManufacture modelManufacture = new ModelManufacture(manufactureServiceClient);
            CompositionModel compositionModel = new CompositionModel(compositionRestClient);
            ModelMaterial modelMaterial = new ModelMaterial(materialServiceClient);

            MaterialPresenter materialPresenter = new MaterialPresenter(modelMaterial, comboMaterialsSetup1);
            CompositionPresenter compositionPresenter = new CompositionPresenter(compositionModel, compositionSetupControl1);
            SocksPresenter presenter = new SocksPresenter(model, socksSetupControl1);
            TypePresenter typePresenter = new TypePresenter(modeltype, comboTypeSetup1);
            ManufacturePresenter manufacturePresenter = new ManufacturePresenter(modelManufacture, comboManufactureSetup1);

        }

        private void comboTypeSetup1_getCurrentItem(object sender, EventArgs e)
        {
            if(comboTypeSetup1.CurrentItem != null)
            {
                List<CType> t = new List<CType>();
                t.Add(comboTypeSetup1.CurrentItem);
                socksSetupControl1.CurrentItem.type = converterType.toDto(t).FirstOrDefault();
            }
        }

        private void comboManufactureSetup1_getCurrentItem(object sender, EventArgs e)
        {
            List<CManufacture> t = new List<CManufacture>();
            t.Add(comboManufactureSetup1.CurrentItem);
            socksSetupControl1.CurrentItem.manufacture = converterManufacture.toDto(t).FirstOrDefault();
        }

        private void socksSetupControl1_getCurrentItem(object sender, EventArgs e)
        {
            if(compositionSetupControl1.ItemList != null && socksSetupControl1.CurrentItem != null)
            {
                compositions = compositionSetupControl1.ItemList.ToList();
                compositions = compositions.Where(n => n.socks.id == socksSetupControl1.CurrentItem.id).ToList();
                compositionSetupControl1.datacomposition = compositions;
            }
        }

        private void comboMaterialsSetup1_getCurrentItem(object sender, EventArgs e)
        {

        }

        private void socksSetupControl1_saveHandler(object sender, EventArgs e)
        {
            compositionSetupControl1.Save_Click(sender, e);
        }

        private void socksSetupControl1_refreshHandler(object sender, EventArgs e)
        {
            compositionSetupControl1.RefreshButton_Click(sender, e);
            socksSetupControl1_getCurrentItem(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (compositionSetupControl1.ItemList != null && socksSetupControl1.CurrentItem != null)
            {
                List<MaterialRef.material> materials = compositionSetupControl1.datacomposition.Select(n => n.material).ToList();
                List<CMaterial> t = new List<CMaterial>();
                t.Add(comboMaterialsSetup1.CurrentItem);
                if (materials.Where(n => n.id == converterMaterial.toDto(t).FirstOrDefault().id).ToList().Count == 0)
                {
                    CComposition c = new CComposition { material = converterMaterial.toDto(t).FirstOrDefault(), percentage = 0, socks = socksSetupControl1.CurrentItem };
                    compositionSetupControl1.ItemList.Add(c);
                    compositions = compositionSetupControl1.ItemList.ToList();
                    compositions = compositions.Where(n => n.socks.id == socksSetupControl1.CurrentItem.id).ToList();
                    compositionSetupControl1.datacomposition = compositions;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (compositionSetupControl1.ItemList != null && socksSetupControl1.CurrentItem != null)
            {
                List<MaterialRef.material> materials = compositionSetupControl1.datacomposition.Select(n => n.material).ToList();
                List<CMaterial> t = new List<CMaterial>();
                t.Add(comboMaterialsSetup1.CurrentItem);
                if (materials.Where(n => n.id == converterMaterial.toDto(t).FirstOrDefault().id).ToList().Count == 0)
                {
                    compositions = compositionSetupControl1.ItemList.ToList();
                    compositions = compositions.Where(n => n.socks.id == socksSetupControl1.CurrentItem.id).ToList();
                    List<CMaterial> c = new List<CMaterial>();
                    c.Add(comboMaterialsSetup1.CurrentItem);
                    compositions.Where(n => n.material.id == compositionSetupControl1.CurrentItem.material.id).FirstOrDefault().material = converterMaterial.toDto(t).FirstOrDefault();
                    compositionSetupControl1.datacomposition = compositions;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (compositionSetupControl1.ItemList != null && socksSetupControl1.CurrentItem != null)
            {
                compositionSetupControl1.ItemList.Remove(compositionSetupControl1.CurrentItem);
                compositions = compositionSetupControl1.ItemList.ToList();
                compositions = compositions.Where(n => n.socks.id == socksSetupControl1.CurrentItem.id).ToList();
                compositionSetupControl1.datacomposition = compositions;

            }
        }
    }
}
