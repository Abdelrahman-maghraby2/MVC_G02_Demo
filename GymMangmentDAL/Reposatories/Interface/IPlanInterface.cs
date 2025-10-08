using GymMangmentDAL.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMangmentDAL.Reposatories.Interface
{
    internal interface IPlanInterface
    {
     IEnumerable<Plan> GetAllPlans();
        Plan GetPlanById(int id);
        int AddPlan(Plan plan);
        int UpdatePlan(Plan plan);
        int DeletePlan(Plan plan);
    }
}
