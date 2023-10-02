using HttpPost.Messages.Initialization;
using SteelSeriesGameEngine.Constants;
using SteelSeriesGameEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelSeriesGameEngine.Services.SampleMessageGeneration.GameEventRegistration
{
    internal class FlagEventRegistrationSampleMessageService : GameEventRegistrationSampleMessageService, ISampleMessageGeneration<GameEventRegistrationMessage>
    {
        public GameEventRegistrationMessage GetFilledMessage()
        {
            return base.GetFilledRegistrationMessage(GameEventMetadata.FLAG_EVENT_NAME, 0, 7);
        }
    }
}
