using Ninject.Modules;
using SupplyDispense.Core;
using SupplyDispense.Factory;
using SupplyDispense.Factory.Interface;
using SupplyDispense.Interface;
using SupplyDispense.Service.Core;
using SupplyDispense.Service.Interface;
using SupplyDispense.Service.Item;
using SupplyDispense.Service.Location;
using SupplyDispense.Service.Network;
using SupplyDispense.Service.RestockHistory;
using SupplyDispense.Service.Save;
using SupplyDispense.Service.User;
using SupplyDispense.View;
using SupplyDispense.View.Interface;

namespace SupplyDispense.Modules
{
    public class Core : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<ISpinner>().To<Spinner>().InSingletonScope();
            Kernel.Bind<IForm>().To<MainForm>();
            Kernel.Bind<ISave>().To<BaseSave>();
            Service();
        }

        private void Service()
        {
            Kernel.Bind<IDialogFactory>().To<DialogFactory>();
            Kernel.Bind<INetworkInfo>().To<NetworkInfo>().InSingletonScope();
            Kernel.Bind<IFetchRestockHistory>().To<FetchRestockHistory>();
            Kernel.Bind<IConnectionInfo>().To<ConnectionInfo>();
            Kernel.Bind<IPrinter>().To<Printer>();
            Kernel.Bind<ICreateUser>().To<CreateUser>();
            Kernel.Bind<IFetchUsers>().To<FetchUsers>();
            Kernel.Bind<IFetchItems>().To<FetchItems>();
            Kernel.Bind<IUpdateQuantity>().To<UpdateQuantity>();
            Kernel.Bind<IChangePassword>().To<ChangePassword>();
            Kernel.Bind<IFetchLocations>().To<FetchLocations>();
            Kernel.Bind<ISaveAssignedItem>().To<SaveAssignedItem>();
            Kernel.Bind<IDeleteItem>().To<DeleteItem>();
        }
    }
}