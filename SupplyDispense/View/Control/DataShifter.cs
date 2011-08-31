using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SupplyDispense.Extensions;
using SupplyDispense.Model.Base;
using SupplyDispense.Model.SubModel;
using SupplyDispense.View.Interface;

namespace SupplyDispense.View.Control
{
    public partial class DataShifter : UserControl, IObservableControl
    {
        private ShifterModel _model;

        public DataShifter()
        {
            InitializeComponent();
        }

        #region IObservableControl Members

        public void Initialize(BaseModel model)
        {
            _model = (ShifterModel) model;
            bindingSource1.DataSource = _model;
            actionBtn.GetClick().Subscribe(_ => _model.Handler());
            _model.ItemsAdded.Subscribe(AddToLayout);
        }

        #endregion

        private void AddToLayout(IEnumerable<ShiftableItem> items)
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.Controls.AddRange(items.Select(itm =>
                                                                 {
                                                                     var row = new ShiftableRow();
                                                                     row.Initialize(itm);
                                                                     return row;
                                                                 }).Cast<UserControl>().ToArray());
        }
    }
}