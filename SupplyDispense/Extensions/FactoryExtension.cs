using System;
using System.Collections.Generic;
using SupplyDispense.Factory.Interface;
using SupplyDispense.Model.SubModel;
using SupplyDispense.View.Dialog;
using SupplyDispense.View.Interface;

namespace SupplyDispense.Extensions
{
    public static class FactoryExtension
    {
        public static TD GetDisplayableItem<TD>(this IDialogFactory df, DisplayableItem di, Action<DisplayableItem> toDo)
            where TD : class, IDialog
        {
            return df.GetDialog<TD, DisplayableItem, Action<DisplayableItem>, object>(di, toDo) as TD;
        }

        public static TransactionRecorded GetTransaction(this IDialogFactory df, string titlePrefix, string location)
        {
            return
                df.GetDialog<TransactionRecorded, string, string, object>(titlePrefix, location) as TransactionRecorded;
        }

        public static PasswordReset GetPasswordReset(this IDialogFactory df, Action<string> toDo)
        {
            return df.GetDialog<PasswordReset, Action<string>, object, object>(toDo, null) as PasswordReset;
        }

        public static AddUser GetAddUser(this IDialogFactory df, IEnumerable<UserType> types, Action<DisplayUser> toDo)
        {
            return
                df.GetDialog<AddUser, DisplayUser, IEnumerable<UserType>, Action<DisplayUser>>(new DisplayUser(), types,
                                                                                               toDo) as AddUser;
        }

        public static PasswordResetWarning GetPasswordResetWarning(this IDialogFactory df, UserRowModel userRow,
                                                                   Action<UserRowModel> toDo)
        {
            return
                df.GetDialog<PasswordResetWarning, UserRowModel, Action<UserRowModel>, object>(userRow, toDo) as
                PasswordResetWarning;
        }
    }
}