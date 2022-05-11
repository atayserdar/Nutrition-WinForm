using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutrition.Domain.Entities
{
    public class Meal : BaseEntity
    {
        public Meal()
        {
            FoodMeals = new HashSet<FoodMeal>();
        }

        public string Name { get; set; }
        public byte Sequence { get; set; }
        public int DailyNutritionId { get; set; }
        public DailyNutrition DailyNutrition { get; set; }
        public ICollection<FoodMeal> FoodMeals { get; set; }

    }
}
