using System.Collections.Generic;
using JiraConnecter.Infrustructure;
using JiraConnecter.Programmability.Interfaces;

namespace JiraConnecter.Programmability
{
    class JiraBoard : IFunctionType
    {
        public bool Create()
        {
            //Create Ticket
            return false;
        }

        public List<T> FilteredList<T>(string v)
        {
            var api = new ApiConnector();
            var getAllTickets = api.GetTicketList(v);

            //Do filtering with Cards and return those

            return null;
        }

        public bool Update()
        {
            //Get parameters
            //Do post with parameters to update board
            return false;
        } 
    }
}
