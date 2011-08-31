using System;
using System.Linq;
using System.Windows.Forms;
using SupplyDispense.Extensions;
using SupplyDispense.View.Interface;

namespace SupplyDispense.View.Dialog
{
    public partial class PasswordReset : Form, IDialog
    {
        public PasswordReset(Action<string> reset)
        {
            InitializeComponent();
            SubmitButton.GetClick()
                .Where(_ => textBox1.Text == textBox2.Text
                            && !string.IsNullOrEmpty(textBox1.Text)
                            && textBox1.Text.Length >= 5)
                .Subscribe(_ => Execute(reset));
            textBox2.GetKeyDown()
                .Where(k => k.EventArgs.KeyCode == Keys.Enter)
                .Subscribe(_ => Execute(reset));
        }

        private void Execute(Action<string> reset)
        {
            reset(textBox1.Text);
            Close();
        }
    }
}