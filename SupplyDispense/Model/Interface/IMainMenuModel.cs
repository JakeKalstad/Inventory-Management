using System;
using SupplyDispense.Model.SheetModel;

namespace SupplyDispense.Model.Interface
{
    public interface IMainMenuModel
    {
        IObservable<MainMenuModel> RemoveItemRequest { get; set; }
        IObservable<MainMenuModel> ReturnItem { get; set; }
        IObservable<MainMenuModel> InventoryRequest { get; set; }
        IObservable<MainMenuModel> ConfigurationRequest { get; set; }
    }
}