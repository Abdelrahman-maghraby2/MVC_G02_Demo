using GymMangmentDAL.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMangmentDAL.Data.Configurations
{
    internal class MemberSesstionsConfigurations : IEntityTypeConfiguration<MemberSesstions>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<MemberSesstions> builder)
        {
            builder.Property(x=>x.CreatedAt)
                    .HasColumnName("BookingDate")
                    .HasDefaultValueSql("GetDate()");
            builder.Ignore(x=>x.Id);
            builder.HasKey(x => new { x.MemberId, x.SessionId });
        }
    }
}
