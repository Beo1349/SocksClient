using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTypeApp.Client.RestTypes.ServiceTypes.SubTypes
{
    public class Color : object, System.ComponentModel.INotifyPropertyChanged
    {
        private int valuefield;
        private double falphafield;

        public int value
        {
            get
            {
                return this.valuefield;
            }
            set
            {
                this.valuefield = value;
                this.RaisePropertyChanged("value");
            }
        }
        public double falpha
        {
            get
            {
                return this.falphafield;
            }
            set
            {
                this.falphafield = value;
                this.RaisePropertyChanged("falpha");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
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
