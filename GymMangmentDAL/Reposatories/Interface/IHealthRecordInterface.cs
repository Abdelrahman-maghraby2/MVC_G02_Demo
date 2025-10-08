using GymMangmentDAL.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMangmentDAL.Reposatories.Interface
{
    internal interface IHealthRecordInterface
    {
        IEnumerable<HealthRecord> GetAllHealthRecords();
        HealthRecord GetHealthRecordById(int id);
        int  AddHealthRecord(HealthRecord healthRecord);
        int UpdateHealthRecord(HealthRecord healthRecord);
        int DeleteHealthRecord(int id);
    }
}
