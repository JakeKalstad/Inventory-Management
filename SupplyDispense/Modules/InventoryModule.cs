using Ninject.Modules;
using SupplyDispense.Controller;
using SupplyDispense.Extensions;
using SupplyDispense.Model.SheetModel;
using SupplyDispense.View.Sheet;

namespace SupplyDispense.Modules
{
    public class InventoryModule : NinjectModule
    {
        public override void Load()
        {
            const string Scope = "Inventory";
            Kernel.BindMainComponents<InventoryLandingController, InventoryLandingSheet, InventoryLandingModel>(Scope);
        }
    }
}