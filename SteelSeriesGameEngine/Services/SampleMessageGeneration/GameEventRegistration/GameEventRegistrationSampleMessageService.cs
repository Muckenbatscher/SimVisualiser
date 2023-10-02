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
        protected GameEventRegistrationMessage GetFilledRegistrationMessage(string eventName, int minValue, int maxValue)
        {
            return new GameEventRegistrationMessage()
            {
                Game = eventName,
                MinValue = minValue,
                MaxValue = maxValue
            };
        }
    }
}
