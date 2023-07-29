using HttpPost.Interfaces;
using HttpPost.Messages.Finalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpPost.EndPoints.Finalization
{
    public class UnregisterGameEndpoint : BaseEndpoint, IEndpoint<UnregisterGameMessage>, IDisposable
    {
        private static string _endPoint = "remove_game";
        public UnregisterGameEndpoint(string baseAddress) : base(baseAddress, _endPoint)
        {
        }

        public async Task<bool> PostMessageAsync(UnregisterGameMessage message)
        {
            return await SerializeAndPostMessageAsync(message);
        }
    }
}
