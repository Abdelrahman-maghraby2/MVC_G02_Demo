using GymMangmentDAL.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMangmentDAL.Reposatories.Interface
{
    internal interface IMemberShipInterface
    {
        IEnumerable<MemberShip> GetAll();
        MemberShip GetById(int id);
        int Update(MemberShip memberShip);
        int Delete(MemberShip memberShip);
        int Add(MemberShip memberShip);

    }
}
