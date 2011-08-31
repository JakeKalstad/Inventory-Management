using Ninject.Modules;
using SupplyDispense.Controller;
using SupplyDispense.Extensions;
using SupplyDispense.Model.SheetModel;
using SupplyDispense.View.Sheet;

namespace SupplyDispense.Modules
{
    internal class AdjustModule : NinjectModule
    {
        public override void Load()
        {
            const string scope = "Adjust";
            Kernel.BindMainComponents<AdjustController, AdjustReorder, AdjustReorderModel>(scope);
        }
    }
}