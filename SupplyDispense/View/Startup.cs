using System;
using System.Windows.Forms;
using Ninject;
using SupplyDispense.Interface;

namespace SupplyDispense.View
{
    public partial class Startup : Form
    {
        private ISpinner _spinner;

        public Startup(StandardKernel kernel)
        {
            Kernel = kernel;
            InitializeComponent();
        }

        private StandardKernel Kernel { get; set; }

        protected override void OnShown(EventArgs e)
        {
            _spinner = Kernel.Get<ISpinner>();
            _spinner.Initialize();
            Hide();
        }
    }
}