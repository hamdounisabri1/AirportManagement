using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace AM.infrastructure
{
    public class AMContext : DbContext
    {
        public DbSet<Plane> planes;
        public DbSet<Flight> flights;
        public DbSet<Passenger> passangers;
        public DbSet<Staff> staffs;
        public DbSet<Traveller> travellers;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=AirportManagementDB;Integrated Security=True");
        }

    }
}
