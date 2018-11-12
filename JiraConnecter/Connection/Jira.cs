using System;
using System.Collections.Generic;
using System.Text;
using JiraConnecter.Connection.Interfaces;
using Newtonsoft.Json;
using RestSharp;

namespace JiraConnecter.Connection
{
    internal class Jira : IConnect
    {
        /// <summary>
        /// Get List of Jira tickets and return in raw format
        /// </summary>
        /// <returns></returns>

        public object Tickets()
        {
            var client = new RestClient("https://responsivestudio.atlassian.net/rest/agile/1.0/board/363/issue");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Basic cnVhbkByZXNwb25zaXZlLmNvLnphOlJ1YW5hdGxLcnVnZXI0NDI2Nio=");
            request.AddHeader("Content-Type", "application/json");
            IRestResponse response = client.Execute(request);
            var listOfJiraTickets = JsonConvert.DeserializeObject(response.Content);
            return listOfJiraTickets;
        }
    }
}
