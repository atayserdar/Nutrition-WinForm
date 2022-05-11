using Nutrition.DataAccessLayer.DbContexts;
using Nutrition.Domain.Entities;
using System.Linq;

namespace Nutrition.DataAccessLayer.Repositories
{
    public class UserRepository
    {
        private NutritionContext nutritionContext;

        public UserRepository()
        {
            nutritionContext = new NutritionContext();
        }

        public void Insert(User user)
        {
            nutritionContext.Users.Add(user);
        }

        public User GetByEmail(string email)
        {
            return nutritionContext.Users.FirstOrDefault(x => x.Email == email);
        }

        public User GetByEmailAndPassword(string email, string password)
        {
            return nutritionContext.Users.FirstOrDefault(x => x.Email == email && x.Password == password);
        }

        public int SaveChanges()
        {
            return nutritionContext.SaveChanges();
        }
    }
}
