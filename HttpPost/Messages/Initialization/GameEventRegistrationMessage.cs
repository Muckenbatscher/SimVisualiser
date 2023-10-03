using HttpPost.Messages.Initialization.Binding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HttpPost.Messages.Initialization
{
    [JsonDerivedType(typeof(BindGameEventMessage))]
    public class GameEventRegistrationMessage : GameSenseMessage
    {
        [JsonPropertyName("event")]
        public string EventName { get; set; }
        [JsonPropertyName("min_value")]
        public int? MinValue { get; set; }
        [JsonPropertyName("max_value")]
        public int? MaxValue { get; set; }
    }
}
