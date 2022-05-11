using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutrition.Domain.Entities
{
    public class FoodMeal : BaseEntity
    {
        public int FoodId { get; set; }
        public Food Food { get; set; }
        public int MealId { get; set; }
        public Meal Meal { get; set; }
    }
}
