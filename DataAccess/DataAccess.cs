using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DataAccess
{
    public class DataAccess
    {
        public static SqlConnection GetSqlConnectionCostumer()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source=ServerName;" +
            "Initial Catalog=DataBaseName;" +
            "User id=UserName;" +
            "Password=Secret;";
            return conn;
        }

        public static SqlConnection GetSqlConnectionEmployee()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source=ServerName;" +
            "Initial Catalog=DataBaseName;" +
            "User id=UserName;" +
            "Password=Secret;";
            return conn;
        }
        public static SqlConnection GetSqlConnectionSupportX()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source=ServerName;" +
            "Initial Catalog=DataBaseName;" +
            "User id=UserName;" +
            "Password=Secret;";
            return conn;
        }
    }
}