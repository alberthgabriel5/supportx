using SolutionX.DomainEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionX.DataAccess
{
    public class EmployeeDataAccess
    {
        public string VerifyUser(Employee employee)
        {

            SqlConnection connectionEmployee = DataAccess.GetSqlConnectionEmployee();
            SqlDataReader reader;
            using (SqlCommand cmd = new SqlCommand("sp_user_exists", connectionEmployee))
            {
                
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            
                cmd.Parameters.AddWithValue("@user", employee.nickName);
                cmd.Parameters.AddWithValue("@pass", employee.pass);
                
                connectionEmployee.Open();
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    employee.id = Convert.ToInt32(reader["idEmployee"].ToString());
                }
                    if (employee.id != -5)
                    {
                        SqlConnection connectionSupportX = DataAccess.GetSqlConnectionSupportX();
                        SqlDataReader readerSupportX;
                        using (SqlCommand cmdSupportX = new SqlCommand("sp_select_employee_id", connectionSupportX))
                        {

                            cmdSupportX.CommandType = System.Data.CommandType.StoredProcedure;

                            cmdSupportX.Parameters.AddWithValue("@id", employee.id);

                            connectionSupportX.Open();
                            cmdSupportX.ExecuteNonQuery();
                            readerSupportX = cmdSupportX.ExecuteReader();
                    while (readerSupportX.Read())
                    {

                        employee.id = Convert.ToInt32(readerSupportX["idEmployee"].ToString());
                        employee.name = readerSupportX["nameEmployee"].ToString();
                        employee.lastName = readerSupportX["lastName"].ToString();
                        employee.Role.idRole = Convert.ToInt32(readerSupportX["idRole"].ToString());
                        employee.Role.roleName = readerSupportX["roleName"].ToString();

                    }
                                string roleEmployee = employee.Role.roleName;
                                Console.WriteLine("ROL DE EMPLEADO " + roleEmployee);
                                switch (roleEmployee)
                                {
                                    case "Super Admin":
                                        return "Super Admin";
                                        break;
                                    case "Admin":
                                        return "Admin";
                                        break;
                                    case "Manager Desktop":
                                        return "Manager Desktop";
                                        break;
                                    case "Manager":
                                        return "Manager";
                                        break;
                                    case "Funtionary":
                                        return "Funtionary";
                                        break;

                                    default:
                                        return "Does not exists this role";
                                }
                                connectionSupportX.Close();
                            }
                        }
                    }
                Console.WriteLine("Resultado de vaaaaaaalorrrrrrrr: " + employee.id);

                    connectionEmployee.Close();

                return "DOES NOT EXISTS THIS USER";
                       
        }

        public void AssignRole(Role role, Employee employee)
        {
            SqlConnection connectionSupportX = DataAccess.GetSqlConnectionSupportX();
            using (SqlCommand cmd = new SqlCommand("sp_funtionary_asigned_roll", connectionSupportX))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                
                cmd.Parameters.AddWithValue("@idRole", role.idRole);
                cmd.Parameters.AddWithValue("@idFuntionary", employee.id);
                connectionSupportX.Open();
                cmd.ExecuteNonQuery();
                connectionSupportX.Close();
            }
        }

        
    }
        

}
