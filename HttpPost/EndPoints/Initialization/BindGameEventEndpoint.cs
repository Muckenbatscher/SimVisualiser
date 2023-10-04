using HttpPost.Interfaces;
using HttpPost.Messages.GameEvents;
using HttpPost.Messages.Initialization.Binding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpPost.EndPoints.Initialization
{
    public class BindGameEventEndpoint : BaseEndpoint, IEndpoint<BindGameEventMessage>, IDisposable
    {
        private static readonly string _endPoint = "bind_game_event ";
        public BindGameEventEndpoint(string baseAddress) : base(baseAddress, _endPoint)
        {
        }

        public async Task<bool> PostMessageAsync(BindGameEventMessage message)
        {
            return await SerializeAndPostMessageAsync(message);
        }
        public bool PostMessage(BindGameEventMessage message)
        {
            return SerializeAndPostMessage(message);
        }

    }
}
