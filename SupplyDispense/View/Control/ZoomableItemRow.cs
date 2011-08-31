using System.Linq;
using System.Windows.Forms;
using SupplyDispense.Extensions;
using SupplyDispense.Model.Base;
using SupplyDispense.Model.SubModel;
using SupplyDispense.View.Interface;

namespace SupplyDispense.View.Control
{
    public partial class ZoomableItemRow : UserControl, IObservableControl
    {
        public ZoomableItemRow()
        {
            InitializeComponent();
        }

        #region IObservableControl Members

        public void Initialize(BaseModel _model)
        {
            var model = (ZoomableItem) _model;
            actionBtn.Text = model.ActionLabel;
            itemRow1.Initialize(model.Display);
            model.ActionRequested = actionBtn.GetClick().Select(_ => model.Display);
        }

        #endregion
    }
}