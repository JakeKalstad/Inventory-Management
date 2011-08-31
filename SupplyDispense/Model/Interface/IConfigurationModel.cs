using System;
using SupplyDispense.Model.SheetModel;

namespace SupplyDispense.Model.Interface
{
    public interface IConfigurationModel
    {
        IObservable<ConfigurationModel> AddUserRequest { get; set; }
        IObservable<ConfigurationModel> UserControlPanelRequest { get; set; }
        IObservable<ConfigurationModel> PrinterSetupRequest { get; set; }
        IObservable<ConfigurationModel> SystemSettingsRequest { get; set; }
        IObservable<ConfigurationModel> DeleteUserRequest { get; set; }
        IObservable<ConfigurationModel> RestartSystemRequest { get; set; }
        IObservable<ConfigurationModel> ExitApplicationRequest { get; set; }
    }
}