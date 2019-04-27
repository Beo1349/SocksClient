using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTypeApp.Client.RestTypes;
using TestTypeApp.Client.RestTypes.ServiceTypes.SubTypes;
using Color = TestTypeApp.Client.RestTypes.ServiceTypes.SubTypes.Color;

namespace TestTypeApp.Client
{
    public class CSocks : Transportable<Socks>, INotifyPropertyChanged
    {
        public CSocks() : base(new Socks())
        { PropertyChanged += CSocks_PropertyChanged; }

        private void CSocks_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            dto.name = this.name;
            dto.size = this.size;
        }

        public CSocks(Socks socks) : base(socks)
        { }

        public int id
        {
            get { return dto.id; }
            set { dto.id = value; } //???
        }
        public string name
        {
            get { return dto.name; }
            set { dto.name = value; PropertyChanged(this, new PropertyChangedEventArgs("name")); }
        }
        public double size
        {
            get { return dto.size; }
            set { dto.size = value; PropertyChanged(this, new PropertyChangedEventArgs("size")); }
        }
        public Color color
        {
            get { return dto.color; }
            set { dto.color = value; PropertyChanged(this, new PropertyChangedEventArgs("color")); }
        }
        public TypeRef.type type
        {
            get { return dto.type; }
            set { dto.type = value; PropertyChanged(this, new PropertyChangedEventArgs("type")); }
        }
        public ManufactureRef.manufacture manufacture
        {
            get { return dto.manufacture; }
            set { dto.manufacture = value; PropertyChanged(this, new PropertyChangedEventArgs("manufacture")); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
