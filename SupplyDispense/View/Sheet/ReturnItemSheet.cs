using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SupplyDispense.Model.SheetModel;
using SupplyDispense.Model.SubModel;
using SupplyDispense.View.Control;

namespace SupplyDispense.View.Sheet
{
    public partial class ReturnItemSheet : BaseSheet
    {
        private readonly ReturnItemModel _model;

        public ReturnItemSheet(ReturnItemModel model)
            : base(model)
        {
            _model = model;
            InitializeComponent();
            dataShifter1.Initialize(model.Shifters);
            model.RowsAdded.Subscribe(RowsAdded);
        }

        private void RowsAdded(List<DisplayableItem> displayableItems)
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.Controls.AddRange(displayableItems.Select(itm =>
                                                                            {
                                                                                itm.Clicked = HandleClick;
                                                                                var row = new ItemRow();
                                                                                row.Initialize(itm);
                                                                                return row;
                                                                            }).Cast<UserControl>().ToArray());
        }

        private void HandleClick(DisplayableItem obj)
        {
            var newRows = new List<ShiftableItem>
                              {
                                  new ShiftableItem
                                      {
                                          Description = obj.ItemDescription,
                                          Quantity = obj.Quantity,
                                          Key = obj.Key,
                                          QuantityFinder = (o, v) => o + v
                                      }
                              };
            newRows.AddRange(ShiftableItems(newRows));
            _model.Shifters.Rows = newRows.ToList();
        }

        private IEnumerable<ShiftableItem> ShiftableItems(IEnumerable<ShiftableItem> newRows)
        {
            return _model.Shifters.Rows
                .Where(si => !newRows.Select(shi => shi.Key)
                                  .Contains(si.Key));
        }
    }
}