using Nutrition.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutrition.DataAccessLayer.Mappings
{
    public class FoodMealMapping : EntityTypeConfiguration<FoodMeal>
    {
        public FoodMealMapping()
        {
            Property(b => b.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasRequired(b => b.Food).WithMany(b => b.FoodMeals)
                                    .HasForeignKey(b => b.FoodId);

            HasRequired(b => b.Meal).WithMany(b => b.FoodMeals)
                                    .HasForeignKey(b => b.MealId);

            Property(b => b.CreatedDate);

            Property(b => b.UpdatedDate);
        }
    }
}
