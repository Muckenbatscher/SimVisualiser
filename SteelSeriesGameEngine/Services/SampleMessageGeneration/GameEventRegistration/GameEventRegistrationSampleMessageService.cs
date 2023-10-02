using HttpPost.Messages.Initialization;
using SteelSeriesGameEngine.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelSeriesGameEngine.Services.SampleMessageGeneration.GameEventRegistration
{
    internal class GameEventRegistrationSampleMessageService
    {
        protected GameEventRegistrationMessage GetFilledRegistrationMessage(string eventName)
        {
            return new GameEventRegistrationMessage()
            {
                Game = eventName,
                MinValue = 0,
                MaxValue = 8
            };
        }
    }
}
