using System;
using System.Collections.Generic;
using System.Linq;
using SupplyDispense.Controller;
using SupplyDispense.Controller.Interface;
using SupplyDispense.Enum;
using SupplyDispense.Interface;
using SupplyDispense.Model.Interface;
using SupplyDispense.Service.Interface;
using SupplyDispense.View.Interface;

namespace SupplyDispense.Core
{
    public class Spinner : ISpinner
    {
        private readonly IConnectionInfo _connectionInfo;
        private readonly List<IController> _controllers;
        private readonly IForm _mainForm;
        private readonly SheetMap _map;
        private readonly IPrinter _printer;
        private IController _currentController;
        private IController _previousController;

        public Spinner(List<IController> controller, SheetMap map, IConnectionInfo connectionInfo, IPrinter printer,
                       IForm form)
        {
            _mainForm = form;
            _connectionInfo = connectionInfo;
            _controllers = controller;
            _map = map;
            _printer = printer;
            _controllers.ForEach(
                ctrl =>
                ctrl.SheetRequest.Subscribe(
                    wnd => CurrentController = _controllers.FirstOrDefault(_map.GetControllerPredicate(wnd))));
            _controllers.ForEach(ctrl => WireUpModels(ctrl.GetCoreEventModel()));
        }

        private IController CurrentController
        {
            set
            {
                if (value == null) return;
                _previousController = _currentController;
                _currentController = value;
                _mainForm.SetSheet(_currentController.GetSheet());
            }
        }

        #region ISpinner Members

        public void Initialize()
        {
            CurrentController = _controllers.FirstOrDefault(_map.GetControllerPredicate(Sheets.Login));
        }

        #endregion

        private void WireUpModels(IObservableModel coreEventModel)
        {
            coreEventModel.Listen(om => _connectionInfo.ShowInfo(),
                                  om => CurrentController = _controllers.FirstOrDefault(typ => typ is LoginController),
                                  om => _printer.Print(),
                                  om => CurrentController = _previousController,
                                  om =>
                                  CurrentController = _controllers.FirstOrDefault(typ => typ is MainMenuController));
        }
    }
}