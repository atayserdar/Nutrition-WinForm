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
    public class FoodMapping : EntityTypeConfiguration<Food>
    {
        public FoodMapping()
        {
            Property(b => b.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
           
            Property(b => b.Name).IsRequired()
                                 .HasMaxLength(150);

            Property(b => b.Quantity).IsRequired();

            Property(b => b.Kcal).IsRequired();

            Ignore(b => b.DailyNutritionId);

            Ignore(b => b.DailyNutrition);

            Property(b => b.PhotoPath);

            Property(b => b.CreatedDate);

            Property(b => b.UpdatedDate);
        }
    }
}
