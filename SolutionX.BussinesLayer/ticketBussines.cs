using SolutionX.DomainEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolutionX.DataAccess;
using SolutionX.DomainEntities;
using System.Web;


namespace SolutionX.BussinesLayer
{
    class ticketBussines
    {
        TicketDataAccess ticketData = new TicketDataAccess();
        List<Ticket> ticketsList = new List<Ticket>();

        public void CreateTicket(Ticket ticket)
        {
            ticketData.CreateTicket(ticket);
        }
        public List<Ticket> ViewTicket()
        {
            ticketsList=ticketData.ViewTicket();
            return ticketsList;

        }
        public List<Ticket> SearchTicket(Ticket ticket)
        {
            ticketsList = ticketData.SearchTicket(ticket);
            return ticketsList;
        }
        public List<Ticket> AssignRequestToManager(Ticket ticket)
        {
            ticketsList = ticketData.AssignRequestToManager(ticket);
            return ticketsList;
        }
}