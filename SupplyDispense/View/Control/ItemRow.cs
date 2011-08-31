using System;
using System.Windows.Forms;
using SupplyDispense.Extensions;
using SupplyDispense.Model.Base;
using SupplyDispense.Model.SubModel;
using SupplyDispense.View.Interface;

namespace SupplyDispense.View.Control
{
    [Serializable]
    public partial class ItemRow : UserControl, IObservableControl
    {
        public ItemRow()
        {
            InitializeComponent();
        }

        #region IObservableControl Members

        public void Initialize(BaseModel _model)
        {
            var model = (DisplayableItem) _model;
            bsSource.DataSource = model;
            this.GetClick().Subscribe(_ => model.Clicked(model));
        }

        #endregion
    }
}