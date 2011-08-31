using System;
using System.Windows.Forms;
using SupplyDispense.Modules;
using SupplyDispense.View;

namespace SupplyDispense
{
    public class MainApp
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Startup(new SupplyKernel()));
        }
    }
}