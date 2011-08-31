using System;
using SupplyDispense.Model.Base;

namespace SupplyDispense.Model.SubModel
{
    public class ShiftableItem : BaseModel, IComparable
    {
        private long _amountToAdjust;
        private long _qty;

        public ShiftableItem()
        {
            Decrement = () => AmountToAdjust -= 1;
            Increment = () => AmountToAdjust += 1;
        }

        public Action Decrement { get; set; }
        public Action Increment { get; set; }
        public Func<long, long, long> QuantityFinder { get; set; }

        public string Description { get; set; }

        public long AmountToAdjust
        {
            get { return _amountToAdjust; }
            set
            {
                if (value < 0) return;
                _amountToAdjust = value;
                Update();
            }
        }

        public long Quantity
        {
            get { return QuantityFinder(_qty, _amountToAdjust); }
            set { _qty = value; }
        }

        public long Key { get; set; }

        #region IComparable Members

        public int CompareTo(object obj)
        {
            if (!(obj is ShiftableItem)) return -1;
            if (((ShiftableItem) obj).Key == Key) return 0;
            return -1;
        }

        #endregion
    }
}