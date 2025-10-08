using GymMangmentDAL.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GymMangmentDAL.Data.Contexts
{
    public class GymDbcontext:DbContext
    {
        public GymDbcontext(DbContextOptions<GymDbcontext> options):base(options)
        {
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server = .; Database =GymMangmentGroup01 ; Trusted_Connection = true; TrustServerCertificate=true");
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }

        #region Dbsets
        public DbSet<Member> Members { get; set; } 
        public DbSet<HealthRecord> HealthRecords { get; set; }
        public DbSet<MemberSesstions> MemberSesstions { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<MemberShip> MemberShips { get; set; }
        public DbSet<Plan> Plans { get; set; }
        #endregion
    }
}
