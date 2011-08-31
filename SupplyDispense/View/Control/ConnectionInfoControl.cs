using System;
using System.Linq;
using System.Windows.Forms;
using SupplyDispense.Extensions;
using SupplyDispense.Model.Interface;
using SupplyDispense.View.Interface;

namespace SupplyDispense.View.Control
{
    [Serializable]
    public partial class ConnectionInfoControl : UserControl, ISupplyDispenseControl
    {
        public ConnectionInfoControl()
        {
            InitializeComponent();
        }

        #region ISupplyDispenseControl Members

        public void Initialize(IObservableModel model)
        {
            model.ConnectionInfoRequest = ConnectionInformation.GetClick().Select(ev => model);
        }

        #endregion
    }
}