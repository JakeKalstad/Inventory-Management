using System;
using SupplyDispense.Model.Base;
using SupplyDispense.Model.Interface;

namespace SupplyDispense.Model.SheetModel
{
    public class ConfigurationModel : BaseModel, IConfigurationModel
    {
        #region IConfigurationModel Members

        public IObservable<ConfigurationModel> AddUserRequest { get; set; }
        public IObservable<ConfigurationModel> UserControlPanelRequest { get; set; }
        public IObservable<ConfigurationModel> PrinterSetupRequest { get; set; }
        public IObservable<ConfigurationModel> SystemSettingsRequest { get; set; }
        public IObservable<ConfigurationModel> DeleteUserRequest { get; set; }
        public IObservable<ConfigurationModel> RestartSystemRequest { get; set; }
        public IObservable<ConfigurationModel> ExitApplicationRequest { get; set; }

        #endregion
    }
}