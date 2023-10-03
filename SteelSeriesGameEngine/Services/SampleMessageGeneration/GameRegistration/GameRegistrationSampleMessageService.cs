using HttpPost.Messages.Initialization;
using SteelSeriesGameEngine.Constants;
using SteelSeriesGameEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelSeriesGameEngine.Services.SampleMessageGeneration.GameRegistration
{
    internal class GameRegistrationSampleMessageService : ISampleMessageGeneration<GameRegistrationMessage>
    {
        public GameRegistrationMessage GetFilledMessage()
        {
            var message = new GameRegistrationMessage()
            {
                Game = GameMetadata.GAME_NAME,
                GameDisplayName = GameMetadata.GAME_DISPLAY_NAME,
                Developer = GameMetadata.DEVELOPER
            };
            return message;
        }
    }
}
