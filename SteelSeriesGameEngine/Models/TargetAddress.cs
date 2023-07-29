using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelSeriesGameEngine.Models
{
    internal class TargetAddress
    {
        public string Address { get; private set; }
        public int Port { get; private set; }

        public TargetAddress(string address, int port)
        {
            Address = address;
            Port = port;
        }

        public TargetAddress(string encodedAddress)
        {
            int dotIndex = encodedAddress.IndexOf(':');
            if (dotIndex < 0)
                throw new ArgumentException();
            
            Address = encodedAddress.Substring(0, dotIndex);
            Port = int.Parse(encodedAddress.Substring(dotIndex + 1));
        }

        internal string GetURL() => $"{Address}:{Port}";
    }
}
