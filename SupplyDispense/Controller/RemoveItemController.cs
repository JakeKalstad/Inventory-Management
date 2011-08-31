using System;
using System.Linq;
using System.Windows.Forms;
using SupplyDispense.Enum;
using SupplyDispense.Extensions;
using SupplyDispense.Factory.Interface;
using SupplyDispense.Model.SheetModel;
using SupplyDispense.Service.Interface;
using SupplyDispense.View.Interface;

namespace SupplyDispense.Controller
{
    public class RemoveItemController : BaseController
    {
        private readonly IDialogFactory _dialogFactory;
        private readonly IFetchItems _fetchItems;
        private readonly RemoveItemModel _model;
        private readonly IUpdateQuantity _updateQuantity;

        public RemoveItemController(RemoveItemModel model,
                                    ISheet sheet,
                                    IFetchItems fetchItems,
                                    IUpdateQuantity updateQuantity,
                                    IDialogFactory dialogFactory) : base(model, sheet)
        {
            _model = model;
            _fetchItems = fetchItems;
            _updateQuantity = updateQuantity;
            _dialogFactory = dialogFactory;
            SetShifter();
        }

        private void SetShifter()
        {
            _model.Shifters.Title = " Remove Items ";
            _model.Shifters.Handler = SaveChanges;
            _model.Shifters.ActionDescription = "Save";
            _model.Shifters.Update();
        }

        private void SaveChanges()
        {
            if (_model.Shifters.Rows.All(si => si.AmountToAdjust == 0))
            {
                ResetItems();
                return;
            }

            _updateQuantity.Save(_model.Shifters.Rows.Select(si => new Tuple<long, long>(si.Key, si.Quantity)));
            string locations = FindLocations();
            ResetItems();
            if (_dialogFactory.GetTransaction(Master.removeItemPrefix, locations).ShowDialog() == DialogResult.OK)
                return;
            SheetRequester.OnNext(Sheets.Login);
        }

        private void ResetItems()
        {
            _model.Shifters.Rows.Clear();
            _model.Shifters.Rows = _model.Shifters.Rows;
            _model.Rows = _fetchItems.RetrieveItems().ToList();
        }

        private string FindLocations()
        {
            return _model.Rows.Join(_model.Shifters.Rows,
                                    di => di.Key, si => si.Key,
                                    (di, si) => di.Location)
                .Aggregate((s, s1) => s + " \n" + s1);
        }

        public override ISheet GetSheet()
        {
            _model.Rows = _fetchItems.RetrieveItems().ToList();
            return base.GetSheet();
        }
    }
}