using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMangmentDAL.Entites
{
    public class Plan:BaseEntity
    {
        public string Name { get; set; } = null!;

        public string  Descriptoin { get; set; }

        public int DurationDays { get; set; }

        public decimal Price { get; set; }

        public bool IsActive { get; set; }


        #region plan-membership
        public ICollection<MemberShip> PlanMember { get; set; } = null!;
        #endregion
    }
}
