using Ninject;
using Ninject.Modules;

namespace SupplyDispense.Modules
{
    public class SupplyKernel : StandardKernel
    {
        public SupplyKernel() : base(new NinjectModule[]
                                         {
                                             new Core(),
                                             new LoginModule(),
                                             new MainMenuModule(),
                                             new InventoryModule(),
                                             new ConfigurationModule(),
                                             new DomainModule(),
                                             new RestockModule(),
                                             new AssignItemModule(),
                                             new AdjustModule(),
                                             new DeleteItemModule(),
                                             new UserConfigModule(),
                                             new RestockHistoryModule(),
                                             new InventoryCountModule(),
                                             new RemoveItemModule(),
                                             new ReturnItemModule(),
                                         })
        {
        }
    }
}