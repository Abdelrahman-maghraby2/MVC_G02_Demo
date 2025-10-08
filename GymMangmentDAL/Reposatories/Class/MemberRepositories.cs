using GymMangmentDAL.Data.Contexts;
using GymMangmentDAL.Entites;
using GymMangmentDAL.Reposatories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMangmentDAL.Reposatories.Class
{
    internal class MemberRepositories : IMemberRepository
    {
        private readonly GymDbcontext _dbcontext;

        //public GymDbcontext dbcontext { get; set; }=new GymDbcontext();
        //private readonly GymDbcontext _dbcontext = new GymDbcontext();
        public MemberRepositories(GymDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public int Add(Member member)
        {
            _dbcontext.Add(member);
            return _dbcontext.SaveChanges();
        }

        public int Delete(int id)
        {
            var Member = _dbcontext.Members.Find(id);
            if (Member == null) return 0;
            _dbcontext.Remove(Member);
            return _dbcontext.SaveChanges();
        }

        public IEnumerable<Member> GetAll()
        {
            return _dbcontext.Members.ToList();
        }

        public Member? GetById(int id)=> _dbcontext.Members.Find(id);

        public int Update(Member member)
        {
            _dbcontext.Update(member);
            return _dbcontext.SaveChanges();
        }
    }
}
