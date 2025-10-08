using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMangmentDAL.Entites
{
    public class Member:GymUser
    {
        // join date == create at
        public string?  Photo { get; set; }

        #region Relations
        #region Member-HealthRecord
                public HealthRecord HealthRecord { get; set; } = null!;

        #endregion

        #region Member-MemberShip
        public ICollection<MemberShip> MemberShips { get; set; } = null!;
        #endregion

        #region Membersessions-member
        public ICollection<MemberSesstions> MemberSesstions { get; set; } = null!;
        #endregion
        #endregion
    }
}
