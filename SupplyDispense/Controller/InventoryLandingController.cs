using SupplyDispense.Enum;
using SupplyDispense.Extensions;
using SupplyDispense.Model.SheetModel;
using SupplyDispense.View.Interface;

namespace SupplyDispense.Controller
{
    public class InventoryLandingController : BaseController
    {
        public InventoryLandingController(ISheet inventoryLanding, InventoryLandingModel model)
            : base(model, inventoryLanding)
        {
            model.AdjustReorderPointRequest.RequestSheet(SheetRequester, Sheets.AdjustReorder);
            model.AssignItemRequest.RequestSheet(SheetRequester, Sheets.AssignItem);
            model.DeleteItemRequest.RequestSheet(SheetRequester, Sheets.DeleteItem);
            model.InventoryCountRequest.RequestSheet(SheetRequester, Sheets.InventoryCount);
            model.RestockHistoryRequest.RequestSheet(SheetRequester, Sheets.RestockHistory);
            model.RestockRequest.RequestSheet(SheetRequester, Sheets.Restock);
            model.TransactionReportRequest.RequestSheet(SheetRequester, Sheets.TransactionReport);
        }
    }
}