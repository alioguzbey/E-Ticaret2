using Etic.Data.Abstract;
using Etic.Data.Concrete;
using Etic.Entities;

namespace Etic.Business.Services
{
    public class LoginService : ILoginService
    {
        IUserDal _userDal;
        public LoginService(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public User Login(string email, string password)
        {
            var output = _userDal.Get(x => x.Email == email && x.Password == password);
            if (output == null)
            {
                return null;
            }
            else
            {
                return output;
            }
        }
    }
}
