using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortListener.EventsArgs
{
    public class MessageReceivedEventArgs : EventArgs
    {
        public string MessageDecoded { get => Encoding.ASCII.GetString(MessageBytes, 0, MessageBytes.Length); }
        public byte[] MessageBytes { get; private set; }

        public MessageReceivedEventArgs(byte[] bytes)
        {
            MessageBytes = bytes;
        }

    }
}
