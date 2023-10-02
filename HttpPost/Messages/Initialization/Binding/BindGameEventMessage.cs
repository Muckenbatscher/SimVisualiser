using HttpPost.Messages.Initialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HttpPost.Messages.Initialization.Binding
{
    public class BindGameEventMessage : GameEventRegistrationMessage
    {
        [JsonPropertyName("handlers")]
        public GameEventHandler[] Handlers { get; set; }
    }
}
