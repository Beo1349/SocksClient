using Newtonsoft.Json;
using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTypeApp.Client.RestTypes;
using JsonSerializer = RestSharp.Serialization.Json.JsonSerializer;

namespace TestTypeApp.REST
{
    public class CompositionRestClient
    {
        RestClient client;
        public CompositionRestClient()
        {
            client = new RestClient("http://localhost:8080/socks-web/rest");
        }
        public List<CComposition> readAll()
        {
            var request = new RestRequest("composition/get", Method.GET);
            var response = client.Execute<List<CComposition>>(request);

            return response.Data;
        }
        public void save(List<CComposition> toSave)
        {
            JsonSerializer se = new JsonSerializer();
            var request = new RestRequest("composition/add", Method.PUT);
            request.AddParameter("compositions", se.Serialize(toSave));
            client.Execute<List<CComposition>>(request);

        }
        public void delete(List<int> toDelete)
        {
            var request = new RestRequest("composition/delete", Method.DELETE);
            var res = JsonConvert.SerializeObject(toDelete);
            request.AddParameter("compositionDel",res );
            client.Execute<List<int>>(request);
        }
    }
}
