using Nutrition.DataAccessLayer.Repositories;
using Nutrition.Domain.Entities;
using static Nutrition.Domain.Constants;

namespace Nutrition.BusinessLayer
{
    public class UserService
    {
        public ReturnValue AddUser(User user)
        {
            UserRepository userRepository = new UserRepository();

            User existUser = userRepository.GetByEmail(user.Email);
            if (existUser != null)
            {
                return ReturnValue.RecordAlreadyExist;
            }

            userRepository.Insert(user);
            userRepository.SaveChanges();
            return ReturnValue.Success;
        }

        public User GetByEmailAndPassword(string email, string password)
        {
            UserRepository userRepository = new UserRepository();
            return userRepository.GetByEmailAndPassword(email, password);
        }
    }
}
