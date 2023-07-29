using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpPost.EndPoints
{
    internal abstract class BaseEndpoint : IDisposable
    {
        private string BaseAddress { get; set; }
        protected string EndPoint { get; set; }

        private HttpClient _client;

        protected BaseEndpoint(string baseAddress, string endPoint)
        {
            BaseAddress = baseAddress;
            EndPoint = endPoint;
            _client = new HttpClient();
        }

        protected void PostMessage(string message)
        {
            string endPointAddress = $"{BaseAddress}/{EndPoint}";
            var content = new StringContent(message);
            _client.PostAsync(endPointAddress, content);
        }

        public void Dispose()
        {
            _client?.Dispose();
        }
    }
}
