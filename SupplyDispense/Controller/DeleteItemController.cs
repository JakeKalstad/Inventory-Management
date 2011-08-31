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
    public class DeleteItemController : BaseController
    {
        private readonly IDeleteItem _delete;
        private readonly IDialogFactory _dialog;
        private readonly IFetchItems _fetchItems;
        private readonly DeleteItemModel _model;

        public DeleteItemController(DeleteItemModel model,
                                    ISheet sheet,
                                    IFetchItems fetchItems,
                                    IDeleteItem delete,
                                    IDialogFactory dialog)
            : base(model, sheet)
        {
            _model = model;
            _fetchItems = fetchItems;
            _delete = delete;
            _dialog = dialog;
            _model.DeleteRequest = di => _dialog.GetDisplayableItem<PromptDelete>(di, Delete).ShowDialog();
        }

        private void Delete(DisplayableItem di)
        {
            _delete.Delete(di.Key);
            _model.DeletableItems = _model.DeletableItems
                .Where(zi => zi.Display.Key != di.Key)
                .ToList();
        }

        public override ISheet GetSheet()
        {
            _model.DeletableItems = _fetchItems.RetrieveItems()
                .Select(itm =>
                            {
                                var item = new ZoomableItem(itm)
                                               {ActionLabel = "Delete Item"};
                                return item;
                            }).ToList();
            return base.GetSheet();
        }
    }
}