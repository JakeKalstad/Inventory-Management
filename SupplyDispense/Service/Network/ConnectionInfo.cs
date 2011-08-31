using System.Text;
using System.Windows.Forms;
using SupplyDispense.Service.Interface;

namespace SupplyDispense.Service.Network
{
    public class ConnectionInfo : IConnectionInfo
    {
        private readonly INetworkInfo _monitor;

        public ConnectionInfo(INetworkInfo monitor)
        {
            _monitor = monitor;
        }

        #region IConnectionInfo Members

        public void ShowInfo()
        {
            _monitor.Refresh();
            var builder = new StringBuilder();
            builder.Append("IP Address: ");
            builder.Append(_monitor.IpAddress);
            builder.Append("\nSubnet Mask: ");
            builder.Append(_monitor.Subnet);
            builder.Append("\nGateway: ");
            builder.Append(_monitor.GateWayAddresse);
            MessageBox.Show(builder.ToString());
        }

        #endregion
    }
}