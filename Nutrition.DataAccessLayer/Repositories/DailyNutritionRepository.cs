using Nutrition.DataAccessLayer.DbContexts;
using Nutrition.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Nutrition.Domain.Constants;

namespace Nutrition.DataAccessLayer.Repositories
{
    public class DailyNutritionRepository
    {
        NutritionContext nutritionContext;

        public DailyNutritionRepository()
        {
            nutritionContext = new NutritionContext();
        }

        public void Insert(DailyNutrition dailyNutrition)
        {
            nutritionContext.DailyNutritions.Add(dailyNutrition);
        }

        public DailyNutrition GetById(int id)
        {
            return nutritionContext.DailyNutritions.FirstOrDefault(x => x.Id == id);
        }

        public void Delete(DailyNutrition dailyNutrition)
        {
            nutritionContext.DailyNutritions.Remove(dailyNutrition);
        }

        public List<DailyNutrition> ListByUserId(int userId)
        {
            return nutritionContext.DailyNutritions.Where(x => x.UserId == userId).ToList();
        }

        public int SaveChanges()
        {
            return nutritionContext.SaveChanges();
        }
    }
}
