using System;
using System.Linq;
using System.Windows.Forms;

namespace SupplyDispense.Extensions
{
    public static class ControlExtension
    {
        public static void WhenVisible(this UserControl uc, Action toDo)
        {
            uc.GetVisibleChanged().Where(_ => uc.Visible).Subscribe(_ => toDo());
        }
    }
}