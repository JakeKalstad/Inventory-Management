using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SupplyDispense.Model.SheetModel;
using SupplyDispense.Model.SubModel;
using SupplyDispense.View.Control;

namespace SupplyDispense.View.Sheet
{
    public partial class InventoryCountSheet : BaseSheet
    {
        private readonly InventoryCountModel _model;

        public InventoryCountSheet(InventoryCountModel model)
            : base(model)
        {
            _model = model;
            InitializeComponent();
            model.ItemsAdded.Subscribe(AddToLayout);
        }

        private void AddToLayout(List<ZoomableItem> items)
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.Controls.AddRange(items.Select(itm =>
                                                                 {
                                                                     var row = new ZoomableItemRow();
                                                                     row.Initialize(itm);
                                                                     itm.ActionRequested.Subscribe(_model.CountRequest);
                                                                     return row;
                                                                 }).Cast<UserControl>().ToArray());
        }
    }
}