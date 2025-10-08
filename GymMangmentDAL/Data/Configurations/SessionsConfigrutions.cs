using GymMangmentDAL.Entites;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMangmentDAL.Data.Configurations
{
    internal class SessionsConfigrutions : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)

        {
            builder.ToTable(tb => 
            {
                tb.HasCheckConstraint("SessionCapasityCheck", "Capacity Between 1 and 25");

                tb.HasCheckConstraint("SessionEndDateCheck", "EndDate > StartDate");
            });

            builder.HasOne(x => x.SesstionCategory)
                   .WithMany(c => c.Sessions)
                   .HasForeignKey(x => x.CategoryId);

            builder.HasOne(x=>x.SesstionTrainer)
                .WithMany(c=>c.TrainerSessions)
                .HasForeignKey(x=>x.TrainerId);




        }
    }
}
