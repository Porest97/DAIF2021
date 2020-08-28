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
        public DbSet<Club> Club { get; set; }
        public DbSet<DastTest> DastTest { get; set; }
        public DbSet<District> District { get; set; }
        public DbSet<Game> Game { get; set; }
        public DbSet<GameCategory> GameCategory { get; set; }
        public DbSet<GameStatus> GameStatus { get; set; }
        public DbSet<GameType> GameType { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<PersonRole> PersonRole { get; set; }
        public DbSet<PersonStatus> PersonStatus { get; set; }
        public DbSet<PersonType> PersonType { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<SeriesStatus> SeriesStatus { get; set; }
        public DbSet<SeriesType> SeriesType { get; set; }
        public DbSet<Sport> Sport { get; set; }
        public DbSet<Workout> Workout { get; set; }
        public DbSet<MDProtocol> MDProtocol { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

       
    }
}
