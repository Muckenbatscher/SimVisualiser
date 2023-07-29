using SteelSeriesGameEngine.Models;
using SteelSeriesGameEngine.Services.Finalization;
using SteelSeriesGameEngine.Services.GameEvents;
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
        private StopGameService _stopGameService;

        private GameEventService _gameEventService;

        public GameSenseClient()
        {
            _addressRetriever = new AddressRetriever();
            _targetAddress = _addressRetriever.GetTargetAddress();
            _gameRegistrationService = new GameRegistrationService(_targetAddress);
            _gameEventRegistrationService = new GameEventRegistrationService(_targetAddress);
            _stopGameService = new StopGameService(_targetAddress);

            _gameEventService = new GameEventService(_targetAddress);

            SetUpGameEngineAsync();
        }

        private async Task SetUpGameEngineAsync()
        {
            await _gameRegistrationService.RegisterAsync();
            _gameEventRegistrationService.RegisterYellowFlagEventAsync();
            await _gameEventRegistrationService.RegisterBlueFlagEventAsync();
        }

        public async Task StopGame()
        {
            _stopGameService.StopGame();
        }

        public async Task SendYellowFlagEventAsync()
        {
            await _gameEventService.SendYellowFlagEventAsync();
        }
        public async Task SendBlueFlagEventAsync()
        {
            await _gameEventService.SendBlueFlagEventAsync();
        }
    }
}
