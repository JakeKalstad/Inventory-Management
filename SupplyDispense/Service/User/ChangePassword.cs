using System.Linq;
using Domain;
using Domain.Interface;
using SupplyDispense.Service.Encryption;
using SupplyDispense.Service.Interface;

namespace SupplyDispense.Service.User
{
    public class ChangePassword : IChangePassword
    {
        private readonly ISave _save;
        private readonly IRepository<user> _users;

        public ChangePassword(IRepository<user> users, ISave save)
        {
            _users = users;
            _save = save;
        }

        #region IChangePassword Members

        public void ResetPassword(string name, string newPass)
        {
            user user = _users.Query()
                .FirstOrDefault(u => u.Name == name
                                     && u.NeedsReset);
            if (user == null) return;
            user.Password = Encryptor.Encrypt(newPass);
            user.NeedsReset = false;
            _save.Save();
        }

        public void ResetPassword(long userKey)
        {
            (_users.Query()
                 .FirstOrDefault(us => us.PKey == userKey) ?? new user())
                .NeedsReset = true;
            _save.Save();
        }

        #endregion
    }
}