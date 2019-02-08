


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
        
        public void CreateTicket(Ticket ticket) {
            
            SqlConnection connectionSupportX = DataAccess.GetSqlConnectionSupportX();
           

            using (SqlCommand cmd = new SqlCommand("sp_insert_ticket", connectionSupportX))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@description",ticket.description);
                cmd.Parameters.AddWithValue("@idCostumer", ticket.costumer.id);

                connectionSupportX.Open();
                cmd.ExecuteNonQuery();
                connectionSupportX.Close();


            }
                
        }



    }
}