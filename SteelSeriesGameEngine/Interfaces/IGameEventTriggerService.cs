using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelSeriesGameEngine.Interfaces
{
    internal interface IGameEventTriggerService<V> 
    {
        void TriggerGameEventValue(V value);
        Task TriggerGameEventValueAsync(V value);
    }
}
