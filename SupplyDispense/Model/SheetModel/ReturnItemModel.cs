using System;
using System.Collections.Generic;
using System.Linq;
using SupplyDispense.Model.Base;
using SupplyDispense.Model.SubModel;

namespace SupplyDispense.Model.SheetModel
{
    public class ReturnItemModel : BaseModel
    {
        private readonly ISubject<List<DisplayableItem>> _addedRows = new Subject<List<DisplayableItem>>();

        private readonly List<DisplayableItem> _rows;

        public ReturnItemModel()
        {
            _rows = new List<DisplayableItem>();
            Shifters = new ShifterModel();
        }

        public ShifterModel Shifters { get; set; }

        public IObservable<List<DisplayableItem>> RowsAdded
        {
            get { return _addedRows.AsObservable(); }
        }

        public List<DisplayableItem> Rows
        {
            get { return _rows; }
            set
            {
                _rows.Clear();
                _rows.AddRange(value);
                _addedRows.OnNext(value);
            }
        }
    }
}