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

        private GameRegistrationService _gameRegistrationService;
        private GameEventRegistrationService _gameEventRegistrationService;

        public GameSenseClient()
        {
            _addressRetriever = new AddressRetriever();
            _targetAddress = _addressRetriever.GetTargetAddress();
            _gameRegistrationService = new GameRegistrationService(_targetAddress);
            _gameEventRegistrationService = new GameEventRegistrationService(_targetAddress);

            SetUpGameEngineAsync();
        }

        private async void SetUpGameEngineAsync()
        {
            await _gameRegistrationService.RegisterAsync();
            _gameEventRegistrationService.RegisterYellowFlagEvent();
            _gameEventRegistrationService.RegisterBlueFlagEvent();
        }
    }
}
