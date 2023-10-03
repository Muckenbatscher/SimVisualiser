using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HttpPost.Messages.Initialization.Binding.ColorEvent
{
    [JsonDerivedType(typeof(StaticColorDefinition))]
    [JsonDerivedType(typeof(ColorGradient))]
    [JsonDerivedType(typeof(RangedColorCollection))]
    public abstract class ColorDefinition
    {
    }
}
