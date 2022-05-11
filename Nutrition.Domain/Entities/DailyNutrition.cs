using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutrition.Domain.Entities
{
    public class DailyNutrition : BaseEntity
    {
        public  int UserId { get; set; }
        public virtual User User { get; set; }
        public  int MealId { get; set; }
        public virtual Meal Meal { get; set; }
        public  byte PortionQuantity { get; set; }
        public  int FoodId { get; set; }
        public virtual Food Food { get; set; }

    }
}
