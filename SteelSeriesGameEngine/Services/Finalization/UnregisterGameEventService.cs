using HttpPost.EndPoints.Finalization;
using HttpPost.Messages.Finalization;
using SteelSeriesGameEngine.Models;
using SteelSeriesGameEngine.Services.SampleMessageGeneration.GameEventRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelSeriesGameEngine.Services.Finalization
{
    internal class UnregisterGameEventService : GameSenseServiceBase
    {
        private readonly UnregisterGameEventEndpoint _endPoint;

        private readonly UnregisterGameEventSampleMessageService _sampleMessageService;

        public UnregisterGameEventService(TargetAddress baseAddress) : base(baseAddress)
        {
            _endPoint = new UnregisterGameEventEndpoint(baseAddress.GetURL());
            _sampleMessageService = new UnregisterGameEventSampleMessageService();
        }


        public async Task UnregisterGameEventAsync(string eventName)
        {
            var message = _sampleMessageService.GetFilledUnregistrationMessage(eventName);
            await _endPoint.PostMessageAsync(message);
        }
        public void UnregisterGameEvent(string eventName)
        {
            var message = _sampleMessageService.GetFilledUnregistrationMessage(eventName);
            _endPoint.PostMessage(message);
        }
    }
}
