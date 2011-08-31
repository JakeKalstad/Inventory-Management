using Ninject.Modules;
using SupplyDispense.Controller;
using SupplyDispense.Extensions;
using SupplyDispense.Model.SheetModel;
using SupplyDispense.Service.Authenticate;
using SupplyDispense.Service.Interface;
using SupplyDispense.View.Sheet;

namespace SupplyDispense.Modules
{
    public class LoginModule : NinjectModule
    {
        private const string Scope = "Login";

        public override void Load()
        {
            Kernel.BindMainComponents<LoginController, LoginSheet, LoginModel>(Scope);
            BindServices();
        }

        private void BindServices()
        {
            Kernel.Bind<IAuthenticate>().To<Authenticate>();
        }
    }
}