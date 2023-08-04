using HttpPost.EndPoints.GameEvent;
using HttpPost.Messages.GameEvents;
using SimDataReadingCore.Enumerations;
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

        private GameEventMessage GetPrefilledMessage(int value)
        {
            return new GameEventMessage()
            {
                Game = GameMetadata.GAME_NAME,
                Data = GetSampleData(value)
            };
        }
        private GameEventData GetSampleData(int value)
        {
            return new GameEventData()
            {
                Value = value
            };
        }

        public async Task SendFlagEventAsync(Flag flagType)
        {
            var message = GetPrefilledMessage((int)flagType);
            message.EventName = GameEventMetadata.FLAG_EVENT_NAME;

            await _endPoint.PostMessageAsync(message);
        }

    }
}
