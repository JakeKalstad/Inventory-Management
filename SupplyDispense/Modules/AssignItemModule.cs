using Ninject.Modules;
using SupplyDispense.Controller;
using SupplyDispense.Extensions;
using SupplyDispense.Model.SheetModel;
using SupplyDispense.View.Sheet;

namespace SupplyDispense.Modules
{
    public class AssignItemModule : NinjectModule
    {
        public override void Load()
        {
            const string scope = "AssignItem";
            Kernel.BindMainComponents<AssignItemController, AssignItemSheet, AssignItemModel>(scope);
        }
    }
}