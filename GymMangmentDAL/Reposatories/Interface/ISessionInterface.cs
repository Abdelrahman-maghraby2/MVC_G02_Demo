using GymMangmentDAL.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMangmentDAL.Reposatories.Interface
{
    internal interface ISessionInterface
    {
        IEnumerable<Session> GetAllSessions();
        Session GetSessionById(int id);
        int AddSession(Session session);
        int UpdateSession(Session session);
        int DeleteSession(Session session);
    }
}
