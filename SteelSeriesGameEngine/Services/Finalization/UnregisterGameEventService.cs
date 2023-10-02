using HttpPost.EndPoints.Finalization;
using HttpPost.Messages.Finalization;
using SteelSeriesGameEngine.Models;
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

        public UnregisterGameEventService(TargetAddress baseAddress) : base(baseAddress)
        {
            _endPoint = new UnregisterGameEventEndpoint(baseAddress.GetURL());
        }


        public async Task UnregisterGameEvent(string gameName, string eventName)
        {
            var message = new UnregisterGameEventMessage()
            {
                Game = gameName,
                EventName = eventName
            };
            var success = await _endPoint.PostMessageAsync(message);
        }
    }
}
