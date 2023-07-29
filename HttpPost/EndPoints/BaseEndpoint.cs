using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HttpPost.EndPoints
{
    public abstract class BaseEndpoint : IDisposable
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

        protected async Task<bool> PostMessageAsync(string message)
        {
            string endPointAddress = $"http://{BaseAddress}/{EndPoint}";
            var uri = new Uri(endPointAddress);
            var content = new StringContent(message, Encoding.ASCII, "application/json");
            var response =  await _client.PostAsync(uri, content);
            return response.IsSuccessStatusCode;
        }

        public void Dispose()
        {
            _client?.Dispose();
        }
    }
}
