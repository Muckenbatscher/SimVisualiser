using HttpPost.Messages.Finalization;
using HttpPost.Messages.Initialization;
using SteelSeriesGameEngine.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelSeriesGameEngine.Services.SampleMessageGeneration.GameEventRegistration
{
    internal class UnregisterGameEventSampleMessageService
    {
        internal UnregisterGameEventMessage GetFilledUnregistrationMessage(string eventName)
        {
            return new UnregisterGameEventMessage()
            {
                Game = GameMetadata.GAME_NAME,
                EventName = eventName,
            };
        }
    }
}
