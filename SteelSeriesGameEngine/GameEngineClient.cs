using SteelSeriesGameEngine.Models;
using SteelSeriesGameEngine.Services.Initialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelSeriesGameEngine
{
    public class GameEngineClient
    {
        private TargetAddress _targetAddress;

        private AddressRetriever _addressRetriever;

        public GameEngineClient()
        {
            _addressRetriever = new AddressRetriever();
            _targetAddress = _addressRetriever.GetTargetAddress();
        }
    }
}
