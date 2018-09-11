using System;
using Atlassian.Jira;
using RestSharp;

namespace JiraConnecter
{
    class Program
    {
        static void Main(string[] args)
        {
          
        }

        public IRestResponse JiraConenctor()
        {
            var client = new RestClient("https://responsivestudio.atlassian.net/rest/api/2/issue/createmeta");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Basic cnVhbkByZXNwb25zaXZlLmNvLnphOlJ1YW5hdGxLcnVnZXI0NDI2Nio=");
            request.AddHeader("Content-Type", "application/json");
            IRestResponse response = client.Execute(request);
            return response;
        }



        /*

        get current/List tickets
        update ticket -- Post
        create ticket -- Post
        filter ticket -- Get list and filter according to parameters

        */
    }
}
