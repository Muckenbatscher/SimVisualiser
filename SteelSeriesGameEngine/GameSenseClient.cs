using SimDataReadingCore.Enumerations;
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

        private GameRegistrationService _gameRegistrationService;
        private GameEventRegistrationService _gameEventRegistrationService;
        private StopGameService _stopGameService;

        private GameEventService _gameEventService;

        public GameSenseClient()
        {
            _targetAddress = AddressRetriever.GetTargetAddress();
            _gameRegistrationService = new GameRegistrationService(_targetAddress);
            _gameEventRegistrationService = new GameEventRegistrationService(_targetAddress);
            _stopGameService = new StopGameService(_targetAddress);

            _gameEventService = new GameEventService(_targetAddress);

            SetUpGameEngineAsync();
        }

        private async Task SetUpGameEngineAsync()
        {
            await _gameRegistrationService.RegisterAsync();
            await _gameEventRegistrationService.RegisterFlagEventAsync();
        }

        public async Task StopGame()
        {
            await _stopGameService.StopGame();
        }

        public async Task SendFlagEventAsync(Flag flag)
        {
            await _gameEventService.SendFlagEventAsync(flag);
        }

    }
}
