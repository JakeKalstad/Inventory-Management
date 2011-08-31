using System;
using System.Collections.Generic;
using System.Linq;
using SupplyDispense.Model.Base;
using SupplyDispense.Model.SubModel;

namespace SupplyDispense.Model.SheetModel
{
    public class DeleteItemModel : BaseModel
    {
        private readonly List<ZoomableItem> _deletableItems;
        private readonly ISubject<List<ZoomableItem>> _itemsAdded = new Subject<List<ZoomableItem>>();
        public Action<DisplayableItem> DeleteRequest;

        public DeleteItemModel()
        {
            _deletableItems = new List<ZoomableItem>();
        }

        public List<ZoomableItem> DeletableItems
        {
            get { return _deletableItems; }
            set
            {
                _deletableItems.Clear();
                _deletableItems.AddRange(value);
                _itemsAdded.OnNext(_deletableItems);
            }
        }

        public IObservable<IEnumerable<ZoomableItem>> ItemsAdded
        {
            get { return _itemsAdded.AsObservable(); }
        }
    }
}