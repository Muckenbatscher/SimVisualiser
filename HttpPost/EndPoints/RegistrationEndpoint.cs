using HttpPost.Interfaces;
using HttpPost.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HttpPost.EndPoints
{
    internal class RegistrationEndpoint : BaseEndpoint, IEndpoint<RegistrationMessage>
    {
        private static string _endPoint = "game_metadata";
        public RegistrationEndpoint(string baseAddress) : base(baseAddress, _endPoint)
        {
        }

        public void PostMessage(RegistrationMessage message)
        {
            string messageText = JsonSerializer.Serialize(message);
            PostMessage(messageText);
        }
    }
}
