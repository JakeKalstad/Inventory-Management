using System;
using System.Collections.Generic;
using System.Linq;
using Domain;
using Domain.Interface;
using SupplyDispense.Service.Interface;

namespace SupplyDispense.Service.User
{
    public class FetchUsers : IFetchUsers
    {
        private readonly IRepository<user> _users;

        public FetchUsers(IRepository<user> users)
        {
            _users = users;
        }

        #region IFetchUsers Members

        public IEnumerable<user> GetUsers(Func<user, bool> predicate)
        {
            Func<user, bool> pred = predicate ?? (_ => true);
            return _users.Query()
                .Where(pred).ToList();
        }

        #endregion
    }
}