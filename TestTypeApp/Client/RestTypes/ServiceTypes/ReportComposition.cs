using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTypeApp.Client.RestTypes.ServiceTypes
{
    public class ReportComposition
    {
        private int id;
        private string socks;
        private string material;
        private int percentage;

        public int Id { get => id; set => id = value; }
        public string Socks { get => socks; set => socks = value; }
        public string Material { get => material; set => material = value; }
        public int Percentage { get => percentage; set => percentage = value; }
    }
}
