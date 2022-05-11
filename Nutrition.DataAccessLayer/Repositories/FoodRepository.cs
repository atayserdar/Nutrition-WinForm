using Nutrition.DataAccessLayer.DbContexts;
using Nutrition.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutrition.DataAccessLayer.Repositories
{
    public class FoodRepository
    {
        private NutritionContext nutritionContext;
        public FoodRepository()
        {
            nutritionContext = new NutritionContext();
        }

        public List<Food> List()
        {
            return nutritionContext.Foods.ToList();
        }
    }
}
