using SimDataReadingCore.Enumerations;
using SteelSeriesGameEngine.Models;
using SteelSeriesGameEngine.Services.Finalization;
using SteelSeriesGameEngine.Services.GameEvent;
using SteelSeriesGameEngine.Services.Initialization;
using SteelSeriesGameEngine.Services.Initialization.GameEventBinding;
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
        private readonly GameEventRegistrationService _gameEventRegistrationService;
        private readonly BindGameEventService _bindGameEventService;
        private readonly StopGameService _stopGameService;

        private readonly FlagEventTriggerService _flagEventService;
        private readonly DeltaEventTriggerService _deltaEventService;

        public GameSenseClient()
        {
            _targetAddress = AddressRetriever.GetTargetAddress();

            _gameUnregisteringService = new UnregisterGameService(_targetAddress);
            _gameEventUnregisteringService = new UnregisterGameEventService(_targetAddress);

            _gameRegistrationService = new GameRegistrationService(_targetAddress);
            _gameEventRegistrationService = new GameEventRegistrationService(_targetAddress);
            _bindGameEventService = new BindGameEventService(_targetAddress);
            _stopGameService = new StopGameService(_targetAddress);

            _flagEventService = new FlagEventTriggerService(_targetAddress);
            _deltaEventService = new DeltaEventTriggerService(_targetAddress);

            RemoveGame();
            SetUpGameEngine();
        }

        private void SetUpGameEngine()
        {
            _gameRegistrationService.RegisterGame();
            _bindGameEventService.BindAllEvents();
        }

        private void RemoveGame()
        {
            _gameEventUnregisteringService.UnregisterGameEvent(Constants.GameEventMetadata.FLAG_EVENT_NAME);
            _gameEventUnregisteringService.UnregisterGameEvent(Constants.GameEventMetadata.DELTA_EVENT_NAME);
            _gameUnregisteringService.UnregisterGame();
        }

        public async Task StopGame()
        {
            await _stopGameService.StopGameAsync();
        }

        public async Task SendFlagEventAsync(Flag flag)
        {
            await _flagEventService.TriggerGameEventValueAsync(flag);
        }
        public async Task SendDeltaEventAsync(TimeSpan delta)
        {
            await _deltaEventService.TriggerGameEventValueAsync(delta);
        }

    }
}
