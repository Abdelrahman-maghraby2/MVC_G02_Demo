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
    internal class MemberSesstionsProperties : IMemberSesstionsInterface
    {
        private readonly GymDbcontext _dbcontext;

        public MemberSesstionsProperties( GymDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public int Add(MemberSesstions memberSesstions)
        {
            _dbcontext.Add(memberSesstions);
            return _dbcontext.SaveChanges();
        }

        public int delete(MemberSesstions memberSesstions)
        {
            _dbcontext.Remove(memberSesstions);
            return _dbcontext.SaveChanges();
        }

        public IEnumerable<MemberSesstions> GetAll()
        {
            return _dbcontext.MemberSesstions.ToList();
        }

        public MemberSesstions GetById(int id)
        {
           return _dbcontext.MemberSesstions.Find(id);
        }

        public int update(MemberSesstions memberSesstions)
        {
            _dbcontext.Update(memberSesstions);
            return _dbcontext.SaveChanges();
        }
    }
}
