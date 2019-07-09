using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GarupaPico.Model
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MemberName
    {
        #region Poppin'Party

        [EnumMember(Value = "戸山 香澄")]
        Kasumi = 1,
        [EnumMember(Value = "花園 たえ")]
        Tae = 2,
        [EnumMember(Value = "牛込 りみ")]
        Rimi = 3,
        [EnumMember(Value = "山吹 沙綾")]
        Saya = 4,
        [EnumMember(Value = "市ヶ谷 有咲")]
        Arisa = 5,

        #endregion

        #region Afterglow

        [EnumMember(Value = "美竹 蘭")]
        Ran = 6,
        [EnumMember(Value = "青葉 モカ")]
        Moc = 7,
        [EnumMember(Value = "上原 ひまり")]
        Himari = 8,
        [EnumMember(Value = "宇田川 巴")]
        Tomoe = 9,
        [EnumMember(Value = "羽沢 つぐみ")]
        Tsugumi = 10,

        #endregion

        #region Hello Happy world

        [EnumMember(Value = "弦巻 こころ")]
        Kokoro = 11,
        [EnumMember(Value = "瀬田 薫")]
        Kaoru = 12,
        [EnumMember(Value = "北沢 はぐみ")]
        Hagumi = 13,
        [EnumMember(Value = "松原 花音")]
        Kanon = 14,
        [EnumMember(Value = "奥沢 美咲")]
        Misaki = 15,

        #endregion

        #region Pastel Palettes

        [EnumMember(Value = "丸山 彩")]
        Aya = 16,
        [EnumMember(Value = "氷川 日菜")]
        Hina = 17,
        [EnumMember(Value = "白鷺 千聖")]
        Chisato = 18,
        [EnumMember(Value = "大和 麻弥")]
        Maya = 19,
        [EnumMember(Value = "若宮 イヴ")]
        Eve = 20,

        #endregion

        #region Roselia

        [EnumMember(Value = "湊 友希那")]
        Yukina = 21,
        [EnumMember(Value = "氷川 紗夜")]
        Sayo = 22,
        [EnumMember(Value = "今井 リサ")]
        Lisa = 23,
        [EnumMember(Value = "宇田川 あこ")]
        Ako = 24,
        [EnumMember(Value = "白金 燐子")]
        Rinko = 25

        #endregion
    }
}
