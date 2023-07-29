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
    public class GameRegistrationEndpoint : BaseEndpoint, IEndpoint<GameRegistrationMessage>, IDisposable
    {
        private static string _endPoint = "game_metadata";
        public GameRegistrationEndpoint(string baseAddress) : base(baseAddress, _endPoint)
        {
        }

        public async Task PostMessageAsync(GameRegistrationMessage message)
        {
            string messageText = JsonSerializer.Serialize(message);
            await PostMessageAsync(messageText);
        }
    }
}
