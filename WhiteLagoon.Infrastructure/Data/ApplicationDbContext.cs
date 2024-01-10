using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WhiteLagoon.Domain.Entities;

namespace WhiteLagoon.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        }

        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Villa>().HasData
                (
                new Villa 
                {
                    Id = 1,
                    Name = "Villa 1",
                    Description = "Description for Villa 1",
                    Price = 1000.00,
                    Sqft = 2000,
                    Occupancy = 4,
                    ImageUrl = "https://placehold.co/600x401",
                    Created_Data = DateTime.Now,
                    Update_Data = DateTime.Now
                },

                new Villa
                {
                    Id = 2,
                    Name = "Villa 2",
                    Description = "Description for Villa 2",
                    Price = 1000.00,
                    Sqft = 2000,
                    Occupancy = 4,
                    ImageUrl = "https://placehold.co/600x401",
                    Created_Data = DateTime.Now,
                    Update_Data = DateTime.Now
                },

                new Villa
                {
                    Id = 3,
                    Name = "Villa 3",
                    Description = "Description for Villa 3",
                    Price = 1000.00,
                    Sqft = 2000,
                    Occupancy = 4,
                    ImageUrl = "https://placehold.co/600x401",
                    Created_Data = DateTime.Now,
                    Update_Data = DateTime.Now
                }
                );
        }
    }
}
