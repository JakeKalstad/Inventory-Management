using System.Linq;
using System.Windows.Forms;
using SupplyDispense.Extensions;
using SupplyDispense.Model.Base;
using SupplyDispense.Model.SubModel;
using SupplyDispense.View.Interface;

namespace SupplyDispense.View.Control
{
    public partial class UserRow : UserControl, IObservableControl
    {
        public UserRow()
        {
            InitializeComponent();
        }

        #region IObservableControl Members

        public void Initialize(BaseModel model)
        {
            var _model = (UserRowModel) model;
            bsUser.DataSource = _model;
            _model.ChangeAccessRequest = chgAccsBtn.GetClick().Select(_ => _model);
            _model.ResetPasswordRequest = resetPassBtn.GetClick().Select(_ => _model);
            _model.TransactionReportRequest = trsctRptBtn.GetClick().Select(_ => _model);
        }

        #endregion
    }
}