using Ninject.Modules;
using SupplyDispense.Controller;
using SupplyDispense.Extensions;
using SupplyDispense.Model.SheetModel;
using SupplyDispense.View.Sheet;

namespace SupplyDispense.Modules
{
    public class MainMenuModule : NinjectModule
    {
        private const string Scope = "MainMenu";

        public override void Load()
        {
            Kernel.BindMainComponents<MainMenuController, MainMenuSheet, MainMenuModel>(Scope);
        }
    }
}