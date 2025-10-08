using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMangmentDAL.Entites
{
    public class MemberSesstions:BaseEntity
    {
        public bool IsAttended { get; set; }


        #region membersession-member
        public int MemberId { get; set; }
        public Member Member { get; set; } = null!;
        #endregion

        #region membersession-sessions
        public int SessionId { get; set; }
        public Session Session { get; set; } = null!;
        #endregion
    }
}
