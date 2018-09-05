using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using gcCarFinalProject.Data.Maps;
using gcCarFinalProject.Domain.Models;

namespace gcCarFinalProject.Data
{
    public class CarContext : DbContext
    {
        public CarContext() : base("GCCars")
        {
            Database.SetInitializer(new CarInitializer());
        }

        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CarMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
