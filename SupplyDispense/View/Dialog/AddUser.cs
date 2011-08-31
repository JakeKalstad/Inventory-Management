using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SupplyDispense.Extensions;
using SupplyDispense.Model.SubModel;
using SupplyDispense.View.Interface;

namespace SupplyDispense.View.Dialog
{
    public partial class AddUser : Form, IDialog
    {
        public AddUser(DisplayUser user, IEnumerable<UserType> userTypes, Action<DisplayUser> onSave)
        {
            InitializeComponent();
            bsUser.DataSource = user;
            userTypeLue.DataSource = userTypes.Select(ut => ut.DisplayLiteral).ToList();
            createBtn.GetClick().Subscribe(_ =>
                                               {
                                                   onSave(user);
                                                   Close();
                                               });
            cancelBtn.GetClick().Subscribe(_ => Close());
        }
    }
}