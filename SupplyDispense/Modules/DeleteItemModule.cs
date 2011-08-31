using Ninject.Modules;
using SupplyDispense.Controller;
using SupplyDispense.Extensions;
using SupplyDispense.Model.SheetModel;
using SupplyDispense.View.Sheet;

namespace SupplyDispense.Modules
{
    public class DeleteItemModule : NinjectModule
    {
        public override void Load()
        {
            const string scope = "DeleteItems";
            Kernel.BindMainComponents<DeleteItemController, DeleteItemSheet, DeleteItemModel>(scope);
        }
    }
}