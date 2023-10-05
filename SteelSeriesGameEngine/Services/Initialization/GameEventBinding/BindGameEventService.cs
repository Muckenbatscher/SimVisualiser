using HttpPost.EndPoints.Initialization;
using HttpPost.Messages.Initialization;
using HttpPost.Messages.Initialization.Binding;
using SteelSeriesGameEngine.Interfaces;
using SteelSeriesGameEngine.Models;
using SteelSeriesGameEngine.Services.SampleMessageGeneration.GameEventBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelSeriesGameEngine.Services.Initialization.GameEventBinding
{
    internal class BindGameEventService
    {
        private readonly IBindGameEventService _flagBindingService;
        private readonly IBindGameEventService _deltaBindingService;

        public BindGameEventService(TargetAddress baseAddress) 
        {
            _flagBindingService = new BindFlagGameEventService(baseAddress);
            _deltaBindingService = new BindDeltaGameEventService(baseAddress);
        }

        public async Task BindAllEventsAsync()
        {
            await _flagBindingService.BindEventAsync();
            await _deltaBindingService.BindEventAsync();
        }
        public void BindAllEvents()
        {
            _flagBindingService.BindEvent();
            _deltaBindingService.BindEvent();
        }

    }
}
