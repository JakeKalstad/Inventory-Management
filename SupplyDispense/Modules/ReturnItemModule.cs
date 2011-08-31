using Ninject.Modules;
using SupplyDispense.Controller;
using SupplyDispense.Extensions;
using SupplyDispense.Model.SheetModel;
using SupplyDispense.View.Sheet;

namespace SupplyDispense.Modules
{
    public class ReturnItemModule : NinjectModule
    {
        public override void Load()
        {
            const string scope = "ReturnItem";
            Kernel.BindMainComponents<ReturnItemController, ReturnItemSheet, ReturnItemModel>(scope);
        }
    }
}