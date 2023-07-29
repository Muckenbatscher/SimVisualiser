using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HttpPost.Messages
{
    public class RegistrationMessage : GameSenseMessage
    {
        [JsonPropertyName("game_display_name")]
        public string GameDisplayName { get; set; }
        [JsonPropertyName("developer")]
        public string Developer { get; set; }
    }
}
