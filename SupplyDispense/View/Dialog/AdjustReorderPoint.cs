using System;
using System.Windows.Forms;
using SupplyDispense.Extensions;
using SupplyDispense.Model.SubModel;
using SupplyDispense.View.Interface;

namespace SupplyDispense.View.Dialog
{
    public partial class AdjustReorderPoint : Form, IDialog
    {
        public AdjustReorderPoint(DisplayableItem di, Action<DisplayableItem> toSave)
        {
            InitializeComponent();
            var model = new AdjustModel {item = di, Newpoint = ""};
            bsdata.DataSource = model;
            bsData2.DataSource = model.item;
            saveBtn.GetClick().Subscribe(_ =>
                                             {
                                                 di.ReorderPoint = model.Newpoint;
                                                 toSave(di);
                                             });
        }
    }

    public class AdjustModel
    {
        public DisplayableItem item { get; set; }
        public string Newpoint { get; set; }
    }
}