using FoodApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodApp.Data
{
    public class FoodDbContext : DbContext
    {
        public FoodDbContext(DbContextOptions<FoodDbContext> options) : base(options)
        {

        }
        public DbSet<Food> Foods { get; set; }
    }
}