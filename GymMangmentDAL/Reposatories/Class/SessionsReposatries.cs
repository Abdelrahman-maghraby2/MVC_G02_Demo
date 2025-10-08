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
    internal class SessionsReposatries : ISessionInterface
    {
        private readonly GymDbcontext _dbcontext;

        public SessionsReposatries(GymDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public int AddSession(Session session)
        {
            _dbcontext.Add(session);
            return _dbcontext.SaveChanges();
        }

        public int DeleteSession(Session session)
        {
            _dbcontext.Remove(session);
            return _dbcontext.SaveChanges();
        }

        public IEnumerable<Session> GetAllSessions()
        {
           return _dbcontext.Sessions.ToList();
        }

        public Session GetSessionById(int id)
        {
            return _dbcontext.Sessions.Find(id)!;
        }

        public int UpdateSession(Session session)
        {
            _dbcontext.Update(session); 
            return _dbcontext.SaveChanges();
        }
    }
}
