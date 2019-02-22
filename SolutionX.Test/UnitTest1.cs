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
            TicketDataAccess ticketData = new TicketDataAccess();

            ticket.description = "Actualizacion";
            ticket.idCostumer = 1;

            ticketData.CreateTicket(ticket);    
        }

        [TestMethod]
        public void ViewTicket()
        {
            
            TicketDataAccess ticketData = new TicketDataAccess();

            List<Ticket> ticketsList = new List<Ticket>();
            ticketsList= ticketData.ViewTicket();
            Console.WriteLine("LA CANTIDAD DE DATOS SON: "+ticketsList.Count);
            
            for (int i = 0; i < ticketsList.Count; i++)
            {
                Console.WriteLine("LA DESCRIPCION DEL TICKET ES: " + ticketsList[i].description);
            }
        }
        [TestMethod]
        public void SearchTicket()
        {
            Ticket ticket = new Ticket();
            ticket.idCode = 1;
            TicketDataAccess ticketData = new TicketDataAccess();
            List<Ticket> ticketList = new List<Ticket>();
            ticketList = ticketData.SearchTicket(ticket);

            for(int i = 0; i < ticketList.Count; i++)
            {
                Console.WriteLine("EL ID DEL TICKET ES: " + ticketList[i].idCode);
                Console.WriteLine("descripcion" + ticketList[i].description);
            }
        }
        [TestMethod]
        public void VerifyUser()
        {
            EmployeeDataAccess employee = new EmployeeDataAccess();
            Employee employee1 = new Employee();
            employee1.Role = new Role();
            
            employee1.nickName = "yyyyya";
            employee1.pass = "qaqa";

            Console.WriteLine("rol del empleado " +employee.VerifyUser(employee1));
            
            //Console.WriteLine("Hooooooooooooooooooooola");
        }

        [TestMethod]
        public void AssignRole()
        {
            EmployeeDataAccess employee = new EmployeeDataAccess();
            Employee employee1 = new Employee();
            Role role = new Role();

            role.idRole = 1;
            employee1.id = 3;
            

            employee.AssignRole(role,employee1);
            

        }
    }
}
