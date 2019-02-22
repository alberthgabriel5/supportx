using SolutionX.DomainEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionX.DataAccess
{
    class CategoryDataAccess
    {
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



        }
    }
}
