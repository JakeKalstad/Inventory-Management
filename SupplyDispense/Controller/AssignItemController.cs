using System;
using System.Linq;
using System.Windows.Forms;
using SupplyDispense.Enum;
using SupplyDispense.Model.Base;
using SupplyDispense.Model.Interface;
using SupplyDispense.Model.SheetModel;
using SupplyDispense.Service.Interface;
using SupplyDispense.View.Interface;

namespace SupplyDispense.Controller
{
    public class AssignItemController : BaseController
    {
        private readonly IFetchLocations _fetchLocations;
        private readonly AssignItemModel _model;
        private readonly ISaveAssignedItem _saveAssignment;

        public AssignItemController(AssignItemModel model,
                                    ISheet sheet,
                                    ISaveAssignedItem saveAssignment,
                                    IFetchLocations fetchLocations) : base(model, sheet)
        {
            _model = model;
            _saveAssignment = saveAssignment;
            _fetchLocations = fetchLocations;

            model.AssignRequest.Subscribe(SaveAssignment);
        }

        public override ISheet GetSheet()
        {
            RefreshLocations();
            return base.GetSheet();
        }

        private void RefreshLocations()
        {
            _model.Locations = _fetchLocations.Fetch()
                .Select(loc => loc.Name)
                .ToList();
        }

        private void SaveAssignment(IAssignItem am)
        {
            RuleResult result = _saveAssignment.SaveItem(am);
            if (result == RuleResult.Success)
            {
                MessageBox.Show(am.Name + Master.ItemSuccessfullyAdded, Master.SuccessItemCaption, MessageBoxButtons.OK);
                am.Clear();
                RefreshLocations();
            }
            if (am is BaseModel) (am as BaseModel).Update();
        }
    }
}