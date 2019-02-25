using SolutionX.DataAccess;
using SolutionX.DomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionX.BussinesLayer
{
    class PriorityBussines
    {
        PriorityDataAccess priorityDataAccess = new PriorityDataAccess();
        public List<Priority> ListPriority()
        {
            return priorityDataAccess.ListPriority();
        }
    }
}
