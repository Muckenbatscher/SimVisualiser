using PortListener.EventsArgs;
using System.Net;
using System.Net.Sockets;

namespace PortListener
{
    public class UDPListener :IDisposable
    {
        public int Port { get; private set; }

        public event EventHandler<MessageReceivedEventArgs> MessageReceived;

        private UdpClient _listener;

        public UDPListener(int port)
        {
            Port = port;
            Listen();
        }

        private async void Listen()
        {
            _listener = new UdpClient(Port);
            IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, Port);

            try
            {
                while (true)
                {
                    var received = await _listener.ReceiveAsync();
                    var args = new MessageReceivedEventArgs(received.Buffer);
                    MessageReceived?.Invoke(this, args);
                }
            }
            finally
            {
                _listener.Close();
            }
        }

        public void Dispose()
        {
            _listener.Dispose();
        }
    }
}