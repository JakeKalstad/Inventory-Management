using Domain;
using Domain.Core;
using Domain.Interface;
using Ninject.Modules;

namespace SupplyDispense.Modules
{
    public class DomainModule : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<IDataService>().To<DataService>().InSingletonScope();
            Kernel.Bind<IRepository<user>>().To<Repository<user>>().InSingletonScope();
            Kernel.Bind<IRepository<item>>().To<Repository<item>>().InSingletonScope();
            Kernel.Bind<IRepository<usertype>>().To<Repository<usertype>>().InSingletonScope();
            Kernel.Bind<IRepository<location>>().To<Repository<location>>().InSingletonScope();
            Kernel.Bind<IRepository<restockhistory>>().To<Repository<restockhistory>>().InSingletonScope();
            Kernel.Bind<IRepository<itemlookup>>().To<Repository<itemlookup>>().InSingletonScope();
        }
    }
}