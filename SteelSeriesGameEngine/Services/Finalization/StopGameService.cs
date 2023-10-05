using HttpPost.EndPoints.Finalization;
using HttpPost.Messages.Finalization;
using SteelSeriesGameEngine.Interfaces;
using SteelSeriesGameEngine.Models;
using SteelSeriesGameEngine.Services.SampleMessageGeneration.StopGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelSeriesGameEngine.Services.Finalization
{
    internal class StopGameService : GameSenseServiceBase
    {
        private readonly StopGameEndpoint _endPoint;

        private readonly ISampleMessageGeneration<StopGameMessage> _sampleMessageGeneration;

        public StopGameService(TargetAddress baseAddress) : base(baseAddress)
        {
            _endPoint = new StopGameEndpoint(baseAddress.GetURL());
            _sampleMessageGeneration = new StopGameSampleMessageService();
        }

        public async Task StopGameAsync()
        {
            var message = _sampleMessageGeneration.GetFilledMessage();
            await _endPoint.PostMessageAsync(message);
        }
        public void StopGame()
        {
            var message = _sampleMessageGeneration.GetFilledMessage();
            _endPoint.PostMessage(message);
        }
    }
}
