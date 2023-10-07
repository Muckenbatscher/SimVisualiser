using HttpPost.EndPoints.GameEvent;
using HttpPost.Messages.GameEvents;
using SimDataReadingCore.Enumerations;
using SteelSeriesGameEngine.Constants;
using SteelSeriesGameEngine.Models;
using SteelSeriesGameEngine.Services.SampleMessageGeneration.GameEventTriggering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelSeriesGameEngine.Services.GameEvent
{
    internal abstract class GameEventTriggerService : GameSenseServiceBase
    {
        private readonly GameEventEndpoint _endPoint;

        private readonly GameEventTriggerSampleMessageService _messageGenerationService;

        private string GameEventName { get; set; }

        public GameEventTriggerService(TargetAddress baseAddress, string eventName) : base(baseAddress)
        {
            _endPoint = new GameEventEndpoint(baseAddress.GetURL());
            _messageGenerationService = new GameEventTriggerSampleMessageService();

            GameEventName = eventName;
        }

        public async Task SendEventAsync(int value)
        {
            var message = GetFilledEventMessage(value);
            await _endPoint.PostMessageAsync(message);
        }
        public void SendEvent(int value)
        {
            var message = GetFilledEventMessage(value);
            _endPoint.PostMessage(message);
        }

        private GameEventMessage GetFilledEventMessage(int value)
        {
            return _messageGenerationService.GetFilledEventTriggeringMessage(GameEventName, value);
        }

    }
}
