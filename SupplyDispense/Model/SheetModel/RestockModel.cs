using System;
using System.Collections.Generic;
using System.Linq;
using SupplyDispense.Model.Base;
using SupplyDispense.Model.SubModel;

namespace SupplyDispense.Model.SheetModel
{
    public class RestockModel : BaseModel
    {
        private readonly ISubject<List<ZoomableItem>> _itemsAdded = new Subject<List<ZoomableItem>>();
        private readonly List<ZoomableItem> _restockableItems;

        public Action<DisplayableItem> QuantityRequest;

        public RestockModel()
        {
            _restockableItems = new List<ZoomableItem>();
        }

        public IObservable<List<ZoomableItem>> ItemsAdded
        {
            get { return _itemsAdded.AsObservable(); }
        }

        public List<ZoomableItem> RestockableItems
        {
            get { return _restockableItems; }
            set
            {
                _restockableItems.Clear();
                _restockableItems.AddRange(value);
                _itemsAdded.OnNext(_restockableItems);
            }
        }
    }
}