using HttpPost.EndPoints.Initialization;
using HttpPost.Messages.Initialization;
using SteelSeriesGameEngine.Constants;
using SteelSeriesGameEngine.Interfaces;
using SteelSeriesGameEngine.Models;
using SteelSeriesGameEngine.Services.SampleMessageGeneration;
using SteelSeriesGameEngine.Services.SampleMessageGeneration.GameRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelSeriesGameEngine.Services.Initialization
{
    internal class GameRegistrationService : GameSenseServiceBase
    {
        private readonly GameRegistrationEndpoint _endPoint;
        private readonly ISampleMessageGeneration<GameRegistrationMessage> _sampleMessageGeneration;

        public GameRegistrationService(TargetAddress baseAddress) : base(baseAddress)
        {
            _endPoint = new GameRegistrationEndpoint(baseAddress.GetURL());
            _sampleMessageGeneration = new GameRegistrationSampleMessageService();
        }

        public async Task RegisterAsync()
        {
            var message = _sampleMessageGeneration.GetFilledMessage();
            await _endPoint.PostMessageAsync(message);
        }
    }
}
