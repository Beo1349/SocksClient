using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTypeApp.Client;
using TestTypeApp.Client.RestTypes;


namespace TestTypeApp.REST
{
    public class SocksRestClient
    {
        RestClient client;
        public SocksRestClient()
        {
            client = new RestClient("http://localhost:8080/socks-web/rest");
        }

        public List<CSocks> readAll()
        {
            var request = new RestRequest("socks/get", Method.GET);

            var response = client.Execute<List<CSocks>>(request);

            return response.Data;
        }
        public void save(List<CSocks> toSave)
        {
            JsonSerializer se = new JsonSerializer();
            var request = new RestRequest("socks/add", Method.PUT);
            request.AddParameter("socks", se.Serialize(toSave));
            client.Execute<List<CSocks>>(request);
        }
        public void delete(List<int> toDelete)
        {
            JsonSerializer se = new JsonSerializer();
            var request = new RestRequest("socks/delete", Method.DELETE);
            request.AddParameter("socksDel", se.Serialize(toDelete));
            client.Execute<List<int>>(request);
        }
    }
}
