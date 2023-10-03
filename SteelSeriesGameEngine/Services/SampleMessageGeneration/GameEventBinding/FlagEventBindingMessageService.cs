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
    public class FlagEventBindingMessageService : ISampleMessageGeneration<BindGameEventMessage>
    {
        private readonly BindingHandlerGenerationService _bindingHandlerGeneration;

        public FlagEventBindingMessageService()
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
                MaxValue = 7
            };
            var colorDefnition = new RangedColorCollection(GetColorDefinitions());
            message.Handlers = _bindingHandlerGeneration.GetHandlers(colorDefnition).ToArray();
            return message;
        }

        private static IEnumerable<RangedColor> GetColorDefinitions()
        {
            var none = GetColorDefinitionForFlag(Flag.None);
            var yellow = GetColorDefinitionForFlag(Flag.YellowFlag);
            var blue = GetColorDefinitionForFlag(Flag.BlueFlag);
            var green = GetColorDefinitionForFlag(Flag.GreenFlag);
            var white = GetColorDefinitionForFlag(Flag.WhiteFlag);
            var checkered = GetColorDefinitionForFlag(Flag.CheckeredFlag);
            var black = GetColorDefinitionForFlag(Flag.BlackFlag);
            var orange = GetColorDefinitionForFlag(Flag.OrangeFlag);

            return new List <RangedColor>() { none, yellow, blue, green, white, checkered, black, orange };
        }


        private static RangedColor GetColorDefinitionForFlag(Flag flag)
        {
            var colorName = GetFlagColorNameHex(flag);
            var color = StaticColorDefinitionGeneration.GetStaticColorDefinitionFromHTML(colorName);
            int flagValue = (int)flag;
            return new RangedColor() { Low = flagValue, High = flagValue, Color = color };
        }

        private static string GetFlagColorNameHex(Flag flag) 
        {
            switch (flag)
            {
                case Flag.YellowFlag:
                    return "#f2ff00";
                case Flag.BlueFlag:
                    return "#f2ff00";
                case Flag.GreenFlag:
                    return "#0010ff";
                case Flag.WhiteFlag:
                    return "#ffffff";
                case Flag.CheckeredFlag:
                    return "#575757";
                case Flag.BlackFlag:
                    return "#000000";
                case Flag.OrangeFlag:
                    return "#db4403";

                default:
                    return "#000000";
            }
        }

    }
}
