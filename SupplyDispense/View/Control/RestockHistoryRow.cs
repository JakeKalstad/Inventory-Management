using System.Windows.Forms;
using SupplyDispense.Model.Base;
using SupplyDispense.View.Interface;

namespace SupplyDispense.View.Control
{
    public partial class RestockHistoryRow : UserControl, IObservableControl
    {
        public RestockHistoryRow()
        {
            InitializeComponent();
        }

        #region IObservableControl Members

        public void Initialize(BaseModel model)
        {
            bsData.DataSource = model;
        }

        #endregion
    }
}