using SteelSeriesGameEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelSeriesGameEngine.Services
{
    internal abstract class GameSenseServiceBase
    {
        protected TargetAddress BaseAddress;

        protected GameSenseServiceBase(TargetAddress baseAddress)
        {
            BaseAddress = baseAddress;
        }
    }
}
