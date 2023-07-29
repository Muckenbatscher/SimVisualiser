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
    internal class RegistrationService : GameSenseServiceBase
    {
        private RegistrationEndpoint _endPoint;

        public RegistrationService(TargetAddress baseAddress) : base(baseAddress)
        {
            _endPoint = new RegistrationEndpoint(baseAddress.GetURL());
        }

        public void Register()
        {
            var message = new RegistrationMessage()
            {
                Game = Constants.GAME_NAME,
                GameDisplayName = Constants.GAME_DISPLAY_NAME,
                Developer = Constants.DEVELOPER
            };
            _endPoint.PostMessageAsync(message);
        }
    }
}
