using SupplyDispense.Model.SheetModel;

namespace SupplyDispense.View.Sheet
{
    public partial class InventoryLandingSheet : BaseSheet
    {
        public InventoryLandingSheet(InventoryLandingModel model)
            : base(model)
        {
            InitializeComponent();
            InventoryControl.Initialize(model);
        }
    }
}