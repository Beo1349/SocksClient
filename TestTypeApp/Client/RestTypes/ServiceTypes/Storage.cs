using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTypeApp.Client.RestTypes.ServiceTypes
{
    public class Storage : object, System.ComponentModel.INotifyPropertyChanged
    {
        private int idfield;
        private CSocks socksfield;
        private string addedfield;
        private string retiredfield;
        private int usagefield;

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
        public string added
        {
            get
            {
                return this.addedfield;
            }
            set
            {
                this.addedfield = value;
                this.RaisePropertyChanged("added");
            }
        }
        public string retired
        {
            get
            {
                return this.retiredfield;
            }
            set
            {
                this.retiredfield = value;
                this.RaisePropertyChanged("retired");
            }
        }
        public int usage
        {
            get
            {
                return this.usagefield;
            }
            set
            {
                this.usagefield = value;
                this.RaisePropertyChanged("usage");
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
