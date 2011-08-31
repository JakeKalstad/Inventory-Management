using Ninject.Modules;
using SupplyDispense.Controller;
using SupplyDispense.Extensions;
using SupplyDispense.Model.SheetModel;
using SupplyDispense.View.Sheet;

namespace SupplyDispense.Modules
{
    public class InventoryCountModule : NinjectModule
    {
        public override void Load()
        {
            const string scope = "ItemCountScope";
            Kernel.BindMainComponents<InventoryCountController, InventoryCountSheet, InventoryCountModel>(scope);
        }
    }
}