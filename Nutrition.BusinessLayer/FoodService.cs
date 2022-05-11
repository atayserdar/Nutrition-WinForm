using Nutrition.DataAccessLayer.Repositories;
using Nutrition.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutrition.BusinessLayer
{
    public class FoodService
    {
        public List<Food> List()
        {
            FoodRepository foodRepository = new FoodRepository();
            return foodRepository.List();
        }
    }
}
