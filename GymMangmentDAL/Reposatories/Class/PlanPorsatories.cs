using GymMangmentDAL.Data.Contexts;
using GymMangmentDAL.Entites;
using GymMangmentDAL.Reposatories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMangmentDAL.Reposatories.Class
{
    internal class PlanPorsatories : IPlanInterface
    {
        private readonly GymDbcontext _dbcontext;

        public PlanPorsatories(GymDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public int AddPlan(Plan plan)
        {
            _dbcontext.Add(plan);
            return _dbcontext.SaveChanges();
        }

        public int DeletePlan(Plan plan)
        {
            _dbcontext.Remove(plan);
           return _dbcontext.SaveChanges();
        }

        public IEnumerable<Plan> GetAllPlans()
        {
          return  _dbcontext.Plans.ToList();
        }

        public Plan GetPlanById(int id)
        {
          return  _dbcontext.Plans.Find(id);
        }

        public int UpdatePlan(Plan plan)
        {
            _dbcontext.Update(plan);
            return _dbcontext.SaveChanges();
        }
    }
}
