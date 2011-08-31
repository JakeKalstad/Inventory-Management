using System;
using System.Collections.Generic;
using System.Linq;
using Domain;
using Domain.Interface;
using SupplyDispense.Model.SubModel;
using SupplyDispense.Service.Interface;

namespace SupplyDispense.Service.Item
{
    public class FetchItems : IFetchItems
    {
        private readonly IRepository<item> _itemRepository;
        private readonly IRepository<location> _locationRepository;
        private readonly IRepository<itemlookup> _lookUp;

        public FetchItems(IRepository<item> itemRepository, IRepository<itemlookup> lookUp,
                          IRepository<location> locationRepository)
        {
            _itemRepository = itemRepository;
            _lookUp = lookUp;
            _locationRepository = locationRepository;
        }

        #region IFetchItems Members

        public IEnumerable<DisplayableItem> RetrieveItems(Func<item, bool> predicate = null)
        {
            return _itemRepository.Query()
                .Where(predicate ?? (_ => true))
                .OrderBy(it => it.Id)
                .Select((itm, sd) => new DisplayableItem(itm.ItemPKey)
                                         {
                                             Id = itm.Id,
                                             ItemNumber = sd,
                                             Location = _lookUp.Query()
                                                 .Where(il => il.ItemKey == itm.ItemPKey)
                                                 .Select(im => im.LocationKey)
                                                 .Join(_locationRepository.Query(),
                                                       luKey => luKey, loc => loc.LocationPKey,
                                                       (luKey, loc) => loc.Name).FirstOrDefault(),
                                             Quantity = itm.Quantity,
                                             ItemDescription = itm.Description,
                                             ReorderPoint = itm.RestockPoint
                                         });
        }

        #endregion
    }
}