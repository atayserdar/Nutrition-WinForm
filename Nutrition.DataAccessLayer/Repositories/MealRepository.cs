using Nutrition.DataAccessLayer.DbContexts;
using Nutrition.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutrition.DataAccessLayer.Repositories
{
    public class MealRepository
    {
        private NutritionContext nutritionContext;
        public MealRepository()
        {
            nutritionContext = new NutritionContext();
        }
        public List<Meal> List()
        {
            return nutritionContext.Meals.OrderBy(x => x.Sequence).ToList();
        }
    }
}
