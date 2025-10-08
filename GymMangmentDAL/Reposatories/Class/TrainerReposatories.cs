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
    internal class TrainerReposatories : ITrainerInterface
    {
        private readonly GymDbcontext _dbcontext;

        public TrainerReposatories(GymDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public int Add(Trainer trainer)
        {
            _dbcontext.Add(trainer);
            return _dbcontext.SaveChanges();
        }

        public int Delete(Trainer trainer)
        {
            _dbcontext.Remove(trainer);
            return _dbcontext.SaveChanges();
        }

        public IEnumerable<Trainer> GetAll()=> _dbcontext.Trainers.ToList();

        public Trainer? GetById(int id)=> _dbcontext.Trainers.Find(id);

        public int Update(Trainer trainer)
        {
            _dbcontext.Update(trainer);
            return _dbcontext.SaveChanges();
        }
    }
}
