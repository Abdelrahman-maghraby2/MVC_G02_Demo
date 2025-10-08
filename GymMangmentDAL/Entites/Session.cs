using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMangmentDAL.Entites
{
    public class Session:BaseEntity
    {
        public string Description { get; set; } = null!;

        public int Capacity { get; set; }
         
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        #region Relations

        #region Sesstions-category
        public int CategoryId { get; set; }
        public Category SesstionCategory { get; set; } = null!;
        #endregion

        #region Sesstion-Trainer
        public int TrainerId { get; set; }
        public Trainer SesstionTrainer { get; set; }=null!;
        #endregion

        #region Sesstions-membersesstions

        public ICollection<MemberSesstions> SesstionMembers { get; set; } = null!;

        #endregion
        #endregion
    }
}
