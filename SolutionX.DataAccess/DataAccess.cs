using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SolutionX.DataAccess
{
    public class DataAccess
    {
        public static SqlConnection GetSqlConnectionCustomer()
        {
            SqlConnection connectionCustomer= new SqlConnection();
            connectionCustomer.ConnectionString = "Data Source=25.66.120.65;Initial Catalog=EmpresaX_ClientDB;Persist Security Info=True;User ID=sa;Password=DBA-12;";
            
            return connectionCustomer;
        }

        public static SqlConnection GetSqlConnectionEmployee()
        {
            SqlConnection connectionEmployee = new SqlConnection();
            connectionEmployee.ConnectionString = "Data Source=DBServer-Mirror;Initial Catalog=EmpresaX_HumanResources;Persist Security Info=True;User ID=sa;Password=DBA-12;";

            return connectionEmployee;
        }
        public static SqlConnection GetSqlConnectionSupportX()
        {
            SqlConnection connectionSupportX = new SqlConnection();
            connectionSupportX.ConnectionString = "Data Source=25.66.120.65;Initial Catalog=SupportX_PrimaryDatabase;Persist Security Info=True;User ID=sa;Password=DBA-12;";
            
            return connectionSupportX;
        }
    }
}