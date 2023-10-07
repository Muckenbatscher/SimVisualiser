using SimDataReadingCore.Enumerations;
using SteelSeriesGameEngine.Constants;
using SteelSeriesGameEngine.Interfaces;
using SteelSeriesGameEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelSeriesGameEngine.Services.GameEvent
{
    internal class FlagEventTriggerService : GameEventTriggerService, IGameEventTriggerService<Flag>
    {
        private static readonly string GameEventName = GameEventMetadata.FLAG_EVENT_NAME;
        public FlagEventTriggerService(TargetAddress baseAddress) : base(baseAddress, GameEventName)
        {
        }

        public void TriggerGameEventValue(Flag value)
        {
            SendEvent((int)value);
        }

        public async Task TriggerGameEventValueAsync(Flag value)
        {
            await SendEventAsync((int)value);
        }
    }
}
