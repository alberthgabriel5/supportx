using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SolutionX.DomainEntities
{
    public class Ticket
    {
        public string idCode { get; set; }
        public string description { get; set; }
        public string stateTicket { get; set; }
        public DateTime hourCreate { get; set; }
        public Costumer costumer { get; set; }
        
    }
}