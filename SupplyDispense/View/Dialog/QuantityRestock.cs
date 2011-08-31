using System;
using System.Windows.Forms;
using SupplyDispense.Extensions;
using SupplyDispense.Model.SubModel;
using SupplyDispense.View.Interface;

namespace SupplyDispense.View.Dialog
{
    public partial class QuantityRestock : Form, IDialog
    {
        public QuantityRestock(DisplayableItem di, Action<DisplayableItem> onSave)
        {
            InitializeComponent();
            bsRestQty.DataSource = di;
            saveBtn.GetClick().Subscribe(_ =>
                                             {
                                                 long x;
                                                 if (!Int64.TryParse(txtQty.Text, out x)) return;
                                                 onSave(di);
                                                 Close();
                                             });
            cancelBtn.GetClick().Subscribe(_ => Close());
        }
    }
}