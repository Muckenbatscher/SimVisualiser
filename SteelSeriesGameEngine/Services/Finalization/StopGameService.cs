using HttpPost.EndPoints.Finalization;
using HttpPost.Messages.Finalization;
using SteelSeriesGameEngine.Constants;
using SteelSeriesGameEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelSeriesGameEngine.Services.Finalization
{
    internal class StopGameService : GameSenseServiceBase
    {
        private StopGameEndpoint _endPoint;

        public StopGameService(TargetAddress baseAddress) : base(baseAddress)
        {
            _endPoint = new StopGameEndpoint(baseAddress.GetURL());
        }


        public async Task StopGame()
        {
            var message = new StopGameMessage()
            {
                Game = GameMetadata.GAME_NAME
            };
            await _endPoint.PostMessageAsync(message);
        }
    }
}
