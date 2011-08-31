using System.Collections.Generic;
using System.Linq;
using Domain;
using Domain.Interface;
using SupplyDispense.Model.SubModel;
using SupplyDispense.Service.Interface;

namespace SupplyDispense.Service.RestockHistory
{
    public class FetchRestockHistory : IFetchRestockHistory
    {
        private readonly IRepository<restockhistory> _history;
        private readonly IRepository<user> _users;

        public FetchRestockHistory(IRepository<restockhistory> history, IRepository<user> users)
        {
            _history = history;
            _users = users;
        }

        #region IFetchRestockHistory Members

        public List<RestockHistoryRowModel> GetRows()
        {
            return _history.Query()
                .Join(_users.Query(),
                      rh => rh.UserKey, us => us.PKey,
                      (rh, us) => new {Record = rh, User = us})
                .Select(uarh => new RestockHistoryRowModel
                                    {
                                        UserName = uarh.User.Name,
                                        RestockDate = uarh.Record.StockDate.ToString(),
                                        RestockNumber = uarh.Record.PointName
                                    }).ToList();
        }

        #endregion
    }
}