using System;
using System.Linq;
using System.Windows.Forms;
using SupplyDispense.Extensions;
using SupplyDispense.Model.Base;
using SupplyDispense.Model.SheetModel;
using SupplyDispense.View.Interface;

namespace SupplyDispense.View.Control
{
    [Serializable]
    public partial class AssignItemControl : UserControl, IObservableControl
    {
        public AssignItemControl()
        {
            InitializeComponent();
        }

        #region IObservableControl Members

        public void Initialize(BaseModel model)
        {
            var _model = model as AssignItemModel;
            if (_model == null) return;
            _model.NewLocationsLoaded.Subscribe(list =>
                                                    {
                                                        LocationCombo.Items.Clear();
                                                        LocationCombo.Items.AddRange(list.ToArray());
                                                    });
            bsAssign.DataSource = _model;
            _model.AssignRequest = assignmentButton.GetClick().Select(_ => _model);
            assignmentButton.GetClick().Subscribe(_ => txtName.Focus());
        }

        #endregion
    }
}