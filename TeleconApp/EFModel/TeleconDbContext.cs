using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace TeleconApp.EFModel
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class TeleconDbContext : DbContext
    {
        public TeleconDbContext() : base("DbContext"){}
        public DbSet<Employee> Employees { get; set; }
        public DbSet<CableType> CableTypes { get; set; }
        public DbSet<CivilTask> CivilTasks { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<Drill> Drills { get; set; }
        public DbSet<Enclosure> Enclosures { get; set; }
        public DbSet<Network> Networks { get; set; }
        public DbSet<SplicerCableActivity> SplicerCableActivities { get; set; }
        public DbSet<SplicerTestActivity> SplicerTestActivities { get; set; }
        public DbSet<SplicerPrepActivity> SplicerPrepActivities { get; set; }
        public DbSet<SplicingPrep> SplicerPreps { get; set; }
        public DbSet<SplicingTest> SplicerTests { get; set; }
        public DbSet<VacTruck> VackTrucks { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<EmployeeDivision> EmployeeDivisions { get; set; }
        public DbSet<AspNetUsers> AspNetUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}