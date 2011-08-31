using System;

namespace SupplyDispense.Service.Interface
{
    public interface INetworkInfo
    {
        string IpAddress { get; }
        string GateWayAddresse { get; }
        string Subnet { get; }
        DateTime LastPackSent { get; }
        bool Online { get; }
        void Refresh();
    }
}