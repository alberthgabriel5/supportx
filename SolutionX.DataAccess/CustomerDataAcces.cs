using SolutionX.DomainEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionX.DataAccess
{
    public class CustomerDataAcces
    {
        public string VerifyUser(Customer customer)
        {
            SqlConnection connectionCustomer = DataAccess.GetSqlConnectionCustomer();
            SqlDataReader reader;
            using (SqlCommand cmd = new SqlCommand("sp_user_exists", connectionCustomer))
            {

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@user", customer.nickName);
                cmd.Parameters.AddWithValue("@pass", customer.pass);

                connectionCustomer.Open();
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    customer.id = Convert.ToInt32(reader["idEmployee"].ToString());
                }
                if (customer.id != -5)
                {
                    return "Login Successful";
                }
                else
                    return "Login Failed";

            }



        }

    }
}
