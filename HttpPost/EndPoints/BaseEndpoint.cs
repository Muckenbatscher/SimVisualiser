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
            string endPointAddress = $"http://{BaseAddress}/{EndPoint}";
            var uri = new Uri(endPointAddress);

            string serialized = SerializeMessage(message);
            var content = new StringContent(serialized, Encoding.ASCII, "application/json");

            var response =  await _client.PostAsync(uri, content);
            return response.IsSuccessStatusCode;
        }

        private string SerializeMessage(GameSenseMessage message)
        {
            JsonSerializerOptions options = new()
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            };
            return JsonSerializer.Serialize(message, options);
        }

        public void Dispose()
        {
            _client?.Dispose();
        }
    }
}
