using System;
using System.Collections.Generic;
using Domain;

namespace SupplyDispense.Service.Interface
{
    public interface IFetchLocations
    {
        IEnumerable<location> Fetch(Func<location, bool> predicate = null);
    }
}