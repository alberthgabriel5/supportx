using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SolutionX.DomainEntities
{
    public class Employee
    {
        public int id { get; set; } = 0;
        public string name { get; set; } = null;
        public string lastName { get; set; } = null;
        public string nickName { get; set; } = null;
        public string pass { get; set; } = null;
        public Role Role { get => role; set => role = value; } 

        public Employee()
        {
            Role role = new Role();
            
        }

        private Role role;

    }
}