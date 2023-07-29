﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HttpPost.Messages.GameEvents
{
    public class GameEventMessage : GameSenseMessage
    {
        [JsonPropertyName("event")]
        public string EventName { get; set; }
        [JsonPropertyName("data")]
        public GameEventData Data { get; set; }
    }
}
