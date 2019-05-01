using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTypeApp.Client.RestTypes.ServiceTypes;

namespace TestTypeApp.Client.RestTypes
{
    public class CComposition : Transportable<Composition>, INotifyPropertyChanged
    {
        public CComposition() : base(new Composition())
        { PropertyChanged += CComposition_PropertyChanged; }

        private void CComposition_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            dto.material = this.material;
        }

        public CComposition(Composition composition) : base(composition)
        { }

        public int id
        {
            get { return dto.id; }
            set { dto.id = value; } //???
        }
        public int percentage
        {
            get { return dto.percentage; }
            set { dto.percentage = value; PropertyChanged(this, new PropertyChangedEventArgs("percentage")); }
        }
        public MaterialRef.material material
        {
            get { return dto.material; }
            set { dto.material = value; PropertyChanged(this, new PropertyChangedEventArgs("material")); }
        }
        public CSocks socks
        {
            get { return dto.socks; }
            set { dto.socks = value; PropertyChanged(this, new PropertyChangedEventArgs("socks")); }
        }
        public string materialName
        {
            get { return dto.material.name.ToString(); }
            set { dto.material.name = value; PropertyChanged(this, new PropertyChangedEventArgs("materialName")); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
