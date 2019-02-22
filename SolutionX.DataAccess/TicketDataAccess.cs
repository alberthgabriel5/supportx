


using SolutionX.DomainEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SolutionX.DataAccess
{
    public class TicketDataAccess
    {
        List<Ticket> ticketsList = new List<Ticket>();

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
                    ticket.idCode = Convert.ToInt32(reader["idCode"].ToString());
                    ticket.description= reader["description"].ToString();
                    ticket.priority = Convert.ToInt32(reader["idPriority"].ToString());
                    ticket.dateCreate= Convert.ToDateTime(reader["datecreate"].ToString());
                    ticket.idCategory = Convert.ToInt32(reader["idCategory"].ToString());
                    ticket.idCostumer = Convert.ToInt32(reader["idCostumer"].ToString());
                    ticket.idCoordinator = Convert.ToInt32( reader["idCordinator"].ToString());
                    ticket.idEmployee = Convert.ToInt32(reader["idEmployee"].ToString());

                    ticketsList.Add(ticket);
                }
                connectionSupportX.Close();
               
                return ticketsList;
            }
        }
        public List<Ticket> SearchTicket(Ticket ticket)
        {
            SqlConnection connectionSupportX = DataAccess.GetSqlConnectionSupportX();

            SqlDataReader reader;
            using (SqlCommand cmd = new SqlCommand("sp_listar_ticket_id", connectionSupportX))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCode", ticket.idCode);
                connectionSupportX.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ticket.idCode = Convert.ToInt32(reader["idCode"].ToString());
                    ticket.description = reader["description"].ToString();
                    ticket.priority = Convert.ToInt32(reader["idPriority"].ToString());
                    ticket.dateCreate = Convert.ToDateTime(reader["datecreate"].ToString());
                    ticket.idCategory = Convert.ToInt32(reader["idCategory"].ToString());
                    ticket.idCostumer = Convert.ToInt32(reader["idCostumer"].ToString());
                    ticket.idCoordinator = Convert.ToInt32(reader["idCordinator"].ToString());
                    ticket.idEmployee = Convert.ToInt32(reader["idEmployee"].ToString());

                    ticketsList.Add(ticket);
                }
            }

            return ticketsList;
        }

    }
}