using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SolutionX.DataAccess
{
    public class DataAccess
    {
        public static SqlConnection GetSqlConnectionCostumer()
        {
            SqlConnection connectionCostumer= new SqlConnection();
            connectionCostumer.ConnectionString =
            "Data Source=163.178.173.148;" +
            "Initial Catalog=ProyectoAnalsis;" +
            "User id=estudiantesrp;" +
            "Password=estudiantesrp;";
            return connectionCostumer;
        }

        public static SqlConnection GetSqlConnectionEmployee()
        {
            SqlConnection connectionEmployee = new SqlConnection();
            connectionEmployee.ConnectionString =
            "Data Source=163.178.173.148;" +
            "Initial Catalog=ProyectoAnalsis;" +
            "User id=estudiantesrp;" +
            "Password=estudiantesrp;";
            return connectionEmployee;
        }
        public static SqlConnection GetSqlConnectionSupportX()
        {
            SqlConnection connectionSupportX = new SqlConnection();
            connectionSupportX.ConnectionString = "Data Source=25.76.236.122;Initial Catalog=SupportX_PrimaryDatabase;Persist Security Info=True;User ID=sa;Password=DBA-12;";
            //          "Server=25.76.236.122;" +
            //"Database=DBServer-Mirror;" +
            //"User id=sa;" +
            //"Password=DBA-12;";
            return connectionSupportX;
        }
    }
}