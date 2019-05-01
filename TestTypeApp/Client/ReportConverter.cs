using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTypeApp.Client.RestTypes;
using TestTypeApp.Client.RestTypes.ServiceTypes;

namespace TestTypeApp.Client
{
    public class ReportConverter
    {
        public List<ReportSocks> toReportSocks(List<CSocks> cSocks)
        {
            List<ReportSocks> reportSocks = new List<ReportSocks>();
            cSocks.ForEach(n => reportSocks.Add(new ReportSocks { Id = n.id, Color = n.color.value.ToString(), Manufacture = n.manufacture.name, Name = n.name, Size = n.size, Type = n.type.name }));
            return reportSocks;
        }
        public List<ReportComposition> toReportComposition(List<CComposition> cComposition)
        {
            List<ReportComposition> reportComposition = new List<ReportComposition>();
            cComposition.ForEach(n => reportComposition.Add(new ReportComposition { Id = n.id, Material = n.material.name, Socks = n.socks.name, Percentage = n.percentage }));
            return reportComposition;
        }
        public List<ReportStorage> toReportStorage(List<CStorage> cStorage)
        {
            List<ReportStorage> reportComposition = new List<ReportStorage>();
            cStorage.ForEach(n => reportComposition.Add(new ReportStorage { Id = n.id, Socks = n.socks.name, Added = n.added, Retired = n.retired, Usage = n.usage}));
            return reportComposition;
        }
    }
}
