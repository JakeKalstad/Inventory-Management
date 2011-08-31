using System;
using System.Collections.Generic;
using SupplyDispense.Controller;
using SupplyDispense.Controller.Interface;
using SupplyDispense.Enum;

namespace SupplyDispense.Core
{
    public class SheetMap
    {
        private readonly Dictionary<Sheets, Func<IController, bool>> _internalMap;

        public SheetMap()
        {
            _internalMap = new Dictionary<Sheets, Func<IController, bool>>
                               {
                                   {Sheets.Login, ctrl => ctrl.GetType() == typeof (LoginController)},
                                   {Sheets.MainMenu, ctrl => ctrl.GetType() == typeof (MainMenuController)},
                                   {
                                       Sheets.InventoryLanding,
                                       ctrl => ctrl.GetType() == typeof (InventoryLandingController)
                                       },
                                   {
                                       Sheets.ConfigurationLanding,
                                       ctrl => ctrl.GetType() == typeof (ConfigurationLandingController)
                                       },
                                   {Sheets.Restock, ctrl => ctrl.GetType() == typeof (RestockController)},
                                   {Sheets.AssignItem, ctrl => ctrl.GetType() == typeof (AssignItemController)},
                                   {Sheets.AdjustReorder, ctrl => ctrl.GetType() == typeof (AdjustController)},
                                   {Sheets.DeleteItem, ctrl => ctrl.GetType() == typeof (DeleteItemController)},
                                   {Sheets.UserConfig, ctrl => ctrl.GetType() == typeof (UserConfigController)},
                                   {Sheets.RestockHistory, ctrl => ctrl.GetType() == typeof (RestockHistoryController)},
                                   {Sheets.InventoryCount, ctrl => ctrl.GetType() == typeof (InventoryCountController)},
                                   {Sheets.RemoveItemLanding, ctrl => ctrl.GetType() == typeof (RemoveItemController)},
                                   {Sheets.ReturnItemLanding, ctrl => ctrl.GetType() == typeof (ReturnItemController)},
                               };
        }

        public Func<IController, bool> GetControllerPredicate(Sheets sheet)
        {
            Func<IController, bool> temp;
            return !_internalMap.TryGetValue(sheet, out temp)
                       ? (ctrl => false)
                       : temp;
        }
    }
}