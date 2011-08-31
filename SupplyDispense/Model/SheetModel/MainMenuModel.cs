using System;
using SupplyDispense.Model.Base;
using SupplyDispense.Model.Interface;

namespace SupplyDispense.Model.SheetModel
{
    public class MainMenuModel : BaseModel, IMainMenuModel
    {
        #region IMainMenuModel Members

        public IObservable<MainMenuModel> RemoveItemRequest { get; set; }
        public IObservable<MainMenuModel> ReturnItem { get; set; }
        public IObservable<MainMenuModel> InventoryRequest { get; set; }
        public IObservable<MainMenuModel> ConfigurationRequest { get; set; }

        #endregion
    }
}