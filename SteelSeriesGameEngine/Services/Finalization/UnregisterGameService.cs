using HttpPost.EndPoints.Finalization;
using HttpPost.Messages;
using HttpPost.Messages.Finalization;
using HttpPost.Messages.Initialization;
using SteelSeriesGameEngine.Interfaces;
using SteelSeriesGameEngine.Models;
using SteelSeriesGameEngine.Services.SampleMessageGeneration.GameRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelSeriesGameEngine.Services.Finalization
{
    internal class UnregisterGameService : GameSenseServiceBase
    {
        private readonly UnregisterGameEndpoint _endPoint;
        private readonly ISampleMessageGeneration<UnregisterGameMessage> _sampleMessageGeneration;

        public UnregisterGameService(TargetAddress baseAddress) : base(baseAddress)
        {
            _endPoint = new UnregisterGameEndpoint(baseAddress.GetURL());
            _sampleMessageGeneration = new UnregisterGameSampleMessageService();
        }


        public async Task UnregisterGameAsync()
        {
            var message = _sampleMessageGeneration.GetFilledMessage();
            await _endPoint.PostMessageAsync(message);
        }
    }
}
