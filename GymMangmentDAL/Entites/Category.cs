using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMangmentDAL.Entites
{
    public class Category:BaseEntity
    {
        public string CategoryName { get; set; } = null!;

        #region Relations
        #region category-sesstions
        public ICollection<Session> Sessions { get; set; } = null!;
        #endregion
        #endregion
    }
}
