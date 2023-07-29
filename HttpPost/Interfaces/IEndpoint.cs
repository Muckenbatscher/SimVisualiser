using HttpPost.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpPost.Interfaces
{
    internal interface IEndpoint<M> where M : GameSenseMessage
    {
        Task<bool> PostMessageAsync(M message);
    }
}
