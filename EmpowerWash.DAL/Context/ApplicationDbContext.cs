using System;
using EmpowerWash.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace EmpowerWash.DAL.Context
{
	public class ApplicationDbContext :DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
		{
		}

        public DbSet<Service>? Services { get; set; }
        public DbSet<Location>? Locations { get; set; }
        public DbSet<Booking>? bookings { get; set; }
        public DbSet<ServiceFeadback>? servicesFeadbacks { get; set; }
        public DbSet<Customer>? customers { get; set; }
        public DbSet<Car>? cars { get; set; }
        public DbSet<Employee>? employees { get; set; }

    }
}

