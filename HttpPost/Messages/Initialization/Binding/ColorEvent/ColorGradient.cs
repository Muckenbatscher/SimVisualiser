using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HttpPost.Messages.Initialization.Binding.ColorEvent
{
    public class ColorGradient : ColorDefinition
    {
        [JsonPropertyName("zero")]
        public StaticColorDefinition Zero { get; set; }
        [JsonPropertyName("hundred")]
        public StaticColorDefinition Hundred { get; set; }
    }
}
