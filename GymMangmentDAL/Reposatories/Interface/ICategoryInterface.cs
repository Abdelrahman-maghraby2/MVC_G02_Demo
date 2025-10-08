using GymMangmentDAL.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMangmentDAL.Reposatories.Interface
{
    internal interface ICategoryInterface
    {
        
        IEnumerable<Category> GetAll();
        Category? GetById(int id);
        int Add(Category category);
        int Update(Category category);
        int Delete(Category category);
    }
}
