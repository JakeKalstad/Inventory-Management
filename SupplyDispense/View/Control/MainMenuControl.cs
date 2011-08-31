using System;
using System.Linq;
using System.Windows.Forms;
using SupplyDispense.Extensions;
using SupplyDispense.Model.Base;
using SupplyDispense.Model.Interface;
using SupplyDispense.Model.SheetModel;
using SupplyDispense.View.Interface;

namespace SupplyDispense.View.Control
{
    [Serializable]
    public partial class MainMenuControl : UserControl, IObservableControl
    {
        public MainMenuControl()
        {
            InitializeComponent();
        }

        #region IObservableControl Members

        public void Initialize(BaseModel _model)
        {
            var model = (IMainMenuModel) _model;
            model.ConfigurationRequest = configButton.GetClick().Select(_ => model as MainMenuModel);
            model.InventoryRequest = InventoryButton.GetClick().Select(_ => model as MainMenuModel);
            model.RemoveItemRequest = removeButton.GetClick().Select(_ => model as MainMenuModel);
            model.ReturnItem = returnButton.GetClick().Select(_ => model as MainMenuModel);
        }

        #endregion
    }
}