using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data
{
    public class DatabaseContext :DbContext
    {
        public DatabaseContext(DbContextOptions options):base(options)
        {
            
        }
        
        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Country>().HasData(
                new Country() { Id = 1, Name = "United States", ShortName = "US" },
                new Country() { Id = 2, Name = "Iran", ShortName = "IR" },
                new Country() { Id = 3, Name = "Turkey", ShortName = "TU" }
            );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel() { Id = 1, Name = "hotel1", Rating = 4.2, Address = "some address1", CountryId = 1 },
                new Hotel() { Id = 2, Name = "hotel1", Rating = 4, Address = "some address2", CountryId = 1 },
                new Hotel() { Id = 3, Name = "hotel2", Rating = 3.2, Address = "some address3", CountryId = 1 },
                new Hotel() { Id = 4, Name = "hotel3", Rating = 4.5, Address = "some address4", CountryId = 2 },
                new Hotel() { Id = 5, Name = "hotel4", Rating = 4.3, Address = "some address5", CountryId = 2 },
                new Hotel() { Id = 6, Name = "hotel5", Rating = 5, Address = "some address6", CountryId = 3 }
            );
        }
    }
}
