


using SolutionX.DomainEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SolutionX.DataAccess
{
    public class TicketData
    {
        
        public void CreateTicket(Ticket ticket)
        {
            
            SqlConnection connectionSupportX = DataAccess.GetSqlConnectionSupportX();
           

            using (SqlCommand cmd = new SqlCommand("sp_insert_ticket", connectionSupportX))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@description",ticket.description);
                cmd.Parameters.AddWithValue("@idCostumer", ticket.idCostumer);

                connectionSupportX.Open();
                cmd.ExecuteNonQuery();
                connectionSupportX.Close();


            }
                
        }
        public List<Ticket> ViewTicket()
        {
            List<Ticket> ticketsList = new List<Ticket>();
            SqlConnection connectionSupportX = DataAccess.GetSqlConnectionSupportX();

            SqlDataReader reader;

            


            using (SqlCommand cmd = new SqlCommand("sp_listar_ticket_1", connectionSupportX))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                connectionSupportX.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Ticket ticket = new Ticket();
                    ticket.idCode = reader["idCode"].ToString();
                    ticket.description= reader["description"].ToString();
                    ticket.priority = reader["priority"].ToString();
                    ticket.stateTicket=reader["stateTicket"].ToString();
                    ticket.dateCreate= Convert.ToDateTime(reader["datecreate"].ToString());
                    ticket.idCategory = reader["idCategory"].ToString();
                    ticket.idCostumer = Convert.ToInt32(reader["idCostumer"].ToString());
                    ticket.idCoordinator = reader["idCordinator"].ToString();
                    ticket.idEmployee = reader["idEmployee"].ToString();

                    ticketsList.Add(ticket);
                }
                connectionSupportX.Close();
                Console.WriteLine(ticketsList.Count);
                for (int i = 0; i < ticketsList.Count; i++)
                {
                    Console.WriteLine("LA DESCRIPCION DEL TICKET ES: "+ticketsList[i].description);
                }
                return ticketsList;
            }
        }


    }
}