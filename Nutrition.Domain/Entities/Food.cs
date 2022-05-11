using System.Collections.Generic;
using System.Drawing;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace Nutrition.Domain.Entities
{
    public class Food : BaseEntity
    {
        public Food()
        {
            FoodMeals = new HashSet<FoodMeal>();
        }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Kcal { get; set; }
        public string Description { get; set; }
        public int DailyNutritionId { get; set; }
        public string PhotoPath { get; set; }
        public DailyNutrition DailyNutrition { get; set; }
        public virtual ICollection<FoodMeal> FoodMeals { get; set; }
    }
}
