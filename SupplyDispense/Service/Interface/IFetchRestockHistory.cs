using System.Collections.Generic;
using SupplyDispense.Model.SubModel;

namespace SupplyDispense.Service.Interface
{
    public interface IFetchRestockHistory
    {
        List<RestockHistoryRowModel> GetRows();
    }
}