using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTypeApp.Client.RestTypes.ServiceTypes.SubTypes;
using Color = TestTypeApp.Client.RestTypes.ServiceTypes.SubTypes.Color;

namespace TestTypeApp.Client.RestTypes
{
    public class Socks : object, System.ComponentModel.INotifyPropertyChanged
    {
        private int idfield;
        private string namefield;
        private ServiceTypes.SubTypes.Color colorfield;
        private double sizefield;
        private TypeRef.type typefield;
        private ManufactureRef.manufacture manufacturefield;

        public int id
        {
            get
            {
                return this.idfield;
            }
            set
            {
                this.idfield = value;
                this.RaisePropertyChanged("id");
            }
        }
        public string name
        {
            get
            {
                return this.namefield;
            }
            set
            {
                this.namefield = value;
                this.RaisePropertyChanged("name");
            }
        }
        public Color color
        {
            get
            {
                return this.colorfield;
            }
            set
            {
                this.colorfield = value;
                this.RaisePropertyChanged("color");
            }
        }
        public double size
        {
            get
            {
                return this.sizefield;
            }
            set
            {
                this.sizefield = value;
                this.RaisePropertyChanged("size");
            }
        }
        public TypeRef.type type
        {
            get
            {
                return this.typefield;
            }
            set
            {
                this.typefield = value;
                this.RaisePropertyChanged("type");
            }
        }
        public ManufactureRef.manufacture manufacture
        {
            get
            {
                return this.manufacturefield;
            }
            set
            {
                this.manufacturefield = value;
                this.RaisePropertyChanged("manufacture");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string propertyName)
        {
                System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
                if ((propertyChanged != null))
                {
                    propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
                }

        }
    }
}
