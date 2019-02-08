using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SolutionX.DomainEntities
{
    public class Ticket
    {
        public string idCode { get; set; } = null; 
        public string description { get; set; } = null;
        public string priority { get; set; } = null;
        public string stateTicket { get; set; } = null;
        public DateTime dateCreate { get; set; }
        public string idCategory { get; set; } = null;
        public int idCostumer { get; set; } = 0;
        public string idCoordinator { get; set; } = null;
        public string idEmployee { get; set; } = null;

    }
}