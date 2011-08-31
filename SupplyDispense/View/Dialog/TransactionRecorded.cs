using System;
using System.Windows.Forms;
using SupplyDispense.Extensions;
using SupplyDispense.Model.SubModel;
using SupplyDispense.View.Interface;

namespace SupplyDispense.View.Dialog
{
    public partial class TransactionRecorded : Form, IDialog
    {
        public TransactionRecorded(TransactionModel model)
        {
            InitializeComponent();
            bsData.DataSource = model;
            ExitButton.GetClick().Subscribe(_ => Close());
            RecordAnother.GetClick().Subscribe(_ => Close());
        }
    }
}