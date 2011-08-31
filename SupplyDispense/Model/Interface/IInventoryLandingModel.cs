using System;
using SupplyDispense.Model.SheetModel;

namespace SupplyDispense.Model.Interface
{
    public interface IInventoryLandingModel
    {
        IObservable<InventoryLandingModel> InventoryCountRequest { get; set; }
        IObservable<InventoryLandingModel> RestockRequest { get; set; }
        IObservable<InventoryLandingModel> AdjustReorderPointRequest { get; set; }
        IObservable<InventoryLandingModel> AssignItemRequest { get; set; }
        IObservable<InventoryLandingModel> TransactionReportRequest { get; set; }
        IObservable<InventoryLandingModel> RestockHistoryRequest { get; set; }
        IObservable<InventoryLandingModel> DeleteItemRequest { get; set; }
    }
}