using SolutionX.DomainEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionX.DataAccess
{
   public class CategoryDataAccess
    {

        List<Category> categoryList = new List<Category>();
        public void CreateCategory(Category category)
        {
            SqlConnection connectionSupportX = DataAccess.GetSqlConnectionSupportX();


            using (SqlCommand cmd = new SqlCommand("sp_insert_category", connectionSupportX))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nameCategory", category.name);


                connectionSupportX.Open();
                cmd.ExecuteNonQuery();
                connectionSupportX.Close();
            }
        }
        public List<Category> ListCategory()
        {

            SqlConnection connectionSupportX = DataAccess.GetSqlConnectionSupportX();
            SqlDataReader reader;

            using (SqlCommand cmd = new SqlCommand("sp_insert_category", connectionSupportX))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nameCategory", category.name);


                connectionSupportX.Open();
                cmd.ExecuteNonQuery();

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Ticket ticket = new Ticket();
                    Category category = new Category();
                    category.idCategory = Convert.ToInt32(reader["idCategory"].ToString());
                    ticket.idCode = Convert.ToInt32(reader["idCode"].ToString());
                    ticket.description = reader["description"].ToString();
                    ticket.priority = Convert.ToInt32(reader["idPriority"].ToString());
                    ticket.dateCreate = Convert.ToDateTime(reader["datecreate"].ToString());
                    ticket.idCategory = Convert.ToInt32(reader["idCategory"].ToString());
                    ticket.idCostumer = Convert.ToInt32(reader["idCostumer"].ToString());
                    ticket.idCoordinator = Convert.ToInt32(reader["idCordinator"].ToString());
                    ticket.idEmployee = Convert.ToInt32(reader["idEmployee"].ToString());


                    categoryList.Add(category);
                }

                connectionSupportX.Close();
            }

        }
    }
}
