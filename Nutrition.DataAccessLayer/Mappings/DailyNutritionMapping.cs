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
    public class DailyNutritionMapping : EntityTypeConfiguration<DailyNutrition>
    {
        public DailyNutritionMapping()
        {
            Property(b => b.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(b => b.UserId).IsRequired();

            Ignore(b => b.User);

            Property(b => b.MealId).IsRequired();

            Ignore(b => b.Meal);

            Property(b => b.FoodId).IsRequired();

            Ignore(b => b.Food);

            Property(b => b.PortionQuantity).IsRequired();

            Property(b => b.CreatedDate);

            Property(b => b.UpdatedDate);
        }
    }
}
