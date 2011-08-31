using System.Linq;
using SupplyDispense.Extensions;
using SupplyDispense.Factory.Interface;
using SupplyDispense.Model.SheetModel;
using SupplyDispense.Model.SubModel;
using SupplyDispense.Service.Interface;
using SupplyDispense.View.Interface;

namespace SupplyDispense.Controller
{
    public class UserConfigController : BaseController
    {
        private readonly IDialogFactory _dialogFactory;
        private readonly UserConfigModel _model;
        private readonly IChangePassword _password;
        private readonly IFetchUsers _users;

        public UserConfigController(UserConfigModel model,
                                    ISheet sheet,
                                    IFetchUsers users,
                                    IChangePassword password,
                                    IDialogFactory dialogFactory) : base(model, sheet)
        {
            _model = model;
            _users = users;
            _password = password;
            _dialogFactory = dialogFactory;
            model.HandleTransactionReport = ReportHandler;
            model.HandlePasswordReset = ResetPasswordHandler;
            model.HandleChangeAccess = ChangeAccessHandler;
        }

        public override ISheet GetSheet()
        {
            _model.UserRows = _users.GetUsers()
                .Select(usr => new UserRowModel
                                   {
                                       UserName = usr.Name,
                                       UserKey = usr.PKey
                                   }).ToList();
            return base.GetSheet();
        }

        private void ResetPasswordHandler(UserRowModel obj)
        {
            _dialogFactory.GetPasswordResetWarning(obj, row => _password.ResetPassword(row.UserKey)).ShowDialog();
        }

        private static void ChangeAccessHandler(UserRowModel obj)
        {
        }

        private static void ReportHandler(UserRowModel obj)
        {
        }
    }
}