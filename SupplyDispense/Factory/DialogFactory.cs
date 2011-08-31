using System;
using System.Collections.Generic;
using SupplyDispense.Factory.Interface;
using SupplyDispense.Model.SubModel;
using SupplyDispense.View.Dialog;
using SupplyDispense.View.Interface;

namespace SupplyDispense.Factory
{
    public class DialogFactory : IDialogFactory
    {
        private readonly Dictionary<Type, Func<object, object, object, IDialog>> _mappings
            = new Dictionary<Type, Func<object, object, object, IDialog>>
                  {
                      {typeof (QuantityRestock), CreateQuantityRestock},
                      {typeof (PasswordReset), CreatePasswordReset},
                      {typeof (PromptDelete), CreatePromptDelete},
                      {typeof (AdjustReorderPoint), CreateAdjustReorderPoint},
                      {typeof (AddUser), CreateAddUser},
                      {typeof (PasswordResetWarning), CreatePasswordResetWarning},
                      {typeof (ItemCount), CreateItemCount},
                      {typeof (TransactionRecorded), CreateTransactionRecorded},
                  };

        #region IDialogFactory Members

        public IDialog GetDialog<TD, TX, TY, TZ>(TX x, TY y, TZ z = default(TZ)) where TD : IDialog
        {
            return _mappings[typeof (TD)](x, y, z);
        }

        #endregion

        private static IDialog CreateTransactionRecorded(object arg1, object arg2, object arg3)
        {
            return new TransactionRecorded(new TransactionModel
                                               {
                                                   TitleDescription =
                                                       string.Format(Master.TransactionRecordedDialog_, arg1),
                                                   ItemLocation = (string) arg2
                                               });
        }

        private static IDialog CreatePasswordResetWarning(object arg1, object arg2, object arg3)
        {
            return new PasswordResetWarning((UserRowModel) arg1, (Action<UserRowModel>) arg2);
        }

        private static IDialog CreateAddUser(object arg1, object arg2, object arg3)
        {
            return new AddUser((DisplayUser) arg1, (IEnumerable<UserType>) arg2, (Action<DisplayUser>) arg3);
        }

        private static IDialog CreateAdjustReorderPoint(object arg1, object arg2, object arg3)
        {
            return new AdjustReorderPoint((DisplayableItem) arg1, (Action<DisplayableItem>) arg2);
        }

        private static IDialog CreatePromptDelete(object arg1, object arg2, object arg3)
        {
            return new PromptDelete((DisplayableItem) arg1, (Action<DisplayableItem>) arg2);
        }

        private static IDialog CreateItemCount(object arg1, object arg2, object arg3)
        {
            return new ItemCount((DisplayableItem) arg1, (Action<DisplayableItem>) arg2);
        }

        private static IDialog CreatePasswordReset(object arg1, object arg2, object arg3)
        {
            return new PasswordReset((Action<string>) arg1);
        }

        private static IDialog CreateQuantityRestock(object displayItem, object arg2, object arg3)
        {
            return new QuantityRestock((DisplayableItem) displayItem, (Action<DisplayableItem>) arg2);
        }
    }
}