using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTypeApp.Client.RestTypes.ServiceTypes
{
    public class ReportStorage
    {
        private int id;
        private string socks;
        private string added;
        private string retired;
        private int usage;

        public int Id { get => id; set => id = value; }
        public string Socks { get => socks; set => socks = value; }
        public string Added { get => added; set => added = value; }
        public string Retired { get => retired; set => retired = value; }
        public int Usage { get => usage; set => usage = value; }
    }
}
