using System;
using System.Linq;
using System.Windows.Forms;
using SupplyDispense.Extensions;
using SupplyDispense.Model.Interface;
using SupplyDispense.View.Interface;

namespace SupplyDispense.View.Control
{
    [Serializable]
    public partial class DefaultOptionControl : UserControl, ISupplyDispenseControl
    {
        public DefaultOptionControl()
        {
            InitializeComponent();
        }

        #region ISupplyDispenseControl Members

        public void Initialize(IObservableModel model)
        {
            model.PrintScreenRequest = model.PrintScreenRequest ?? printScreenButton.GetClick().Select(_ => model);
            model.ExitRequest = model.ExitRequest ?? exitButton.GetClick().Select(_ => model);
            model.PreviousScreenRequest = prevScreen.GetClick().Select(_ => model);
        }

        #endregion
    }
}