using GymMangmentDAL.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMangmentDAL.Reposatories.Interface
{
    internal interface IMemberSesstionsInterface
    {
        IEnumerable<MemberSesstions> GetAll();
        MemberSesstions GetById(int id);
        int update(MemberSesstions memberSesstions);
        int delete(MemberSesstions memberSesstions);
        int Add(MemberSesstions memberSesstions);
    }
}
