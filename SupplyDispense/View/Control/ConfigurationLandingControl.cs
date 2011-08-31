using System;
using System.Linq;
using System.Windows.Forms;
using SupplyDispense.Extensions;
using SupplyDispense.Model.Base;
using SupplyDispense.Model.Interface;
using SupplyDispense.Model.SheetModel;
using SupplyDispense.View.Interface;

namespace SupplyDispense.View.Control
{
    [Serializable]
    public partial class ConfigurationLandingControl : UserControl, IObservableControl
    {
        public ConfigurationLandingControl()
        {
            InitializeComponent();
        }

        #region IObservableControl Members

        public void Initialize(BaseModel _model)
        {
            var model = (IConfigurationModel) _model;
            model.AddUserRequest = addUserButton.GetClick().Select(_ => model as ConfigurationModel);
            model.DeleteUserRequest = DeleteUserButton.GetClick().Select(_ => model as ConfigurationModel);
            model.ExitApplicationRequest = ExitAppButton.GetClick().Select(_ => model as ConfigurationModel);
            model.PrinterSetupRequest = PrinterButton.GetClick().Select(_ => model as ConfigurationModel);
            model.RestartSystemRequest = rebootButton.GetClick().Select(_ => model as ConfigurationModel);
            model.SystemSettingsRequest = SystemSettingsButton.GetClick().Select(_ => model as ConfigurationModel);
            model.UserControlPanelRequest = userControlButton.GetClick().Select(_ => model as ConfigurationModel);
        }

        #endregion
    }
}