using System;
using System.Linq;
using Domain;
using Domain.Interface;
using SupplyDispense.Extensions;
using SupplyDispense.Factory.Interface;
using SupplyDispense.Model.SheetModel;
using SupplyDispense.Model.SubModel;
using SupplyDispense.Service.Interface;
using SupplyDispense.View.Dialog;
using SupplyDispense.View.Interface;

namespace SupplyDispense.Controller
{
    public class RestockController : BaseController
    {
        private readonly IDialogFactory _dialogFactory;
        private readonly IFetchItems _fetchItems;
        private readonly RestockModel _model;
        private readonly IRepository<restockhistory> _restock;
        private readonly IUpdateQuantity _update;

        public RestockController(RestockModel model,
                                 ISheet sheet,
                                 IFetchItems fetchItems,
                                 IUpdateQuantity update,
                                 IRepository<restockhistory> restock,
                                 IDialogFactory dialogFactory) : base(model, sheet)
        {
            _model = model;
            _fetchItems = fetchItems;
            _update = update;
            _restock = restock;
            _dialogFactory = dialogFactory;
            _model.QuantityRequest = RequestForQuantity;
        }

        public override ISheet GetSheet()
        {
            _model.RestockableItems = _fetchItems.RetrieveItems()
                .Select(itm => new ZoomableItem(itm)
                                   {
                                       ActionLabel = "Edit Quantity"
                                   })
                .ToList();
            return base.GetSheet();
        }

        private void RequestForQuantity(DisplayableItem di)
        {
            _dialogFactory
                .GetDisplayableItem<QuantityRestock>(di, SaveQuantity)
                .ShowDialog();
        }

        // Order is important for speed
        // Creating the Restock history, and THEN calling _update.Save
        // saves entities at once.
        //TODO: Refactor me into a fanciful service
        private void SaveQuantity(DisplayableItem obj)
        {
            restockhistory restock = _restock.Create();
            restock.PointName = obj.ReorderPoint;
            restock.UserKey = CurrentUser.CurrentClient.PKey;
            restock.StockDate = DateTime.Now;
            _update.Save(obj.Key, obj.Quantity);
            obj.Update();
        }
    }
}