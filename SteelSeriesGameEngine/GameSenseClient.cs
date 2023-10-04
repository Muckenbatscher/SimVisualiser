using SimDataReadingCore.Enumerations;
using SteelSeriesGameEngine.Models;
using SteelSeriesGameEngine.Services.Finalization;
using SteelSeriesGameEngine.Services.GameEvent;
using SteelSeriesGameEngine.Services.Initialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SteelSeriesGameEngine
{
    public class GameSenseClient
    {
        private readonly TargetAddress _targetAddress;

        private readonly UnregisterGameService _gameUnregisteringService;
        private readonly UnregisterGameEventService _gameEventUnregisteringService;

        private readonly GameRegistrationService _gameRegistrationService;
        private readonly BindGameEventService _bindGameEventService;
        private readonly StopGameService _stopGameService;

        private readonly GameEventTriggerService _gameEventService;

        public GameSenseClient()
        {
            _targetAddress = AddressRetriever.GetTargetAddress();

            _gameUnregisteringService = new UnregisterGameService(_targetAddress);
            _gameEventUnregisteringService = new UnregisterGameEventService(_targetAddress);

            _gameRegistrationService = new GameRegistrationService(_targetAddress);
            _bindGameEventService = new BindGameEventService(_targetAddress);
            _stopGameService = new StopGameService(_targetAddress);

            _gameEventService = new GameEventTriggerService(_targetAddress);

            RemoveGameAsync();
            SetUpGameEngineAsync();
        }

        private async Task SetUpGameEngineAsync()
        {
            await _gameRegistrationService.RegisterAsync();
            await _bindGameEventService.BindFlagEventAsync();
            await _bindGameEventService.BindDeltaEventAsync();
        }

        private async Task RemoveGameAsync()
        {
            await _gameEventUnregisteringService.UnregisterGameEventAsync(Constants.GameEventMetadata.FLAG_EVENT_NAME);
            await _gameUnregisteringService.UnregisterGameAsync();
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
