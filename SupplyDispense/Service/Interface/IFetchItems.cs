using System;
using System.Collections.Generic;
using Domain;
using SupplyDispense.Model.SubModel;

namespace SupplyDispense.Service.Interface
{
    public interface IFetchItems
    {
        IEnumerable<DisplayableItem> RetrieveItems(Func<item, bool> predicate = null);
    }
}