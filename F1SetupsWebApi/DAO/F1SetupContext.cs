using Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAO
{
    public class F1SetupContext: DbContext
    {
        public F1SetupContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<F1Team> F1Teams { get; set; }
        public DbSet<F1Engine> F1Engines { get; set; }
        public DbSet<F1ControllerType> F1ControllerTypes { get; set; }
        public DbSet<F1Driver> F1Drivers { get; set; }
        public DbSet<F1RaceCircuit> F1RaceCircuits { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<F1GameType> F1GameTypes { get; set; }
        public DbSet<F1LapTime> F1LapTimes { get; set; }
        public DbSet<F1Setup> F1Setups { get; set; }
    }
}
