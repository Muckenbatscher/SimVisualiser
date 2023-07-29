using HttpPost.EndPoints.Finalization;
using HttpPost.Messages;
using HttpPost.Messages.Finalization;
using SteelSeriesGameEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelSeriesGameEngine.Services.Finalization
{
    internal class UnregisterGameService : GameSenseServiceBase
    {
        private UnregisterGameEndpoint _endPoint;

        public UnregisterGameService(TargetAddress baseAddress) : base(baseAddress)
        {
            _endPoint = new UnregisterGameEndpoint(baseAddress.GetURL());
        }


        public async Task UnregisterGame(string gameName)
        {
            var message = new UnregisterGameMessage()
            {
                Game = gameName
            };
            await _endPoint.PostMessageAsync(message);
        }
    }
}
