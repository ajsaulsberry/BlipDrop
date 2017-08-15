using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using BlipDrop.Models;

namespace BlipDrop.Data
{
    public class BlipDropContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Region> Regions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}