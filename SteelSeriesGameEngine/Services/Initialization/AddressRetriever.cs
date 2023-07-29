using SteelSeriesGameEngine.Models;
using SteelSeriesGameEngine.Models.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SteelSeriesGameEngine.Services.Initialization
{
    internal class AddressRetriever
    {
        private const string _path = @"SteelSeries\SteelSeries Engine 3";
        private const string _fileName = @"coreProps.json";

        internal TargetAddress GetTargetAddress()
        {
            string programDataPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string targetFilePath = Path.Combine(programDataPath, _path, _fileName);
            string fileContents = File.ReadAllText(targetFilePath);

            CoreProps? coreProps = JsonSerializer.Deserialize<CoreProps>(fileContents);
            if (coreProps == null)
                throw new Exception();

            return new TargetAddress(coreProps.Address);
        }
    }
}
