using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolutionX.DataAccess;
using SolutionX.DomainEntities;

namespace SolutionX.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
       
        public void insertTicket()
        {

            Ticket ticket = new Ticket();
            TicketData ticketData = new TicketData();

            ticket.description = "Actualizacion";
            ticket.idCostumer = 1;

            ticketData.CreateTicket(ticket);    
        }

        [TestMethod]
        public void ViewTicket()
        {
            
            TicketData ticketData = new TicketData();

            List<Ticket> ticketsList = new List<Ticket>();
            ticketsList= ticketData.ViewTicket();
            Console.WriteLine("LA CANTIDAD DE DATOS SON: "+ticketsList.Count);
            
            for (int i = 0; i < ticketsList.Count; i++)
            {
                Console.WriteLine("LA DESCRIPCION DEL TICKET ES: " + ticketsList[i].description);
            }
        }
    }
}
