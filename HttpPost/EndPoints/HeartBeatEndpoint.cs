using HttpPost.Interfaces;
using HttpPost.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HttpPost.EndPoints
{
    internal class HeartBeatEndpoint : BaseEndpoint, IEndpoint<HeartBeatMessage>, IDisposable
    {
        private static string _endPoint = "game_heartbeat";
        public HeartBeatEndpoint(string baseAddress) : base(baseAddress, _endPoint)
        {
        }

        public async Task PostMessageAsync(HeartBeatMessage message)
        {
            await SerializeAndPostMessageAsync(message);
        }
    }
}
