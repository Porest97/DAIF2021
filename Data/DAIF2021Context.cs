using DAIF2021.Models.DataModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAIF2021.Data;

namespace DAIF2021.Data
{
    public class DAIF2021Context : IdentityDbContext<ApplicationUser>
    {
        public DAIF2021Context(DbContextOptions<DAIF2021Context> options)
            : base(options)
        { }


        public DbSet<Arena> Arena { get; set; }
        public DbSet<DastTest> DastTest { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Sport> Sport { get; set; }
        public DbSet<Workout> Workout { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        public DbSet<DAIF2021.Models.DataModels.Club> Club { get; set; }

        public DbSet<DAIF2021.Models.DataModels.District> District { get; set; }
    }
}
