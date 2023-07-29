using HttpPost.Interfaces;
using HttpPost.Messages.GameEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            await base.SerializeAndPostMessageAsync(message);
        }
    }
}
