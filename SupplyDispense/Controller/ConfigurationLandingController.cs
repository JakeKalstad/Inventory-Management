using System;
using System.Collections.Generic;
using System.Linq;
using Domain;
using Domain.Interface;
using SupplyDispense.Enum;
using SupplyDispense.Extensions;
using SupplyDispense.Factory.Interface;
using SupplyDispense.Model.SheetModel;
using SupplyDispense.Model.SubModel;
using SupplyDispense.Service.Interface;
using SupplyDispense.View.Dialog;
using SupplyDispense.View.Interface;

namespace SupplyDispense.Controller
{
    public class ConfigurationLandingController : BaseController
    {
        private readonly IDialogFactory _dialogs;
        private readonly ICreateUser _saveUser;
        private readonly IRepository<usertype> _types;

        public ConfigurationLandingController(ConfigurationModel model,
                                              ISheet sheet,
                                              ICreateUser saveUser,
                                              IRepository<usertype> types,
                                              IDialogFactory dialogs) : base(model, sheet)
        {
            _saveUser = saveUser;
            _types = types;
            _dialogs = dialogs;

            model.AddUserRequest.Subscribe(_ => CreateDialog(FetchTypes()).ShowDialog());
            model.UserControlPanelRequest.RequestSheet(SheetRequester, Sheets.UserConfig);
        }

        private IEnumerable<UserType> FetchTypes()
        {
            return _types.Query()
                .Select(ut => new UserType
                                  {
                                      DisplayLiteral = ut.Display,
                                      LookUpValue = ut.Key
                                  }).ToList();
        }

        private AddUser CreateDialog(IEnumerable<UserType> types)
        {
            return _dialogs.GetAddUser(types, model => _saveUser.Create(model.Name, model.Id, model.Type));
        }
    }
}