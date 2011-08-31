using Ninject.Modules;
using SupplyDispense.Controller;
using SupplyDispense.Extensions;
using SupplyDispense.Model.SheetModel;
using SupplyDispense.View.Sheet;

namespace SupplyDispense.Modules
{
    public class RestockHistoryModule : NinjectModule
    {
        public override void Load()
        {
            const string restockHistory = "restock History";
            Kernel.BindMainComponents<RestockHistoryController, RestockHistorySheet, RestockHistoryModel>(restockHistory);
        }
    }
}