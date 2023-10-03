using HttpPost.EndPoints.Initialization;
using HttpPost.Messages.Initialization;
using HttpPost.Messages.Initialization.Binding;
using SteelSeriesGameEngine.Interfaces;
using SteelSeriesGameEngine.Models;
using SteelSeriesGameEngine.Services.SampleMessageGeneration.GameEventBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelSeriesGameEngine.Services.Initialization
{
    internal class BindGameEventService : GameSenseServiceBase
    {
        private readonly BindGameEventEndpoint _endPoint;


        private readonly ISampleMessageGeneration<BindGameEventMessage> _flagMessageGeneration;

        public BindGameEventService(TargetAddress baseAddress) : base(baseAddress)
        {
            _endPoint = new BindGameEventEndpoint(baseAddress.GetURL());

            _flagMessageGeneration = new FlagEventBindingMessageService();
        }

        public async Task BindFlagEventAsync()
        {
            var message = _flagMessageGeneration.GetFilledMessage();
            await _endPoint.PostMessageAsync(message);
        }
    }
}
