using System;
using System.Windows.Forms;
using SupplyDispense.Extensions;
using SupplyDispense.Model.SubModel;
using SupplyDispense.View.Interface;

namespace SupplyDispense.View.Dialog
{
    public partial class PasswordResetWarning : Form, IDialog
    {
        public PasswordResetWarning(UserRowModel userRow, Action<UserRowModel> toDo)
        {
            InitializeComponent();
            label1.Text = string.Format(Master.PasswordResetWarning, userRow.UserName);
            button1.GetClick().Subscribe(_ =>
                                             {
                                                 toDo(userRow);
                                                 Close();
                                             });
            button2.GetClick().Subscribe(_ => Close());
        }
    }
}