using System;
using System.Windows.Forms;
using SupplyDispense.Extensions;
using SupplyDispense.Model.SubModel;
using SupplyDispense.View.Interface;

namespace SupplyDispense.View.Dialog
{
    public partial class PromptDelete : Form, IDialog
    {
        public PromptDelete(DisplayableItem di, Action<DisplayableItem> toDelete)
        {
            InitializeComponent();
            warningLbl.Text = Master.DeletePromptWarning;
            deleteBtn.GetClick().Subscribe(_ =>
                                               {
                                                   toDelete(di);
                                                   MessageBox.Show(GetSuccessText(di));
                                                   Close();
                                               });
            cancelBtn.GetClick().Subscribe(_ => Close());
        }

        private static string GetSuccessText(DisplayableItem di)
        {
            return string.Format(Master.DeleteSuccess, di.ItemDescription, di.Id);
        }
    }
}