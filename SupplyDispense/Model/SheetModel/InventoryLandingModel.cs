using System;
using SupplyDispense.Model.Base;
using SupplyDispense.Model.Interface;

namespace SupplyDispense.Model.SheetModel
{
    public class InventoryLandingModel : BaseModel, IInventoryLandingModel
    {
        #region IInventoryLandingModel Members

        public IObservable<InventoryLandingModel> InventoryCountRequest { get; set; }
        public IObservable<InventoryLandingModel> RestockRequest { get; set; }
        public IObservable<InventoryLandingModel> AdjustReorderPointRequest { get; set; }
        public IObservable<InventoryLandingModel> AssignItemRequest { get; set; }
        public IObservable<InventoryLandingModel> TransactionReportRequest { get; set; }
        public IObservable<InventoryLandingModel> RestockHistoryRequest { get; set; }
        public IObservable<InventoryLandingModel> DeleteItemRequest { get; set; }

        #endregion
    }
}