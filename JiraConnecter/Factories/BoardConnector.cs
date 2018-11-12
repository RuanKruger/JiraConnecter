using System;
using System.Collections.Generic;
using System.Text;
using JiraConnecter.Connection;
using JiraConnecter.Factories.Interfaces;
using JiraConnecter.Programmability;
using JiraConnecter.Programmability.Interfaces;
using Newtonsoft.Json;
using RestSharp;

namespace JiraConnecter.Factories
{
    class BoardConnector : IConnectorFactory
    {
        public IFunctionType Create(string board)
        {
            switch (board)
            {
                case "Jira":
                    return new JiraBoard();
                case "Trello":
                    return new TrelloBoard();
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}

