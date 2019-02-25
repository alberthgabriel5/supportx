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

            using (SqlCommand cmd = new SqlCommand("sp_select_category", connectionSupportX))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                connectionSupportX.Open();
                cmd.ExecuteNonQuery();

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    
                    Category category = new Category();
                    category.idCategory = Convert.ToInt32(reader["idCategory"].ToString());
                    category.name= reader["name"].ToString();
                    categoryList.Add(category);
                }
                return categoryList;
                connectionSupportX.Close();
            }

        }
    }
}
