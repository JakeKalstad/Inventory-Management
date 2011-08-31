using SupplyDispense.Enum;
using SupplyDispense.Extensions;
using SupplyDispense.Model.SheetModel;

namespace SupplyDispense.View.Sheet
{
    public partial class LoginSheet : BaseSheet
    {
        public LoginSheet(LoginModel model)
            : base(model, OptionsType.None)
        {
            InitializeComponent();
            LoginControl.Initialize(model);
            this.WhenVisible(model.Clear);
        }
    }
}