using SimDataReadingCore.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDataReadingCore.Events
{
    public class ActiveSimChangedEventArgs : EventArgs
    {
        ActiveSimulator ActiveSim { get; set; }

        public ActiveSimChangedEventArgs(ActiveSimulator activeSim)
        {
            ActiveSim = activeSim;
        }
    }
}
