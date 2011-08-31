using SupplyDispense.Model.SheetModel;

namespace SupplyDispense.View.Sheet
{
    public partial class AssignItemSheet : BaseSheet
    {
        public AssignItemSheet(AssignItemModel model)
            : base(model)
        {
            InitializeComponent();
            assignItemControl1.Initialize(model);
        }
    }
}