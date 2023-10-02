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
        private readonly GameEventEndpoint _endPoint;
        public GameEventService(TargetAddress baseAddress) : base(baseAddress)
        {
            _endPoint = new GameEventEndpoint(baseAddress.GetURL());
        }

        private static GameEventMessage GetPrefilledMessage(string eventName, int value)
        {
            return new GameEventMessage()
            {
                Game = GameMetadata.GAME_NAME,
                EventName = eventName,
                Data = GetSampleData(value)
            };
        }
        private static GameEventData GetSampleData(int value)
        {
            return new GameEventData()
            {
                Value = value
            };
        }

        public async Task SendFlagEventAsync(Flag flagType)
        {
            var message = GetPrefilledMessage(GameEventMetadata.FLAG_EVENT_NAME, (int)flagType);

            await _endPoint.PostMessageAsync(message);
        }

    }
}
