using System;
using System.Linq;
using System.Windows.Forms;
using SupplyDispense.Extensions;
using SupplyDispense.Model.Interface;
using SupplyDispense.View.Interface;

namespace SupplyDispense.View.Control
{
    [Serializable]
    public partial class PrintScreenOnly : UserControl, ISupplyDispenseControl
    {
        public PrintScreenOnly()
        {
            InitializeComponent();
        }

        #region ISupplyDispenseControl Members

        public void Initialize(IObservableModel model)
        {
            model.ExitRequest = ExitButon.GetClick().Select(_ => model);
            model.PrintScreenRequest = printScreenButton.GetClick().Select(_ => model);
        }

        #endregion
    }
}