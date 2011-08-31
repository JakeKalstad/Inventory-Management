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
    public partial class InventoryControl : UserControl, IObservableControl
    {
        public InventoryControl()
        {
            InitializeComponent();
        }

        #region IObservableControl Members

        public void Initialize(BaseModel _model)
        {
            var model = (IInventoryLandingModel) _model;
            model.AdjustReorderPointRequest = AdjustReorderButton.GetClick().Select(_ => model as InventoryLandingModel);
            model.AssignItemRequest = AssignItemButton.GetClick().Select(_ => model as InventoryLandingModel);
            model.DeleteItemRequest = DeleteItemButton.GetClick().Select(_ => model as InventoryLandingModel);
            model.InventoryCountRequest = inventoryCountButton.GetClick().Select(_ => model as InventoryLandingModel);
            model.RestockHistoryRequest = RestockHistoryButton.GetClick().Select(_ => model as InventoryLandingModel);
            model.RestockRequest = RestockButton.GetClick().Select(_ => model as InventoryLandingModel);
            model.TransactionReportRequest =
                TransactionReportButton.GetClick().Select(_ => model as InventoryLandingModel);
        }

        #endregion
    }
}