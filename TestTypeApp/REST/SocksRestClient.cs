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
            var request = new RestRequest("dbtest/sock", Method.GET);
            //client.UseJson();
            //request.AddParameter("connectionstring", someText);
            var response = client.Execute<List<CSocks>>(request);

            return response.Data;
        }
        public void save(List<CSocks> toSave)
        {
            JsonSerializer se = new JsonSerializer();
            var request = new RestRequest("dbtest/sock", Method.PUT);
           // Socks socks = new Socks() { Name = "faewrf" };
            request.AddParameter("socks", se.Serialize(toSave));
            //  request.AddJsonBody(toSave);
            //client.UseJson();
            //request.AddParameter("connectionstring", someText);
            // var response = 
            client.Execute<List<CSocks>>(request);

           // return response.Data;
        }
        public void delete(List<int> toDelete)
        {
            JsonSerializer se = new JsonSerializer();
            var request = new RestRequest("dbtest/sock", Method.DELETE);
            request.AddParameter("socksDel", se.Serialize(toDelete));
            client.Execute<List<int>>(request);

            // return response.Data;
        }
    }
}
