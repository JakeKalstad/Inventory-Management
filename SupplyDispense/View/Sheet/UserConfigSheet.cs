using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SupplyDispense.Model.SheetModel;
using SupplyDispense.Model.SubModel;
using SupplyDispense.View.Control;

namespace SupplyDispense.View.Sheet
{
    public partial class UserConfigSheet : BaseSheet
    {
        private readonly UserConfigModel _model;

        public UserConfigSheet(UserConfigModel model)
            : base(model)
        {
            _model = model;
            InitializeComponent();
            model.ItemsAdded.Subscribe(AddToLayout);
        }

        private void AddToLayout(IEnumerable<UserRowModel> items)
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.Controls.AddRange(items.Select(itm =>
                                                                 {
                                                                     var row = new UserRow();
                                                                     row.Initialize(itm);
                                                                     itm.ChangeAccessRequest.Subscribe(
                                                                         _model.HandleChangeAccess);
                                                                     itm.ResetPasswordRequest.Subscribe(
                                                                         _model.HandlePasswordReset);
                                                                     itm.TransactionReportRequest.Subscribe(
                                                                         _model.HandleTransactionReport);
                                                                     return row;
                                                                 }).Cast<UserControl>().ToArray());
        }
    }
}