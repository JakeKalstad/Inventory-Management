using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SupplyDispense.Model.SheetModel;
using SupplyDispense.Model.SubModel;
using SupplyDispense.View.Control;

namespace SupplyDispense.View.Sheet
{
    public partial class RestockHistorySheet : BaseSheet
    {
        public RestockHistorySheet(RestockHistoryModel model)
            : base(model)
        {
            InitializeComponent();
            model.ItemsAdded.Subscribe(AddToLayout);
        }

        private void AddToLayout(IEnumerable<RestockHistoryRowModel> items)
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.Controls.AddRange(items.Select(itm =>
                                                                 {
                                                                     var row = new RestockHistoryRow();
                                                                     row.Initialize(itm);
                                                                     return row;
                                                                 }).Cast<UserControl>().ToArray());
        }
    }
}