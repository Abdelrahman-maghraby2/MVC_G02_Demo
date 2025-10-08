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
    internal class MemberShipConfigurations : IEntityTypeConfiguration<MemberShip>
    {
        public void Configure(EntityTypeBuilder<MemberShip> builder)
        {
           builder.Property(x=>x.CreatedAt)
                .HasColumnName("StartDate")
                .HasDefaultValueSql("GetDate()");

            builder.HasKey(x=>new {x.MemberId,x.PlanId});

            builder.Ignore(x => x.Id);

        }
    }
}
