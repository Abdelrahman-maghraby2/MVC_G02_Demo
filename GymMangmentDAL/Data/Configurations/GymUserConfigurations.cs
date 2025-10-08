using GymMangmentDAL.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMangmentDAL.Data.Configurations
{
    internal class GymUserConfigurations<T> : IEntityTypeConfiguration<T> where T : GymUser
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.Name)
                   .HasColumnType("varchar")
                   .HasMaxLength(50);

            builder.Property(x => x.Email)
                    .HasColumnType("varchar")
                    .HasMaxLength(100);

            builder.Property(x => x.Phone)
                    .HasColumnType("varchar")
                    .HasMaxLength(11);

            builder.ToTable(tb =>
            {
                tb.HasCheckConstraint("GymUserValidEmailCheck", "Email LIKE '%@%.%'");
                tb.HasCheckConstraint("GymUserValidPhoneCheck", "Phone LIKE '01%' AND Phone NOT LIKE '%[^0-9]%'");
            });

            builder.HasIndex(x => x.Email)
                   .IsUnique();

            builder.HasIndex(x => x.Phone)
                   .IsUnique();

            builder.OwnsOne(x => x.Address, AddressBuilder =>
            { 
                AddressBuilder.Property(x=>x.Street)
                              .HasColumnName("Street")
                              .HasColumnType("varchar")
                              .HasMaxLength(30);

                AddressBuilder.Property(x=>x.City)
                              .HasColumnName("City")
                              .HasColumnType("varchar")
                              .HasMaxLength(30);

                AddressBuilder.Property(x=>x.BuildingNumber)
                              .HasColumnName("BuildingNumber")
                              .HasColumnType("varchar")
                              .HasMaxLength(30);
            
            });
        }
    }
}
