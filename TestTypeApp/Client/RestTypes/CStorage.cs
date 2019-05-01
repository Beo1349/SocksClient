using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTypeApp.Client.RestTypes.ServiceTypes;

namespace TestTypeApp.Client.RestTypes
{
    public class CStorage : Transportable<Storage>, INotifyPropertyChanged
    {
        public CStorage() : base(new Storage())
        { PropertyChanged += CStorage_PropertyChanged; }

        private void CStorage_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            dto.id = this.id;
            dto.socks = this.socks;
            dto.added = this.added;
            dto.retired = this.retired;
            dto.usage = this.usage;
        }

        public CStorage(Storage Storage) : base(Storage)
        { }

        public int id
        {
            get { return dto.id; }
            set { dto.id = value; } //???
        }
        public CSocks socks
        {
            get { return dto.socks; }
            set { dto.socks = value; PropertyChanged(this, new PropertyChangedEventArgs("socks")); }
        }
        public string added
        {
            get { return dto.added; }
            set { dto.added = value; PropertyChanged(this, new PropertyChangedEventArgs("added")); }
        }
        public string retired
        {
            get { return dto.retired; }
            set { dto.retired = value; PropertyChanged(this, new PropertyChangedEventArgs("retired")); }
        }
        public int usage
        {
            get { return dto.usage; }
            set { dto.usage = value; PropertyChanged(this, new PropertyChangedEventArgs("usage")); }
        }
        public string socksName
        {
            get { return dto.socks.name; }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
