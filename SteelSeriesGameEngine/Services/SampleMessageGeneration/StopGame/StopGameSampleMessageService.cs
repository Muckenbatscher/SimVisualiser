using HttpPost.Messages.Finalization;
using SteelSeriesGameEngine.Constants;
using SteelSeriesGameEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelSeriesGameEngine.Services.SampleMessageGeneration.StopGame
{
    internal class StopGameSampleMessageService : ISampleMessageGeneration<StopGameMessage>
    {
        public StopGameMessage GetFilledMessage()
        {
            var message = new StopGameMessage()
            {
                Game = GameMetadata.GAME_NAME
            };
            return message;
        }
    }
}
