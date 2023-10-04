using HttpPost.Interfaces;
using HttpPost.Messages.Initialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HttpPost.EndPoints.Initialization
{
    public class GameEventRegistrationEndpoint : BaseEndpoint, IEndpoint<GameEventRegistrationMessage>, IDisposable
    {
        private static string _endPoint = "register_game_event ";
        public GameEventRegistrationEndpoint(string baseAddress) : base(baseAddress, _endPoint)
        {
        }

        public async Task<bool> PostMessageAsync(GameEventRegistrationMessage message)
        {
            return await SerializeAndPostMessageAsync(message);
        }
        public bool PostMessage(GameEventRegistrationMessage message)
        {
            return SerializeAndPostMessage(message);
        }

    }
}
