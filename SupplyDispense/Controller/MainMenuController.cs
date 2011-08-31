using SupplyDispense.Enum;
using SupplyDispense.Extensions;
using SupplyDispense.Model.SheetModel;
using SupplyDispense.View.Interface;

namespace SupplyDispense.Controller
{
    public class MainMenuController : BaseController
    {
        public MainMenuController(MainMenuModel model, ISheet menuSheet) : base(model, menuSheet)
        {
            model.ReturnItem.RequestSheet(SheetRequester, Sheets.ReturnItemLanding);
            model.RemoveItemRequest.RequestSheet(SheetRequester, Sheets.RemoveItemLanding);
            model.InventoryRequest.RequestSheet(SheetRequester, Sheets.InventoryLanding);
            model.ConfigurationRequest.RequestSheet(SheetRequester, Sheets.ConfigurationLanding);
        }
    }
}