using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SteelSeriesGameEngine.Models.Json
{
    internal class CoreProps
    {
        [JsonPropertyName("address")]
        public string Address { get; set; }
        [JsonPropertyName("encryptedAddress")]
        public string EncryptedAddress { get; set; }
        [JsonPropertyName("ggEncryptedAddress")]
        public string GgEncryptedAddress { get; set; }
    }
}
