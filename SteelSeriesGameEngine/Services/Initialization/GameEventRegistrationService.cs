using HttpPost.EndPoints.Initialization;
using HttpPost.Messages.Initialization;
using SteelSeriesGameEngine.Constants;
using SteelSeriesGameEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelSeriesGameEngine.Services.Initialization
{
    internal class GameEventRegistrationService : GameSenseServiceBase
    {
        private GameEventRegistrationEndpoint _endPoint;

        public GameEventRegistrationService(TargetAddress baseAddress) : base(baseAddress)
        {
            _endPoint = new GameEventRegistrationEndpoint(baseAddress.GetURL());
        }

        private static GameEventRegistrationMessage GetPrefilledMessage()
        {
            return new GameEventRegistrationMessage()
            {
                Game = GameMetadata.GAME_NAME,
                MinValue = 0,
                MaxValue = 8
            };
        }

        public async Task RegisterFlagEventAsync()
        {
            var message = GetPrefilledMessage();
            message.EventName = GameEventMetadata.FLAG_EVENT_NAME;
            await _endPoint.PostMessageAsync(message);
        }
    }
}
