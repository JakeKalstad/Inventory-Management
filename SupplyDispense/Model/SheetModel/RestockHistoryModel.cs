using System;
using System.Collections.Generic;
using System.Linq;
using SupplyDispense.Model.Base;
using SupplyDispense.Model.SubModel;

namespace SupplyDispense.Model.SheetModel
{
    public class RestockHistoryModel : BaseModel
    {
        private readonly List<RestockHistoryRowModel> _rows;

        private readonly ISubject<IEnumerable<RestockHistoryRowModel>> _subject =
            new Subject<IEnumerable<RestockHistoryRowModel>>();

        public RestockHistoryModel()
        {
            _rows = new List<RestockHistoryRowModel>();
        }

        public List<RestockHistoryRowModel> Rows
        {
            get { return _rows; }
            set
            {
                _rows.Clear();
                _rows.AddRange(value);
                _subject.OnNext(_rows);
            }
        }

        public IObservable<IEnumerable<RestockHistoryRowModel>> ItemsAdded
        {
            get { return _subject.AsObservable(); }
        }
    }
}