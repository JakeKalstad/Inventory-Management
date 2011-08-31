using System;
using SupplyDispense.Model.Base;

namespace SupplyDispense.Model.SubModel
{
    public class DisplayableItem : BaseModel
    {
        public DisplayableItem(long key)
        {
            Key = key;
        }

        public long Key { get; private set; }
        public double ItemNumber { get; set; }
        public string ItemDescription { get; set; }
        public string Location { get; set; }
        public string Id { get; set; }
        public string ReorderPoint { get; set; }
        public long Quantity { get; set; }
        public Action<DisplayableItem> Clicked { get; set; }
    }
}