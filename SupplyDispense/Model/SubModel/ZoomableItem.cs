using System;
using SupplyDispense.Model.Base;

namespace SupplyDispense.Model.SubModel
{
    public class ZoomableItem : BaseModel
    {
        public string ActionLabel;

        public ZoomableItem()
        {
        }

        public ZoomableItem(DisplayableItem item)
        {
            Display = item;
        }

        public DisplayableItem Display { get; set; }
        public IObservable<DisplayableItem> ActionRequested { get; set; }
    }
}