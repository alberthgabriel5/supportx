using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SolutionX.DomainEntities
{
    public class Customer
    {
        public int id { get; set; } = 0;
        public string name { get; set; }=null;
        public string lastName { get; set; } = null;
        public string nickName { get; set; } = null;
        public string pass { get; set; } = null;


    }
}