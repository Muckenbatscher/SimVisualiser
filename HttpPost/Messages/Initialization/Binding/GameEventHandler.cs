using HttpPost.Messages.Initialization.Binding.ColorEvent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HttpPost.Messages.Initialization.Binding
{

    [JsonDerivedType(typeof(ColorGameEventHandler))]
    public abstract class GameEventHandler
    {
        [JsonPropertyName("device-type")]
        public string DeviceType { get; set; }
        [JsonPropertyName("zone")]
        public string Zone { get; set; }
        [JsonPropertyName("mode")]
        public string Mode { get; set; }
    }
}
