using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using HttpPost.Messages.Initialization.Binding;

namespace HttpPost.Messages.Initialization.Binding.ColorEvent
{
    public class ColorGameEventHandler : GameEventHandler
    {
        [JsonPropertyName("color")]
        public ColorDefinition? Color { get; set; }
    }
}
