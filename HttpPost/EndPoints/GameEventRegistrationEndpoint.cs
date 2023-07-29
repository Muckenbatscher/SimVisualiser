using HttpPost.Interfaces;
using HttpPost.Messages.GameEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HttpPost.EndPoints
{
    public class GameEventRegistrationEndpoint : BaseEndpoint, IEndpoint<GameEventRegistrationMessage>, IDisposable
    {
        private static string _endPoint = "register_game_event ";
        public GameEventRegistrationEndpoint(string baseAddress) : base(baseAddress, _endPoint)
        {
        }

        public async Task PostMessageAsync(GameEventRegistrationMessage message)
        {
            string messageText = JsonSerializer.Serialize(message);
            await PostMessageAsync(messageText);
        }
    }
}
