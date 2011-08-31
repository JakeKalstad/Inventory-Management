using SupplyDispense.Enum;
using SupplyDispense.Model.SheetModel;

namespace SupplyDispense.View.Sheet
{
    public partial class MainMenuSheet : BaseSheet
    {
        public MainMenuSheet(MainMenuModel model)
            : base(model, OptionsType.Printer)
        {
            InitializeComponent();
            menuBar.Initialize(model);
        }
    }
}