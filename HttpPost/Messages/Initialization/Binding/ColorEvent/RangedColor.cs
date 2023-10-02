using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HttpPost.Messages.Initialization.Binding.ColorEvent
{
    public class RangedColor
    {
        [JsonPropertyName("low")]
        public int Low { get; set; }
        [JsonPropertyName("high")]
        public int High { get; set; }
        [JsonPropertyName("color")]
        public ColorDefinition Color { get; set; }
    }
}
