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
    internal class GameEventTriggerService : GameSenseServiceBase
    {
        private readonly GameEventEndpoint _endPoint;

        private readonly GameEventTriggerSampleMessageService _messageGenerationService;

        public GameEventTriggerService(TargetAddress baseAddress) : base(baseAddress)
        {
            _endPoint = new GameEventEndpoint(baseAddress.GetURL());
            _messageGenerationService = new GameEventTriggerSampleMessageService();
        }



        public async Task SendFlagEventAsync(Flag flagType)
        {
            var message = _messageGenerationService.GetFilledEventTriggeringMessage(GameEventMetadata.FLAG_EVENT_NAME, (int)flagType);

            await _endPoint.PostMessageAsync(message);
        }

        public async Task SendDeltaEventAsync(TimeSpan deltaTime)
        {
            int deltaMilliseconds;
            if (deltaTime.TotalMilliseconds > 1000)
                deltaMilliseconds = 0;
            else if (deltaTime.TotalMilliseconds < -1000)
                deltaMilliseconds = 2000;
            else
                deltaMilliseconds = 1000 - (int)deltaTime.TotalMilliseconds;

            var message = _messageGenerationService.GetFilledEventTriggeringMessage(GameEventMetadata.DELTA_EVENT_NAME, deltaMilliseconds);

            await _endPoint.PostMessageAsync(message);
        }

    }
}
