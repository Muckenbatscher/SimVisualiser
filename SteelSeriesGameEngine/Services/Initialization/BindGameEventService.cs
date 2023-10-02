using HttpPost.EndPoints.Initialization;
using SteelSeriesGameEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelSeriesGameEngine.Services.Initialization
{
    internal class BindGameEventService : GameSenseServiceBase
    {
        private readonly BindGameEventEndpoint _endPoint;
        public BindGameEventService(TargetAddress baseAddress) : base(baseAddress)
        {
            _endPoint = new BindGameEventEndpoint(baseAddress.GetURL());
        }
    }
}
