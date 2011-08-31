using SupplyDispense.View.Interface;

namespace SupplyDispense.Factory.Interface
{
    public interface IDialogFactory
    {
        IDialog GetDialog<TD, TX, TY, TZ>(TX x, TY y, TZ z = default(TZ)) where TD : IDialog;
    }
}