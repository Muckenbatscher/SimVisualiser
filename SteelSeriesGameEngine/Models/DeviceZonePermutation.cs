using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelSeriesGameEngine.Models
{
    public class DeviceZonePermutation
    {
        public string DeviceType { get; set; }
        public string ZoneName { get; set; }

        public DeviceZonePermutation(string deviceType, string zoneName)
        {
            DeviceType = deviceType;
            ZoneName = zoneName;
        }
    }
}
