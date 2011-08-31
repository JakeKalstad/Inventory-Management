using Ninject.Modules;
using SupplyDispense.Controller;
using SupplyDispense.Extensions;
using SupplyDispense.Model.SheetModel;
using SupplyDispense.View.Sheet;

namespace SupplyDispense.Modules
{
    public class ConfigurationModule : NinjectModule
    {
        public override void Load()
        {
            const string Scope = "Configuration";
            Kernel.BindMainComponents<ConfigurationLandingController, ConfigurationLandingSheet, ConfigurationModel>(
                Scope);
        }
    }
}