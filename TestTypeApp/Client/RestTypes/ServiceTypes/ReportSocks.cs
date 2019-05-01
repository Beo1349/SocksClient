using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTypeApp.Client.RestTypes.ServiceTypes
{
    public class ReportSocks
    {
        private int id;
        private string name;
        private double size;
        private string type;
        private string manufacture;
        private string color;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Size { get => size; set => size = value; }
        public string Type { get => type; set => type = value; }
        public string Manufacture { get => manufacture; set => manufacture = value; }
        public string Color { get => color; set => color = value; }
    }
}
