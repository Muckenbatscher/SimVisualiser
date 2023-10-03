using HttpPost.Messages.Initialization.Binding;
using HttpPost.Messages.Initialization.Binding.ColorEvent;
using SteelSeriesGameEngine.Enumerations;
using SteelSeriesGameEngine.Models;
using SteelSeriesGameEngine.Services.SampleMessageGeneration.GameEventBinding.ZonePermutationGeneration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelSeriesGameEngine.Services.SampleMessageGeneration.GameEventBinding
{
    public class BindingHandlerGenerationService
    {
        private readonly SupportedZonePermutationsService _zoneService;

        public BindingHandlerGenerationService()
        {
            _zoneService = new SupportedZonePermutationsService();
        }


        public IEnumerable<GameEventHandler> GetHandlers(ColorDefinition colorDefinition)
        {
            var handlers = GetPrefilledHandlersForDevices();
            foreach (var handler in handlers)
            {
                handler.Color = colorDefinition;
            }
            return handlers;
        }

        private IEnumerable<ColorGameEventHandler> GetPrefilledHandlersForDevices()
        {
            var handlers = new List<ColorGameEventHandler>();
            var zones = _zoneService.GetAllSupportedPermutations();
            foreach (var zone in zones)
            {
                handlers.Add(GetPrefilledHandler(zone));
            }
            return handlers;
        }

        private static ColorGameEventHandler GetPrefilledHandler(DeviceZonePermutation zonePermutation)
        {
            return new ColorGameEventHandler()
            {
                DeviceType = zonePermutation.DeviceType,
                Zone = zonePermutation.ZoneName,
                Mode = VisualizationMode.Color
            };
        }
    }
}
