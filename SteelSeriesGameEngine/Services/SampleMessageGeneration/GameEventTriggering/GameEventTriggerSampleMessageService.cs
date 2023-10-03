using HttpPost.Messages.GameEvents;
using SteelSeriesGameEngine.Constants;
using SteelSeriesGameEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelSeriesGameEngine.Services.SampleMessageGeneration.GameEventTriggering
{
    public class GameEventTriggerSampleMessageService
    {
        public GameEventMessage GetFilledEventTriggeringMessage(string eventName, int value)
        {
            return new GameEventMessage()
            {
                Game = GameMetadata.GAME_NAME,
                EventName = eventName,
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

    }
}
