using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTypeApp.Client.RestTypes.ServiceTypes
{
    public class Composition : object, System.ComponentModel.INotifyPropertyChanged
    {
        private int idfield;
        private int percentagefield;
        private MaterialRef.material materialfield;
        private CSocks socksfield;

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
        public int percentage
        {
            get
            {
                return this.percentagefield;
            }
            set
            {
                this.percentagefield = value;
                this.RaisePropertyChanged("percentage");
            }
        }
        public MaterialRef.material material
        {
            get
            {
                return this.materialfield;
            }
            set
            {
                this.materialfield = value;
                this.RaisePropertyChanged("material");
            }
        }
        public CSocks socks
        {
            get
            {
                return this.socksfield;
            }
            set
            {
                this.socksfield = value;
                this.RaisePropertyChanged("socks");
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

