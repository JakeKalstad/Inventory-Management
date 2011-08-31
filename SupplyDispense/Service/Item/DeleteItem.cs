using System.Collections.Generic;
using System.Linq;
using Domain;
using Domain.Interface;
using SupplyDispense.Service.Interface;

namespace SupplyDispense.Service.Item
{
    public class DeleteItem : IDeleteItem
    {
        private readonly IRepository<item> _items;
        private readonly ISave _save;

        public DeleteItem(IRepository<item> items, ISave save)
        {
            _items = items;
            _save = save;
        }

        #region IDeleteItem Members

        public void Delete(long itemKey)
        {
            Delete(new List<long> {itemKey});
        }

        public void Delete(IEnumerable<long> itemKeys)
        {
            _items.Query()
                .Join(itemKeys.AsQueryable(),
                      item => item.ItemPKey, key => key,
                      (item, key) => item)
                .ToList()
                .ForEach(itm => _items.Delete(itm));
            _save.Save();
        }

        #endregion
    }
}