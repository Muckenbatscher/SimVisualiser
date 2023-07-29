using SteelSeriesGameEngine.Enums;
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
            await _gameEventRegistrationService.RegisterFlagEventAsync();

            var r = new UnregisterGameEventService(_targetAddress);
            await r.UnregisterGameEvent(Constants.GameMetadata.GAME_NAME, "YELLOW_FLAG");
            await r.UnregisterGameEvent(Constants.GameMetadata.GAME_NAME, "BLUE_FLAG");
        }

        public async Task StopGame()
        {
            await _stopGameService.StopGame();
        }

        public async Task ClearFlagEventAsync()
        {
            await _gameEventService.SendFlagEventAsync(FlagType.NoFloag);
        }
        public async Task SendBlueFlagEventAsync()
        {
            await _gameEventService.SendFlagEventAsync(FlagType.BlueFlag);
        }
        public async Task SendYellowFlagEventAsync()
        {
            await _gameEventService.SendFlagEventAsync(FlagType.YellowFlag);
        }
        public async Task SendWhiteFlagEventAsync()
        {
            await _gameEventService.SendFlagEventAsync(FlagType.WhiteFlag);
        }
        public async Task SendGreenFlagEventAsync()
        {
            await _gameEventService.SendFlagEventAsync(FlagType.GreenFlag);
        }
        public async Task SendOrangeFlagEventAsync()
        {
            await _gameEventService.SendFlagEventAsync(FlagType.OrangeFlag);
        }

    }
}
