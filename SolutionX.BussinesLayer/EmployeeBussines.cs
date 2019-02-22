using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolutionX.DataAccess;
using SolutionX.DomainEntities;

namespace SolutionX.BussinesLayer
{
    class EmployeeBussines
    {

        EmployeeDataAccess employeeData = new EmployeeDataAccess();
        public string VerifyUser(Employee employee)
        {
          return employeeData.VerifyUser(employee);

        }

        public void AssignRole(Role role, Employee employee)
        {
            employeeData.AssignRole(role,employee);

        }

    }
        
}
