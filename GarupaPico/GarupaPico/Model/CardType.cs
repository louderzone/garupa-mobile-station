using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GarupaPico.Model
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CardType
    {
        [EnumMember(Value = "パワフル")]
        Powerful,
        [EnumMember(Value = "ピュア")]
        Pure,
        [EnumMember(Value = "クール")]
        Cool,
        [EnumMember(Value = "ハッピー")]
        Happy
    }
}
