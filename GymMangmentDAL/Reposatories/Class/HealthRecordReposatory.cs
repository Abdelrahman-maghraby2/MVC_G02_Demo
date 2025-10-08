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
    internal class HealthRecordReposatory : IHealthRecordInterface
    {
        private readonly GymDbcontext _dbcontext;

        public HealthRecordReposatory(GymDbcontext dbcontext)
        {
           _dbcontext = dbcontext;
        }
        public int AddHealthRecord(HealthRecord healthRecord)
        {
          _dbcontext.HealthRecords.Add(healthRecord);
            return _dbcontext.SaveChanges();
        }

        public int DeleteHealthRecord(int id)
        {
            _dbcontext.HealthRecords.Remove(GetHealthRecordById(id));
            return _dbcontext.SaveChanges();
        }

        public IEnumerable<HealthRecord> GetAllHealthRecords()
        {
           return _dbcontext.HealthRecords.ToList();
        }

        public HealthRecord GetHealthRecordById(int id)
        {
            return _dbcontext.HealthRecords.Find(id);
        }

        public int UpdateHealthRecord(HealthRecord healthRecord)
        {
            _dbcontext.HealthRecords.Update(healthRecord);
            return _dbcontext.SaveChanges();
        }
    }
}
