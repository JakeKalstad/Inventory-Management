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
    public class AdjustController : BaseController
    {
        private readonly IDialogFactory _dialogFactory;
        private readonly IFetchItems _fetchItems;
        private readonly IRepository<item> _items;
        private readonly AdjustReorderModel _model;
        private readonly ISave _save;

        public AdjustController(AdjustReorderModel model,
                                ISheet sheet,
                                IRepository<item> items,
                                IFetchItems fetchItems,
                                ISave save,
                                IDialogFactory dialogFactory) : base(model, sheet)
        {
            _model = model;
            _items = items;
            _fetchItems = fetchItems;
            _save = save;
            _dialogFactory = dialogFactory;
            _model.AdjustmentRequest = PrepareAdjustment;
        }

        public override ISheet GetSheet()
        {
            _model.AdjustableItems = _fetchItems.RetrieveItems()
                .Select(itm => new ZoomableItem(itm)
                                   {
                                       ActionLabel = "Adjust Reorder Point"
                                   }).ToList();
            return base.GetSheet();
        }

        private void PrepareAdjustment(DisplayableItem di)
        {
            _dialogFactory.GetDisplayableItem<AdjustReorderPoint>(di, SaveReorderPoint).ShowDialog();
        }

        private void SaveReorderPoint(DisplayableItem obj)
        {
            item itm = _items.Query().FirstOrDefault(it => it.ItemPKey == obj.Key);
            if (itm == null) return;
            itm.RestockPoint = obj.ReorderPoint;
            _save.Save();
        }
    }
}