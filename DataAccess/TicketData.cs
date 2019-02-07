using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DataAccess
{
    public class TicketData
    {
        public void CreateTicket(Object ticket) {

            SqlConnection connectionSupportX = DataAccess.GetSqlConnectionSupportX();
            connectionSupportX.Open();
            //procedimiento almacenado de crear ticket

            connectionSupportX.Close();
        }
    }
}