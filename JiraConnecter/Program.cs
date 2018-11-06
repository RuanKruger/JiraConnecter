using System;
using Atlassian.Jira;
using JiraConnecter.Factories;
using JiraConnecter.Factories.Interfaces;
using JiraConnecter.Programmability;
using Newtonsoft.Json;
using RestSharp;

namespace JiraConnecter
{
    partial class Program
    {
        static void Main(string[] args)
        {
            IConnectorFactory factory = new BoardConnector();

            var board = factory.Create("Jira");

            var listOfTickets = board.FilteredList<string>("https://responsivestudio.atlassian.net/rest/api/2/issue/createmeta");

            Console.WriteLine(listOfTickets);

            Console.ReadLine();
        }
    }
}
