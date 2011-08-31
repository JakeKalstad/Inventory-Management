using System;
using System.Collections.Generic;
using System.Linq;
using Domain;
using Domain.Interface;
using SupplyDispense.Service.Interface;

namespace SupplyDispense.Service.Item
{
    public class UpdateQuantity : IUpdateQuantity
    {
        private readonly IRepository<item> _items;
        private readonly ISave _save;

        public UpdateQuantity(IRepository<item> items, ISave save)
        {
            _items = items;
            _save = save;
        }

        #region IUpdateQuantity Members

        public void Save(long itemKey, long quantity)
        {
            item item = _items.Query().FirstOrDefault(itm => itm.ItemPKey == itemKey);
            if (item == null) return;
            item.Quantity = quantity;
            _save.Save();
        }

        public void Save(IEnumerable<Tuple<long, long>> itemsKeyQuantity)
        {
            _items.Query()
                .Join(itemsKeyQuantity,
                      itm => itm.ItemPKey, key => key.Item1,
                      (itm, key) => itm.Quantity = key.Item2)
                .ToList();
            _save.Save();
        }

        #endregion
    }
}