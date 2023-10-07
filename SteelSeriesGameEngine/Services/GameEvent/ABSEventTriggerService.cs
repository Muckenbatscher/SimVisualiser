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
    internal class ABSEventTriggerService : GameEventTriggerService, IGameEventTriggerService<bool>
    {
        private static readonly string GameEventName = GameEventMetadata.ABS_ACTIVE_EVENT_NAME;
        public ABSEventTriggerService(TargetAddress baseAddress) : base(baseAddress, GameEventName)
        {
        }

        public void TriggerGameEventValue(bool active)
        {
            int activeValue = GetValueForActive(active);
            SendEvent(activeValue);
        }

        public async Task TriggerGameEventValueAsync(bool active)
        {
            int activeValue = GetValueForActive(active);
            await SendEventAsync(activeValue);
        }

        private static int GetValueForActive(bool active)
        {
            return active ? 1 : 0; ;
        }
    }
}
