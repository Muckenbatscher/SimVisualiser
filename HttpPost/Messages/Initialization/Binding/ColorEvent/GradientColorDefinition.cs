using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HttpPost.Messages.Initialization.Binding.ColorEvent
{
    public class GradientColorDefinition : ColorDefinition
    {
        [JsonPropertyName("gradient")]
        public ColorGradient Gradient { get; set; }
    }
}
