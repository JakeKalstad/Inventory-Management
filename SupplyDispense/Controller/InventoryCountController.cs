using System.Linq;
using SupplyDispense.Extensions;
using SupplyDispense.Factory.Interface;
using SupplyDispense.Model.SheetModel;
using SupplyDispense.Model.SubModel;
using SupplyDispense.Service.Interface;
using SupplyDispense.View.Dialog;
using SupplyDispense.View.Interface;

namespace SupplyDispense.Controller
{
    public class InventoryCountController : BaseController
    {
        private readonly IDialogFactory _dialogFactory;
        private readonly IFetchItems _fetchItems;
        private readonly InventoryCountModel _model;
        private readonly IUpdateQuantity _updateQuantity;

        public InventoryCountController(InventoryCountModel model,
                                        ISheet sheet,
                                        IDialogFactory dialogFactory,
                                        IUpdateQuantity updateQuantity,
                                        IFetchItems fetchItems)
            : base(model, sheet)
        {
            _model = model;
            _dialogFactory = dialogFactory;
            _updateQuantity = updateQuantity;
            _fetchItems = fetchItems;
            model.CountRequest = CountHandler;
        }

        public override ISheet GetSheet()
        {
            _model.CountableItems = _fetchItems.RetrieveItems()
                .Select(itm => new ZoomableItem(itm)
                                   {
                                       ActionLabel = "Edit Quantity"
                                   })
                .ToList();
            return base.GetSheet();
        }

        private void CountHandler(DisplayableItem di)
        {
            _dialogFactory
                .GetDisplayableItem<ItemCount>(di, obj => _updateQuantity.Save(obj.Key, obj.Quantity))
                .ShowDialog();
            di.Update();
        }
    }
}