using System;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using SupplyDispense.Service.Interface;

namespace SupplyDispense.Service.Network
{
    public class NetworkInfo : INetworkInfo
    {
        #region INetworkInfo Members

        public string IpAddress { get; private set; }
        public string GateWayAddresse { get; private set; }
        public string Subnet { get; private set; }
        public DateTime LastPackSent { get; private set; }

        public bool Online
        {
            get { return NetworkInterface.GetIsNetworkAvailable(); }
        }

        public void Refresh()
        {
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            IpAddress = Dns.GetHostAddresses(Dns.GetHostName())[1].ToString();
            foreach (NetworkInterface n in adapters)
            {
                SetGateway(n);
                SetSubnet(n);
            }
        }

        #endregion

        private void SetSubnet(NetworkInterface n)
        {
            UnicastIPAddressInformation unicastIpAddressInformation = UnicastIpAddressInformation(n);
            if (unicastIpAddressInformation == null) return;
            Subnet = (string.IsNullOrEmpty(Subnet) || Subnet == "0.0.0.0")
                         ? unicastIpAddressInformation.IPv4Mask.ToString()
                         : Subnet;
        }

        private void SetGateway(NetworkInterface n)
        {
            GatewayIPAddressInformation gateWay = GatewayIpAddressInformation(n);
            if (gateWay == null) return;
            GateWayAddresse = GateWayAddresse ?? gateWay.Address.ToString();
        }

        private static GatewayIPAddressInformation GatewayIpAddressInformation(NetworkInterface n)
        {
            return n.GetIPProperties().GatewayAddresses.FirstOrDefault();
        }

        private UnicastIPAddressInformation UnicastIpAddressInformation(NetworkInterface n)
        {
            return
                n.GetIPProperties().UnicastAddresses.FirstOrDefault(ad => ad.Address.ToString() == IpAddress.ToString());
        }
    }
}