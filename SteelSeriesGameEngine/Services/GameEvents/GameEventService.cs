using HttpPost.EndPoints;
using HttpPost.Messages.GameEvents;
using SteelSeriesGameEngine.Common;
using SteelSeriesGameEngine.Constants;
using SteelSeriesGameEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelSeriesGameEngine.Services.GameEvents
{
    internal class GameEventService : GameSenseServiceBase
    {
        private GameEventEndpoint _endPoint;
        public GameEventService(TargetAddress baseAddress) : base(baseAddress)
        {
            _endPoint = new GameEventEndpoint(baseAddress.GetURL());
        }

        private GameEventMessage GetPrefilledMessage()
        {
            return new GameEventMessage()
            {
                Game = GameMetadata.GAME_NAME,
                Data = GetSampleData()
            };
        }
        private GameEventData GetSampleData()
        {
            return new GameEventData()
            {
                Value = 50
            };
        }

        public async Task SendYellowFlagEventAsync()
        {
            var message = GetPrefilledMessage();
            message.EventName = GameEventMetadata.YELLOW_FLAG_EVENT_NAME;

            await _endPoint.PostMessageAsync(message);
        }

        public async Task SendBlueFlagEventAsync()
        {
            var message = GetPrefilledMessage();
            message.EventName = GameEventMetadata.BLUE_FLAG_EVENT_NAME;

            await _endPoint.PostMessageAsync(message);
        }
    }
}
