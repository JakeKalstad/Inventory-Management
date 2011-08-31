using System;
using System.Windows.Forms;
using SupplyDispense.Extensions;
using SupplyDispense.Model.Base;
using SupplyDispense.Model.SubModel;
using SupplyDispense.View.Interface;

namespace SupplyDispense.View.Control
{
    public partial class ShiftableRow : UserControl, IObservableControl
    {
        public ShiftableRow()
        {
            InitializeComponent();
        }

        #region IObservableControl Members

        public void Initialize(BaseModel model)
        {
            var _model = (ShiftableItem) model;
            bsData.DataSource = _model;
            DecrementBtn.GetClick().Subscribe(_ => _model.Decrement());
            IncrementBtn.GetClick().Subscribe(_ => _model.Increment());
        }

        #endregion
    }
}