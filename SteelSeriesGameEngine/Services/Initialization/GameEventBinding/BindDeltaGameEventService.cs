using HttpPost.EndPoints.Initialization;
using HttpPost.Messages.Initialization.Binding;
using SteelSeriesGameEngine.Interfaces;
using SteelSeriesGameEngine.Models;
using SteelSeriesGameEngine.Services.SampleMessageGeneration.GameEventBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelSeriesGameEngine.Services.Initialization.GameEventBinding
{
    internal class BindDeltaGameEventService : GameSenseServiceBase, IBindGameEventService
    {
        private readonly BindGameEventEndpoint _endPoint;

        private readonly ISampleMessageGeneration<BindGameEventMessage> _deltaMessageGeneration;

        public BindDeltaGameEventService(TargetAddress baseAddress) : base(baseAddress)
        {
            _endPoint = new BindGameEventEndpoint(baseAddress.GetURL());

            _deltaMessageGeneration = new DeltaEventBindingMessageService();
        }

        public void BindEvent()
        {
            var message = _deltaMessageGeneration.GetFilledMessage();
            _endPoint.PostMessage(message);
        }

        public async Task BindEventAsync()
        {
            var message = _deltaMessageGeneration.GetFilledMessage();
            await _endPoint.PostMessageAsync(message);
        }
    }
}
