using HttpPost.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelSeriesGameEngine.Interfaces
{
    internal interface ISampleMessageGeneration<M> where M : GameSenseMessage
    {
        M GetFilledMessage();
    }
}
