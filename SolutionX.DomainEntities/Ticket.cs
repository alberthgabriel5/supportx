using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SolutionX.DomainEntities
{
    public class Ticket
    {
        public int idCode { get; set; } = 0; 
        public string description { get; set; } = "";
        public int priority { get; set; } = 0;
        public DateTime dateCreate { get; set; } = DateTime.Now;
        public int idCategory { get; set; } = 0;
        public int idCustomer { get; set; } = 0;
        public int idCoordinator { get; set; } = 0;
        public int idEmployee { get; set; } = 0;

    }
}