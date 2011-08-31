using Ninject;
using SupplyDispense.Controller.Interface;
using SupplyDispense.View.Interface;

namespace SupplyDispense.Extensions
{
    public static class KernelExtensions
    {
        public static void BindMainComponents<TController, TSheet, TModel>(this IKernel kernel, string scope)
            where TController : IController
            where TSheet : ISheet
        {
            kernel.Bind<IController>().To<TController>()
                .InSingletonScope().Named(scope);
            kernel.Bind<ISheet>().To<TSheet>()
                .WhenParentNamed(scope)
                .InSingletonScope().Named(scope);
            kernel.Bind<TModel>().ToSelf()
                .WhenParentNamed(scope)
                .InSingletonScope().Named(scope);
        }
    }
}