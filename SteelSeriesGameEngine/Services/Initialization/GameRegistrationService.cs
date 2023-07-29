using HttpPost.EndPoints;
using HttpPost.Messages;
using SteelSeriesGameEngine.Common;
using SteelSeriesGameEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelSeriesGameEngine.Services.Initialization
{
    internal class GameRegistrationService : GameSenseServiceBase
    {
        private GameRegistrationEndpoint _endPoint;

        public GameRegistrationService(TargetAddress baseAddress) : base(baseAddress)
        {
            _endPoint = new GameRegistrationEndpoint(baseAddress.GetURL());
        }

        public async Task RegisterAsync()
        {
            var message = new GameRegistrationMessage()
            {
                Game = GameMetadata.GAME_NAME,
                GameDisplayName = GameMetadata.GAME_DISPLAY_NAME,
                Developer = GameMetadata.DEVELOPER
            };
            await _endPoint.PostMessageAsync(message);
        }
    }
}
