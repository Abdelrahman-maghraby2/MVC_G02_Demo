using GymMangmentDAL.Data.Contexts;
using GymMangmentDAL.Entites;
using GymMangmentDAL.Reposatories.Interface;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMangmentDAL.Reposatories.Class
{
    internal class CategoryReposatories : ICategoryInterface
    {
        private readonly GymDbcontext _dbcontext;

        public CategoryReposatories( GymDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public int Add(Category category)
        {
            _dbcontext.Add(category);
            return _dbcontext.SaveChanges();
        }

        public int Delete(Category category)
        {
            _dbcontext.Remove(category);
            return _dbcontext.SaveChanges();
        }

        public IEnumerable<Category> GetAll()=> _dbcontext.Categories.ToList();

        public Category? GetById(int id)=> _dbcontext.Categories.Find(id);

        public int Update(Category category)
        {
            _dbcontext.Categories.Update(category);
            return _dbcontext.SaveChanges();
        }
    }
}
