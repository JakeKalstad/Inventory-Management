using System;
using System.Collections.Generic;
using Domain;

namespace SupplyDispense.Service.Interface
{
    public interface IFetchUsers
    {
        IEnumerable<user> GetUsers(Func<user, bool> predicate = null);
    }
}