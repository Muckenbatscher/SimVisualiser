using HttpPost.Interfaces;
using HttpPost.Messages.Finalization;
using HttpPost.Messages.GameEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpPost.EndPoints.Finalization
{
    public class StopGameEndpoint : BaseEndpoint, IEndpoint<StopGameMessage>, IDisposable
    {
        private static string _endPoint = "stop_game";
        public StopGameEndpoint(string baseAddress) : base(baseAddress, _endPoint)
        {
        }

        public async Task<bool> PostMessageAsync(StopGameMessage message)
        {
            return await SerializeAndPostMessageAsync(message);
        }
        public bool PostMessage(StopGameMessage message)
        {
            return SerializeAndPostMessage(message);
        }
    }
}
