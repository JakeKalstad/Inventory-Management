using Ninject.Modules;
using SupplyDispense.Controller;
using SupplyDispense.Extensions;
using SupplyDispense.Model.SheetModel;
using SupplyDispense.View.Sheet;

namespace SupplyDispense.Modules
{
    public class RestockModule : NinjectModule
    {
        public override void Load()
        {
            const string restock = "Restock";
            Kernel.BindMainComponents<RestockController, RestockSheet, RestockModel>(restock);
        }
    }
}