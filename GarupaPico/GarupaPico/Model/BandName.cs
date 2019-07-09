using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GarupaPico.Model
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BandName
    {
        [EnumMember(Value = "Poppin'Party")]
        PoppinParty,
        Afterglow,
        [EnumMember(Value = "Pastel*Palettes")]
        PastelPalettes,
        Roselia,
        [EnumMember(Value = "Hello, Happy World!")]
        HelloHappyWorld
    }
}
