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
    public class MealMapping : EntityTypeConfiguration<Meal>
    {
        public MealMapping()
        {
            Property(b => b.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(b => b.Name).IsRequired()
                                 .HasMaxLength(50);

            Property(b => b.Sequence).IsRequired();

            Ignore(b => b.DailyNutritionId);

            Ignore(b => b.DailyNutrition);

            Property(b => b.CreatedDate);

            Property(b => b.UpdatedDate);
        }
    }
}
