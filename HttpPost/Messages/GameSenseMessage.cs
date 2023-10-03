using HttpPost.Messages.Finalization;
using HttpPost.Messages.GameEvents;
using HttpPost.Messages.Heartbeat;
using HttpPost.Messages.Initialization;
using HttpPost.Messages.Initialization.Binding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HttpPost.Messages
{
    [JsonDerivedType(typeof(GameRegistrationMessage))]
    [JsonDerivedType(typeof(GameEventRegistrationMessage))]
    [JsonDerivedType(typeof(BindGameEventMessage))]
    [JsonDerivedType(typeof(UnregisterGameMessage))]
    [JsonDerivedType(typeof(UnregisterGameEventMessage))]
    [JsonDerivedType(typeof(StopGameMessage))]
    [JsonDerivedType(typeof(GameEventMessage))]
    [JsonDerivedType(typeof(HeartBeatMessage))]
    public abstract class GameSenseMessage
    {
        [JsonPropertyName("game")]
        public string Game { get; set; }
    }
}
