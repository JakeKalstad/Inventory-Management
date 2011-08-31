using System;
using System.Collections.Generic;
using System.Linq;
using SupplyDispense.Model.Base;
using SupplyDispense.Model.SubModel;

namespace SupplyDispense.Model.SheetModel
{
    public class AdjustReorderModel : BaseModel
    {
        private readonly List<ZoomableItem> _adjustableItems;
        private readonly ISubject<List<ZoomableItem>> _itemsAdded = new Subject<List<ZoomableItem>>();
        public Action<DisplayableItem> AdjustmentRequest;

        public AdjustReorderModel()
        {
            _adjustableItems = new List<ZoomableItem>();
        }

        public List<ZoomableItem> AdjustableItems
        {
            get { return _adjustableItems; }
            set
            {
                _adjustableItems.Clear();
                _adjustableItems.AddRange(value);
                _itemsAdded.OnNext(_adjustableItems);
            }
        }

        public IObservable<IEnumerable<ZoomableItem>> ItemsAdded
        {
            get { return _itemsAdded.AsObservable(); }
        }
    }
}