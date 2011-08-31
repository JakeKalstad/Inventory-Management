using System;
using SupplyDispense.Model.Base;
using SupplyDispense.Model.Interface;

namespace SupplyDispense.Model.SheetModel
{
    public class LoginModel : BaseModel, ILoginModel
    {
        public Func<bool> Focus;
        private string _login;

        private string _password;
        public string ErrorMessage { get; set; }
        public IObservable<LoginModel> LoginRequested { get; set; }

        #region ILoginModel Members

        public string Login
        {
            get { return _login; }
            set
            {
                if (_login == value) return;
                _login = value;
            }
        }

        public string PassWord
        {
            get { return _password; }
            set
            {
                if (_password == value) return;
                _password = value;
            }
        }

        #endregion

        public bool IsValid()
        {
            return !string.IsNullOrEmpty(Login) &&
                   (string.IsNullOrEmpty(PassWord) || PassWord.Length >= 5);
        }

        public void Clear()
        {
            _password = String.Empty;
            _login = String.Empty;
            ErrorMessage = string.Empty;
            Update();
        }
    }
}