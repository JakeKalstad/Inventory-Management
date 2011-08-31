using System.Drawing.Printing;
using System.Windows.Forms;
using SupplyDispense.Service.Interface;

namespace SupplyDispense.Service.Core
{
    public class Printer : IPrinter
    {
        private readonly PrintDocument _docToPrint = new PrintDocument();
        private readonly PrintDialog _printDialog = new PrintDialog();

        #region IPrinter Members

        public void Print()
        {
            _printDialog.AllowSomePages = true;
            _printDialog.ShowHelp = true;
            _printDialog.Document = _docToPrint;
            if (_printDialog.ShowDialog() != DialogResult.OK) return;

            _docToPrint.Print();
        }

        #endregion
    }
}