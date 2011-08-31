using System;
using System.Collections.Generic;
using System.Linq;
using SupplyDispense.Model.Base;
using SupplyDispense.Model.SubModel;

namespace SupplyDispense.Model.SheetModel
{
    public class InventoryCountModel : BaseModel
    {
        private readonly List<ZoomableItem> _countableItems;
        private readonly ISubject<List<ZoomableItem>> _itemsAdded = new Subject<List<ZoomableItem>>();
        public Action<DisplayableItem> CountRequest;

        public InventoryCountModel()
        {
            _countableItems = new List<ZoomableItem>();
        }

        public IObservable<List<ZoomableItem>> ItemsAdded
        {
            get { return _itemsAdded.AsObservable(); }
        }

        public List<ZoomableItem> CountableItems
        {
            get { return _countableItems; }
            set
            {
                _countableItems.Clear();
                _countableItems.AddRange(value);
                _itemsAdded.OnNext(_countableItems);
            }
        }
    }
}