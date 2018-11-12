using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using RestSharp;

namespace JiraConnecter.Infrustructure
{
    class ApiConnector
    {
        internal List<string> GetTicketList(string v)
        {
            var client = new RestClient(v);
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Basic cnVhbkByZXNwb25zaXZlLmNvLnphOlJ1YW5hdGxLcnVnZXI0NDI2Nio=");
            request.AddHeader("Content-Type", "application/json");
            IRestResponse response = client.Execute(request);
            var listOfJiraTickets = JsonDeserializer(response);
            return listOfJiraTickets;
        }

        private List<string> JsonDeserializer(IRestResponse response)
        {
            var tickets = response.Content;

            var projects = JsonConvert.DeserializeObject(tickets);

            var test = projects.;

            Console.WriteLine("BLAHBLAH");
            return null;
        }
    }
}
