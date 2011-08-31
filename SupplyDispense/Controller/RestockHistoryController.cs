using SupplyDispense.Model.SheetModel;
using SupplyDispense.Service.Interface;
using SupplyDispense.View.Interface;

namespace SupplyDispense.Controller
{
    public class RestockHistoryController : BaseController
    {
        private readonly IFetchRestockHistory _fetchHistory;
        private readonly RestockHistoryModel _model;

        public RestockHistoryController(RestockHistoryModel model,
                                        ISheet sheet,
                                        IFetchRestockHistory fetchHistory) : base(model, sheet)
        {
            _model = model;
            _fetchHistory = fetchHistory;
        }

        public override ISheet GetSheet()
        {
            _model.Rows = _fetchHistory.GetRows();
            return base.GetSheet();
        }
    }
}