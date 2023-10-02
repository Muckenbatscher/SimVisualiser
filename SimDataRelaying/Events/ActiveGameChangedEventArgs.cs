using SimDataReadingCore.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDataReadingCore.Events
{
    internal class ActiveGameChangedEventArgs : EventArgs
    {
        ActiveSimulator ActiveSim { get; set; }

        public ActiveGameChangedEventArgs(ActiveSimulator activeSim)
        {
            ActiveSim = activeSim;
        }
    }
}
