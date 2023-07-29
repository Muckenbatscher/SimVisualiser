using HttpPost.EndPoints;
using HttpPost.Messages.GameEvents;
using SteelSeriesGameEngine.Common;
using SteelSeriesGameEngine.Constants;
using SteelSeriesGameEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelSeriesGameEngine.Services.Initialization
{
    internal class GameEventRegistrationService : GameSenseServiceBase
    {
        private GameEventRegistrationEndpoint _endPoint;

        public GameEventRegistrationService(TargetAddress baseAddress) : base(baseAddress)
        {
            _endPoint = new GameEventRegistrationEndpoint(baseAddress.GetURL());
        }

        private GameEventRegistrationMessage GetPrefilledMessage()
        {
            return new GameEventRegistrationMessage()
            {
                Game = GameMetadata.GAME_NAME
            };
        }

        public void RegisterYellowFlagEvent()
        {
            var message = GetPrefilledMessage();
            message.EventName = GameEventMetadata.YELLOW_FLAG_EVENT_NAME;
            _endPoint.PostMessageAsync(message);
        }
        public void RegisterBlueFlagEvent()
        {
            var message = GetPrefilledMessage();
            message.EventName = GameEventMetadata.BLUE_FLAG_EVENT_NAME;
            _endPoint.PostMessageAsync(message);
        }
    }
}
