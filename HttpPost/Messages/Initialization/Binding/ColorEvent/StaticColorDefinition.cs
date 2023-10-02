using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HttpPost.Messages.Initialization.Binding.ColorEvent
{
    public class StaticColorDefinition : ColorDefinition
    {
        [JsonPropertyName("red")]
        public byte Red { get; set; }

        [JsonPropertyName("green")]
        public byte Green { get; set; }
        [JsonPropertyName("blue")]
        public byte Blue { get; set; }
    }
}
