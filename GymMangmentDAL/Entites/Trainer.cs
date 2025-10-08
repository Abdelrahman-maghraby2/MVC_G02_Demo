using GymMangmentDAL.Entites.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMangmentDAL.Entites
{
    public class Trainer:GymUser
    {
        // hire date == create at
        public Specialties Specialties { get; set; }

        #region Relations
        #region Trainer-Sesstions
        public ICollection<Session> TrainerSessions { get; set; } = null!;
        #endregion
        #endregion
    }
}
