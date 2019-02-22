using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolutionX.DataAccess;
using SolutionX.DomainEntities;

namespace SolutionX.BussinesLayer
{
    class CategoryBussines
    {
        CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
        public void CreateCategory(Category category)
        {
            categoryDataAccess.CreateCategory(category);
        }
    }
}
