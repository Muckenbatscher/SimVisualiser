using HttpPost.Messages.Initialization.Binding;
using HttpPost.Messages.Initialization.Binding.ColorEvent;
using SimDataReadingCore.Enumerations;
using SteelSeriesGameEngine.Constants;
using SteelSeriesGameEngine.Interfaces;
using SteelSeriesGameEngine.Services.SampleMessageGeneration.GameEventBinding.ColorDefinitons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelSeriesGameEngine.Services.SampleMessageGeneration.GameEventBinding
{
    internal class ABSEventBindingMessageService : ISampleMessageGeneration<BindGameEventMessage>
    {
        private readonly BindingHandlerGenerationService _bindingHandlerGeneration;

        public ABSEventBindingMessageService()
        {
            _bindingHandlerGeneration = new BindingHandlerGenerationService();
        }

        public BindGameEventMessage GetFilledMessage()
        {
            var message = new BindGameEventMessage()
            {
                Game = GameMetadata.GAME_NAME,
                EventName = GameEventMetadata.ABS_ACTIVE_EVENT_NAME,
                MinValue = 0,
                MaxValue = 1
            };
            var colorDefnition = new RangedColorCollection(GetColorDefinitions());
            message.Handlers = _bindingHandlerGeneration.GetHandlers(colorDefnition).ToArray();
            return message;
        }

        private static IEnumerable<RangedColor> GetColorDefinitions()
        {
            var inactive = GetColorDefinition(false);
            var active = GetColorDefinition(true);

            return new List<RangedColor>() { inactive, active };
        }

        private static RangedColor GetColorDefinition(bool isActive)
        {
            var colorName = GetColorNameHex(isActive);
            var color = StaticColorDefinitionGeneration.GetStaticColorDefinitionFromHTML(colorName);
            int activeValue = isActive ? 1 : 0;
            return new RangedColor() { Low = activeValue, High = activeValue, Color = color };
        }

        private static string GetColorNameHex(bool isActive)
        {
            if (isActive)
                return "#eda71a";
            else
                return "#000000";
        }

    }
}
