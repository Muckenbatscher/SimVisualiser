using HttpPost.Messages.Finalization;
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
    internal class UnregisterGameSampleMessageService : ISampleMessageGeneration<UnregisterGameMessage>
    {
        public UnregisterGameMessage GetFilledMessage()
        {
            var message = new UnregisterGameMessage()
            {
                Game = GameMetadata.GAME_NAME
            };
            return message;
        }
    }
}
