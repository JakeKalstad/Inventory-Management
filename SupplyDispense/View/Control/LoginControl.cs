using System;
using System.Linq;
using System.Windows.Forms;
using SupplyDispense.Extensions;
using SupplyDispense.Model.Base;
using SupplyDispense.Model.SheetModel;

namespace SupplyDispense.View.Control
{
    [Serializable]
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }

        public void Initialize(BaseModel _model)
        {
            var model = (LoginModel) _model;
            loginBs.DataSource = model;
            model.LoginRequested = GetLoginClicked(model)
                .Merge(GetEnterKey(model));

            LoginButton.GetClick()
                .Where(ev => !model.IsValid())
                .Subscribe(ev => label1.Text = Master.InvalidLogin);

            this.GetVisibleChanged().Where(_ => Visible).Subscribe(_ => UserNameInput.Focus());
        }

        private IObservable<LoginModel> GetEnterKey(LoginModel model)
        {
            return PasswordInput.GetKeyDown()
                .Where(key => key.EventArgs.KeyCode == Keys.Enter)
                .Where(ev => model.IsValid()).Select(ev => model);
        }

        private IObservable<LoginModel> GetLoginClicked(LoginModel model)
        {
            return LoginButton.GetClick()
                .Where(ev => model.IsValid()).Select(ev => model);
        }
    }
}