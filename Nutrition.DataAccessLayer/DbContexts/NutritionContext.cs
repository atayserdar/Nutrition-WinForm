using Nutrition.DataAccessLayer.Mappings;
using Nutrition.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutrition.DataAccessLayer.DbContexts
{
    public class NutritionContext : DbContext
    {
        public NutritionContext() : base("Server=.; Database=NutritionDB; Trusted_Connection=True")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<FoodMeal> FoodMeals { get; set; }
        public DbSet<DailyNutrition> DailyNutritions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new UserMapping());
            modelBuilder.Configurations.Add(new MealMapping());
            modelBuilder.Configurations.Add(new FoodMapping());
            modelBuilder.Configurations.Add(new FoodMealMapping());
            modelBuilder.Configurations.Add(new DailyNutritionMapping());
        }
    }
}
