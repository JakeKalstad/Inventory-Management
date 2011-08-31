using Ninject.Modules;
using SupplyDispense.Controller;
using SupplyDispense.Extensions;
using SupplyDispense.Model.SheetModel;
using SupplyDispense.View.Sheet;

namespace SupplyDispense.Modules
{
    public class UserConfigModule : NinjectModule
    {
        public override void Load()
        {
            const string scope = "UserConfiguration";
            Kernel.BindMainComponents<UserConfigController, UserConfigSheet, UserConfigModel>(scope);
        }
    }
}