using HttpPost.Messages.Initialization.Binding.ColorEvent;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelSeriesGameEngine.Services.SampleMessageGeneration.GameEventBinding.ColorDefinitons
{
    public class StaticColorDefinitionGeneration
    {
        public static StaticColorDefinition GetStaticColorDefinitionFromHTML(string htmlName) 
        {
            var htmlColor = ColorTranslator.FromHtml(htmlName);
            return GetStaticColorDefinition(htmlColor);
        }

        public static StaticColorDefinition GetStaticColorDefinition(Color color)
        {
            return new StaticColorDefinition() { Red = color.R, Green = color.G, Blue = color.B };
        }
    }
}
