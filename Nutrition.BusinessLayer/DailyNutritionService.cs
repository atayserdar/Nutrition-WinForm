using Nutrition.DataAccessLayer.Repositories;
using Nutrition.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Nutrition.Domain.Constants;

namespace Nutrition.BusinessLayer
{
    public class DailyNutritionService
    {
        public int AddDailyNutrition(DailyNutrition dailyNutrition)
        {
            DailyNutritionRepository dailyNutritionRepository = new DailyNutritionRepository();
            dailyNutritionRepository.Insert(dailyNutrition);
            dailyNutritionRepository.SaveChanges();
            return dailyNutrition.Id;
        }

        public ReturnValue DeleteDailyNurition(int id)
        {
            DailyNutritionRepository dailyNutritionRepository = new DailyNutritionRepository();
            var dailyNutrition = dailyNutritionRepository.GetById(id);
            if (dailyNutrition == null)
            {
                return ReturnValue.RecordNotFound;
            }
            dailyNutritionRepository.Delete(dailyNutrition);
            dailyNutritionRepository.SaveChanges();
            return ReturnValue.Success;
        } 

        public List<DailyNutrition> ListByUserId(int userId) 
        {
            DailyNutritionRepository dailyNutritionRepository = new DailyNutritionRepository();
            return dailyNutritionRepository.ListByUserId(userId);
        }
    }
}
