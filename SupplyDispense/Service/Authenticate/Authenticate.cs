using System.Linq;
using Domain;
using Domain.Interface;
using SupplyDispense.Enum;
using SupplyDispense.Model.Interface;
using SupplyDispense.Service.Encryption;
using SupplyDispense.Service.Interface;

namespace SupplyDispense.Service.Authenticate
{
    public class Authenticate : IAuthenticate
    {
        private readonly IRepository<user> _userRepository;

        public Authenticate(IRepository<user> userRepository)
        {
            _userRepository = userRepository;
        }

        #region IAuthenticate Members

        public RuleResult IsAuthenticated(ILoginModel model)
        {
            user user = CurrentUser.CurrentClient = GetFirstUser(model);
            return user == null
                       ? RuleResult.Fail
                       : RuleResult.Success;
        }

        #endregion

        private user GetFirstUser(ILoginModel model)
        {
            string pass = Encryptor.Encrypt(model.PassWord);
            return _userRepository.Query()
                .FirstOrDefault(us => us.Name == model.Login
                                      && us.Password == pass);
        }
    }
}