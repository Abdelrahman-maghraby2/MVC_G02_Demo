using GymMangmentDAL.Data.Contexts;
using GymMangmentDAL.Entites;
using GymMangmentDAL.Reposatories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMangmentDAL.Reposatories.Class
{
    internal class MemberShipProperties : IMemberShipInterface
    {
        private readonly GymDbcontext _dbcontext;

        public MemberShipProperties(GymDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public int Add(MemberShip memberShip)
        {
            _dbcontext.Add(memberShip);
            return _dbcontext.SaveChanges();
        }

        public int Delete(MemberShip memberShip)
        {
            _dbcontext.Remove(memberShip);
            return _dbcontext.SaveChanges();    
        }

        public IEnumerable<MemberShip> GetAll()
        {
           return _dbcontext.MemberShips.ToList();
        }

        public MemberShip GetById(int id)
        {
            return _dbcontext.MemberShips.Find(id);
        }

        public int Update(MemberShip memberShip)
        {
            _dbcontext.Update(memberShip);
            return _dbcontext.SaveChanges();    
        }
    }
}
