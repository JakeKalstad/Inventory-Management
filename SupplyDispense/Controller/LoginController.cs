using System;
using SupplyDispense.Controller.Interface;
using SupplyDispense.Enum;
using SupplyDispense.Extensions;
using SupplyDispense.Factory.Interface;
using SupplyDispense.Model.SheetModel;
using SupplyDispense.Service.Interface;
using SupplyDispense.Service.User;
using SupplyDispense.View.Interface;

namespace SupplyDispense.Controller
{
    public class LoginController : BaseController
    {
        private readonly IAuthenticate _authenticate;
        private readonly IChangePassword _changePassword;
        private readonly IDialogFactory _dialogFactory;
        private readonly LoginModel _loginModel;
        private readonly UserRoles _roles;

        public LoginController(LoginModel loginModel,
                               IAuthenticate authenticate,
                               IChangePassword changePassword,
                               UserRoles roles,
                               ISheet loginSheet,
                               IDialogFactory dialogFactory)
            : base(loginModel, loginSheet)
        {
            _loginModel = loginModel;
            _authenticate = authenticate;
            _changePassword = changePassword;
            _roles = roles;
            _dialogFactory = dialogFactory;
            _roles.CheckForAdmin();
            _loginModel.LoginRequested.Subscribe(lm => HandleLogin(lm));
        }

        private IController HandleLogin(LoginModel lm)
        {
            if (_roles.NeedsReset(lm.Login)) PromptReset();
            return _authenticate.IsAuthenticated(lm) == RuleResult.Fail
                       ? TriggerErrorMessage(lm)
                       : TriggerWindowChange(Sheets.MainMenu);
        }

        private void PromptReset()
        {
            Action<string> onComplete =
                pass => _changePassword.ResetPassword(_loginModel.Login, pass);

            _dialogFactory
                .GetPasswordReset(onComplete)
                .ShowDialog();
        }

        private IController TriggerWindowChange(Sheets trigger)
        {
            SheetRequester.OnNext(trigger);
            return this;
        }

        private IController TriggerErrorMessage(LoginModel lm)
        {
            lm.ErrorMessage = Master.AuthenticationFailure;
            lm.Update();
            return this;
        }
    }
}