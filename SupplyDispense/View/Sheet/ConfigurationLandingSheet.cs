using SupplyDispense.Model.SheetModel;

namespace SupplyDispense.View.Sheet
{
    public partial class ConfigurationLandingSheet : BaseSheet
    {
        public ConfigurationLandingSheet(ConfigurationModel model)
            : base(model)
        {
            InitializeComponent();
            MainLandingControl.Initialize(model);
        }
    }
}