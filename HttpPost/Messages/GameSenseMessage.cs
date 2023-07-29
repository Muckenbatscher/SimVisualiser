using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HttpPost.Messages
{
    public abstract class GameSenseMessage
    {
        [JsonPropertyName("game")]
        public string Game { get; set; }
    }
}
