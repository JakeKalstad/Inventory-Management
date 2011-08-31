using System.Collections.Generic;

namespace SupplyDispense.Service.Interface
{
    public interface IDeleteItem
    {
        void Delete(IEnumerable<long> itemKeys);
        void Delete(long itemKey);
    }
}