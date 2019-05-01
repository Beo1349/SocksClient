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
    public class StorageRestClient
    {
        RestClient client;
        public StorageRestClient()
        {
            client = new RestClient("http://localhost:8080/socks-web/rest");
        }

        public List<CStorage> readAll()
        {
            var request = new RestRequest("storage/get", Method.GET);
            var response = client.Execute<List<CStorage>>(request);

            return response.Data;
        }
        public void save(List<CStorage> toSave)
        {
            JsonSerializer se = new JsonSerializer();
            var request = new RestRequest("storage/add", Method.PUT);
            request.AddParameter("storage", se.Serialize(toSave));
            client.Execute<List<CStorage>>(request);
        }
        public void delete(List<int> toDelete)
        {
            JsonSerializer se = new JsonSerializer();
            var request = new RestRequest("storage/delete", Method.DELETE);
            request.AddParameter("storageDel", se.Serialize(toDelete));
            client.Execute<List<int>>(request);
        }
    }
}
