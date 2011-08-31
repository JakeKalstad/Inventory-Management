using System.Linq;
using Domain;
using Domain.Interface;
using SupplyDispense.Service.Interface;

namespace SupplyDispense.Service.User
{
    public class CreateUser : ICreateUser
    {
        private readonly IRepository<user> _users;
        private readonly IRepository<usertype> _usertype;

        public CreateUser(IRepository<user> users,
                          IRepository<usertype> usertype,
                          ISave save)
        {
            Save = save;
            _users = users;
            _usertype = usertype;
        }

        private ISave Save { get; set; }

        #region ICreateUser Members

        public void Create(string name, string id, string type)
        {
            user user = _users.Create();
            user.Name = name;
            user.Id = id;
            user.UserType = IfTypeExists(type)
                                ? ExistingType(type)
                                : NewType(type);
            user.NeedsReset = true;
            Save.Save();
        }

        #endregion

        private bool IfTypeExists(string type)
        {
            return _usertype.Query()
                       .FirstOrDefault(ut => ut.Display == type) != null;
        }

        private long ExistingType(string type)
        {
            return _usertype.Query()
                .Where(ut => ut.Display == type)
                .Select(ut => ut.Key)
                .FirstOrDefault();
        }

        private long NewType(string type)
        {
            usertype newtype = _usertype.Create();
            newtype.Display = type;
            newtype.Key = CreateKey();
            return newtype.Key;
        }

        private long CreateKey()
        {
            return _usertype.Query()
                       .Select(ut => ut.Key)
                       .OrderBy(ut => ut)
                       .LastOrDefault() + 1;
        }
    }
}