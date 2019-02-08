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
        public string priority { get; set; }
        public string stateTicket { get; set; }
        public DateTime dateCreate { get; set; }
        public string idCategory { get; set; }
        public int idCostumer { get; set; }
        public string idCoordinator { get; set; }
        public string idEmployee { get; set; } 
        
    }
}