using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace IDGEN.Code
{
    public static class DeviceHelper
    {
       public static string GetDeviceMacAddress()
        {
            // Get all network interfaces
            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();

            // Loop through each interface
            foreach (NetworkInterface netInterface in interfaces)
            {
                // Check if the interface is operational and not a loopback or tunnel interface
                if (netInterface.OperationalStatus == OperationalStatus.Up &&
                    netInterface.NetworkInterfaceType != NetworkInterfaceType.Loopback &&
                    netInterface.NetworkInterfaceType != NetworkInterfaceType.Tunnel)
                {
                    // Get the physical (MAC) address
                    PhysicalAddress macAddress = netInterface.GetPhysicalAddress();
                    return macAddress.ToString();
                }
            }

            // If no MAC address is found, return an empty string or throw an exception
            return string.Empty;
        }
    }
}
