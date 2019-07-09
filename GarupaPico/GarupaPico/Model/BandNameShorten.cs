using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GarupaPico.Model
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BandNameShorten
    {
        [EnumMember(Value = "Poppin'Party")]
        PPP,
        [EnumMember(Value = "Afterglow")]
        AG,
        [EnumMember(Value = "Pastel*Palettes")]
        PP,
        [EnumMember(Value = "Roselia")]
        R,
        [EnumMember(Value = "Hello, Happy World!")]
        HHW
    }
}
