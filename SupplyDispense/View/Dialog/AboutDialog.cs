using System;
using System.Windows.Forms;
using SupplyDispense.Extensions;

namespace SupplyDispense.View.Dialog
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();
            label1.Text = string.Format(Master.About_Dialog, "Fake User");
            button1.GetClick().Subscribe(_ => Close());
        }
    }
}