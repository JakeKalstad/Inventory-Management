using System.Linq;
using Domain;
using Domain.Interface;
using SupplyDispense.Enum;
using SupplyDispense.Model.Interface;
using SupplyDispense.Service.Interface;

namespace SupplyDispense.Service.Item
{
    public class SaveAssignedItem : ISaveAssignedItem
    {
        private readonly IRepository<item> _itemRepository;
        private readonly IRepository<location> _locationRepository;
        private readonly IRepository<itemlookup> _lookupRepository;
        private readonly ISave _save;

        public SaveAssignedItem(IRepository<item> itemRepository,
                                IRepository<location> locationRepository,
                                IRepository<itemlookup> lookupRepository,
                                ISave save)
        {
            _itemRepository = itemRepository;
            _locationRepository = locationRepository;
            _lookupRepository = lookupRepository;
            _save = save;
        }

        #region ISaveAssignedItem Members

        public RuleResult SaveItem(IAssignItem item)
        {
            item ditem = CreateItem(item);
            location location = CreateLocation(item.Location);
            _save.Save();
            CreateLookUp(ditem.ItemPKey, location.LocationPKey);
            _save.Save();
            return RuleResult.Success;
        }

        #endregion

        private void CreateLookUp(long itemPkey, long locationPkey)
        {
            itemlookup lookUp = _lookupRepository.Create();
            lookUp.ItemKey = itemPkey;
            lookUp.LocationKey = locationPkey;
        }

        private location CreateLocation(string location)
        {
            var loca = _locationRepository.Query()
                .FirstOrDefault(loc => loc.Name == location);
            if (loca != null) return loca;
            loca = _locationRepository.Create();
            loca.Name = location;
            return loca;
        }

        private item CreateItem(IAssignItem item)
        {
            item newItem = _itemRepository.Create();
            newItem.Description = item.Name;
            newItem.Id = item.Id;
            newItem.RestockPoint = item.RestockPoint;
            return newItem;
        }
    }
}