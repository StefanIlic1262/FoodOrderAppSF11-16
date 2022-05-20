using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderAppSF11_16.Model
{
    public class FoodOrderDataContext : DbContext
    {
        public FoodOrderDataContext(DbContextOptions<FoodOrderDataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Dish> Dishes { get; set; }

        public DbSet<DailyMenu> DailyMenus { get; set; }

        public DbSet<WeeklyMenu> WeeklyMenus { get; set; }

        public DbSet<Store> Stores { get; set; }


    }
}
