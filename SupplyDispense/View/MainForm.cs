using System.Windows.Forms;
using SupplyDispense.View.Interface;

namespace SupplyDispense.View
{
    public partial class MainForm : Form, IForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region IForm Members

        public void SetTitle(string title)
        {
            Text = title;
        }

        public void SetSheet(ISheet sheet)
        {
            Controls.Clear();
            Controls.Add(sheet as UserControl);
            (Controls[0] as ISheet).ToggleControls();
            if (!Visible) Show();
            else Refresh();
        }

        #endregion
    }
}