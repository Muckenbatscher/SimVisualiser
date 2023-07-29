using SteelSeriesGameEngine.Models;
using SteelSeriesGameEngine.Services.Initialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelSeriesGameEngine
{
    public class GameSenseClient
    {
        private TargetAddress _targetAddress;

        private AddressRetriever _addressRetriever;

        private RegistrationService _registrationService;

        public GameSenseClient()
        {
            _addressRetriever = new AddressRetriever();
            _targetAddress = _addressRetriever.GetTargetAddress();
            _registrationService = new RegistrationService(_targetAddress);

            _registrationService.Register();
        }
    }
}
