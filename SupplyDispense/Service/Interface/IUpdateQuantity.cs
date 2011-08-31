using System;
using System.Collections.Generic;

namespace SupplyDispense.Service.Interface
{
    public interface IUpdateQuantity
    {
        void Save(long itemKey, long quantity);
        void Save(IEnumerable<Tuple<long, long>> itemsKeyQuantity);
    }
}