using Ninject.Modules;
using SupplyDispense.Controller;
using SupplyDispense.Extensions;
using SupplyDispense.Model.SheetModel;
using SupplyDispense.View.Sheet;

namespace SupplyDispense.Modules
{
    public class RemoveItemModule : NinjectModule
    {
        public override void Load()
        {
            const string scope = "RemoveItemScope";
            Kernel.BindMainComponents<RemoveItemController, RemoveItemSheet, RemoveItemModel>(scope);
        }
    }
}