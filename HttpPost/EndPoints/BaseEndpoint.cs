using HttpPost.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
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

        protected async Task<bool> SerializeAndPostMessageAsync(GameSenseMessage message)
        {
            var httpMessage = GetHttpPostRequestMessage(message);
            var response = await _client.SendAsync(httpMessage);
            return response.IsSuccessStatusCode;
        }
        protected bool SerializeAndPostMessage(GameSenseMessage message)
        {
            var httpMessage = GetHttpPostRequestMessage(message);
            var response = _client.Send(httpMessage);
            return response.IsSuccessStatusCode;
        }

        private HttpRequestMessage GetHttpPostRequestMessage(GameSenseMessage message)
        {
            var uri = GetEndPointUri();
            var httpMessage = new HttpRequestMessage(HttpMethod.Post, uri)
            {
                Content = GetMessageContent(message)
            };
            return httpMessage;
        }

        private Uri GetEndPointUri()
        {
            string endPointAddress = $"http://{BaseAddress}/{EndPoint}";
            return new Uri(endPointAddress);
        }

        private static StringContent GetMessageContent(GameSenseMessage message)
        {
            string serialized = SerializeMessage(message);
            return new StringContent(serialized, Encoding.ASCII, "application/json");
        }
        private static string SerializeMessage(GameSenseMessage message)
        {
            JsonSerializerOptions options = new()
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            };
            var serialized = JsonSerializer.Serialize(message, options);
            return serialized;
        }

        public void Dispose()
        {
            _client?.Dispose();
        }
    }
}
