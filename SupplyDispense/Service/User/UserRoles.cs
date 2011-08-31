using System.Linq;
using Domain;
using Domain.Interface;
using SupplyDispense.Service.Interface;

namespace SupplyDispense.Service.User
{
    public class UserRoles
    {
        private readonly ISave _save;
        private readonly IRepository<user> _users;

        public UserRoles(IRepository<user> users, ISave save)
        {
            _users = users;
            _save = save;
        }

        public bool NeedsReset(string name)
        {
            return (_users.Query()
                        .FirstOrDefault(us => us.Name == name) ??
                    new user {NeedsReset = false})
                .NeedsReset;
        }

        public void CheckForAdmin()
        {
            if (_users.Query().FirstOrDefault(us => us.Name == Master.AdminName)
                != null) return;
            user user = _users.Create();
            user.Id = Master.AdminName;
            user.Name = Master.AdminName;
            user.NeedsReset = true;
            _save.Save();
        }
    }
}