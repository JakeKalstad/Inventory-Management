using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SupplyDispense.Model.SheetModel;
using SupplyDispense.Model.SubModel;
using SupplyDispense.View.Control;

namespace SupplyDispense.View.Sheet
{
    public partial class DeleteItemSheet : BaseSheet
    {
        private readonly DeleteItemModel _model;

        public DeleteItemSheet(DeleteItemModel model)
            : base(model)
        {
            _model = model;
            InitializeComponent();
            _model.ItemsAdded.Subscribe(AddToLayout);
        }

        private void AddToLayout(IEnumerable<ZoomableItem> items)
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.Controls.AddRange(items.Select(itm =>
                                                                 {
                                                                     var row = new ZoomableItemRow();
                                                                     row.Initialize(itm);
                                                                     itm.ActionRequested.Subscribe(_model.DeleteRequest);
                                                                     return row;
                                                                 }).Cast<UserControl>().ToArray());
        }
    }
}