using System;
using System.Collections.Generic;
using System.Linq;
using SupplyDispense.Model.Base;
using SupplyDispense.Model.SubModel;

namespace SupplyDispense.Model.SheetModel
{
    public class UserConfigModel : BaseModel
    {
        private readonly ISubject<List<UserRowModel>> _itemsAdded = new Subject<List<UserRowModel>>();
        private readonly List<UserRowModel> _rows;

        public Action<UserRowModel> HandleChangeAccess;
        public Action<UserRowModel> HandlePasswordReset;
        public Action<UserRowModel> HandleTransactionReport;

        public UserConfigModel()
        {
            _rows = new List<UserRowModel>();
        }

        public List<UserRowModel> UserRows
        {
            get { return _rows; }
            set
            {
                _rows.Clear();
                _rows.AddRange(value);
                _itemsAdded.OnNext(_rows);
            }
        }

        public IObservable<IEnumerable<UserRowModel>> ItemsAdded
        {
            get { return _itemsAdded.AsObservable(); }
        }
    }
}