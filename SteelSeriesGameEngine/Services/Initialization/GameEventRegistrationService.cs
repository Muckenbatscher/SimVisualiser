using HttpPost.EndPoints.Initialization;
using HttpPost.Messages.Initialization;
using SteelSeriesGameEngine.Constants;
using SteelSeriesGameEngine.Interfaces;
using SteelSeriesGameEngine.Models;
using SteelSeriesGameEngine.Services.SampleMessageGeneration.GameEventRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelSeriesGameEngine.Services.Initialization
{
    internal class GameEventRegistrationService : GameSenseServiceBase
    {
        private readonly GameEventRegistrationEndpoint _endPoint;

        private readonly ISampleMessageGeneration<GameEventRegistrationMessage> _flagMessageGeneration;

        public GameEventRegistrationService(TargetAddress baseAddress) : base(baseAddress)
        {
            _endPoint = new GameEventRegistrationEndpoint(baseAddress.GetURL());
            _flagMessageGeneration = new FlagEventRegistrationSampleMessageService();
        }

        public async Task RegisterFlagEventAsync()
        {
            var message = _flagMessageGeneration.GetFilledMessage();
            await _endPoint.PostMessageAsync(message);
        }
    }
}
