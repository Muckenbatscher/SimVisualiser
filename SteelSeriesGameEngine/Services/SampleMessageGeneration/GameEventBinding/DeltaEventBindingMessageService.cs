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
    internal class DeltaEventBindingMessageService : ISampleMessageGeneration<BindGameEventMessage>
    {
        private readonly BindingHandlerGenerationService _bindingHandlerGeneration;

        public DeltaEventBindingMessageService()
        {
            _bindingHandlerGeneration = new BindingHandlerGenerationService();
        }

        public BindGameEventMessage GetFilledMessage()
        {
            var message = new BindGameEventMessage()
            {
                Game = GameMetadata.GAME_NAME,
                EventName = GameEventMetadata.FLAG_EVENT_NAME,
                MinValue = 0,
                MaxValue = 2000
            };
            var colorDefinitions = new RangedColorCollection(GetColorDefinitions());
            message.Handlers = _bindingHandlerGeneration.GetHandlers(colorDefinitions).ToArray();

            return message;
        }

        private static IEnumerable<RangedColor> GetColorDefinitions()
        {
            var maxPositive = GetSingleColorDefinition("#ff0000", 0, 0);
            var offMiddle = GetSingleColorDefinition("#000000", 1000, 1000);
            var maxNegative = GetSingleColorDefinition("#00ff00", 2000, 2000);

            var fadePositive = GetGradiendColorDefinition("#d11b1b", "#4d0c0c", 1, 999);
            var fadeNegative = GetGradiendColorDefinition("#0c4d1a", "#19bf3d", 1001, 1999);
            
            return new List<RangedColor>() { maxPositive, fadePositive, offMiddle, fadeNegative, maxNegative};
        }

        private static RangedColor GetSingleColorDefinition(string colorNameHex, int low, int high)
        {
            var color =  StaticColorDefinitionGeneration.GetStaticColorDefinitionFromHTML(colorNameHex);
            return new RangedColor()
            {
                Low = low,
                High = high,
                Color = color
            };
        }

        private static RangedColor GetGradiendColorDefinition(string colorNameHexLow, string ColorNameHexHigh, int low, int high)
        {
            var colorLow = StaticColorDefinitionGeneration.GetStaticColorDefinitionFromHTML(colorNameHexLow);
            var colorHigh = StaticColorDefinitionGeneration.GetStaticColorDefinitionFromHTML(colorNameHexLow);
            var colorGradient = new ColorGradient() { Zero = colorLow, Hundred = colorHigh };
            return new RangedColor()
            {
                Low = low,
                High = high,
                Color = colorGradient
            };
        }
    }
}
