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
    internal class DeltaEventTriggerService : GameEventTriggerService, IGameEventTriggerService<TimeSpan>
    {
        private static readonly string GameEventName = GameEventMetadata.DELTA_EVENT_NAME;
        public DeltaEventTriggerService(TargetAddress baseAddress) : base(baseAddress, GameEventName)
        {
        }

        public void TriggerGameEventValue(TimeSpan value)
        {
            int deltaValue = GetValueForTimespan(value);
            SendEvent(deltaValue);
        }

        public async Task TriggerGameEventValueAsync(TimeSpan deltaTime)
        {
            int deltaValue = GetValueForTimespan(deltaTime);
            await SendEventAsync((int)deltaValue);
        }

        private static int GetValueForTimespan(TimeSpan deltaTime)
        {
            if (deltaTime.TotalMilliseconds > 1000)
                return 0;
            else if (deltaTime.TotalMilliseconds < -1000)
                return 2000;
            else
                return 1000 - (int)deltaTime.TotalMilliseconds;
        }
    }
}
