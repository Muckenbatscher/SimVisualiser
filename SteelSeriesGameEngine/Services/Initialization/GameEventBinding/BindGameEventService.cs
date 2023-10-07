using SteelSeriesGameEngine.Interfaces;
using SteelSeriesGameEngine.Models;
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
        private readonly IBindGameEventService _tcBindingService;
        private readonly IBindGameEventService _absBindingService;

        public BindGameEventService(TargetAddress baseAddress) 
        {
            _flagBindingService = new BindFlagGameEventService(baseAddress);
            _deltaBindingService = new BindDeltaGameEventService(baseAddress);
            _tcBindingService = new BindTCGameEventService(baseAddress);
            _absBindingService = new BindABSGameEventService(baseAddress);
        }

        public async Task BindAllEventsAsync()
        {
            await _flagBindingService.BindEventAsync();
            await _deltaBindingService.BindEventAsync();
            await _tcBindingService.BindEventAsync();
            await _absBindingService.BindEventAsync();
        }
        public void BindAllEvents()
        {
            _flagBindingService.BindEvent();
            _deltaBindingService.BindEvent();
            _tcBindingService.BindEvent();
            _absBindingService.BindEvent();
        }

    }
}
