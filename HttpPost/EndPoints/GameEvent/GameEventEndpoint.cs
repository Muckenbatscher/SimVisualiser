using HttpPost.Interfaces;
using HttpPost.Messages.GameEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HttpPost.EndPoints.GameEvent
{
    public class GameEventEndpoint : BaseEndpoint, IEndpoint<GameEventMessage>, IDisposable
    {
        private static string _endPoint = "game_event ";
        public GameEventEndpoint(string baseAddress) : base(baseAddress, _endPoint)
        {
        }

        
        public async Task<bool> PostMessageAsync(GameEventMessage message)
        {
            return await SerializeAndPostMessageAsync(message);
        }
        public bool PostMessage(GameEventMessage message)
        {
            return SerializeAndPostMessage(message);
        }

    }
}
