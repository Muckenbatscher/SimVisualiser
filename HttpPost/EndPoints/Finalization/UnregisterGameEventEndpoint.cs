using HttpPost.Interfaces;
using HttpPost.Messages.Finalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpPost.EndPoints.Finalization
{
    public class UnregisterGameEventEndpoint : BaseEndpoint, IEndpoint<UnregisterGameEventMessage>, IDisposable
    {
        private static string _endPoint = "remove_game_event";
        public UnregisterGameEventEndpoint(string baseAddress) : base(baseAddress, _endPoint)
        {
        }

        public async Task<bool> PostMessageAsync(UnregisterGameEventMessage message)
        {
            bool success = await SerializeAndPostMessageAsync(message);
            return success;
        }
    }
}
