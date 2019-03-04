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
        Kasumi,
        [EnumMember(Value = "花園 たえ")]
        Tae,
        [EnumMember(Value = "牛込 りみ")]
        Rimi,
        [EnumMember(Value = "山吹 沙綾")]
        Saya,
        [EnumMember(Value = "市ヶ谷 有咲")]
        Arisa,

        #endregion

        #region Afterglow

        [EnumMember(Value = "美竹 蘭")]
        Ran,
        [EnumMember(Value = "青葉 モカ")]
        Moca,
        [EnumMember(Value = "宇田川 巴")]
        Tomoe,
        [EnumMember(Value = "上原 ひまり")]
        Himari,
        [EnumMember(Value = "羽沢 つぐみ")]
        Tsugumi,

        #endregion

        #region Pastel Palettes

        [EnumMember(Value = "丸山 彩")]
        Aya,
        [EnumMember(Value = "氷川 日菜")]
        Hina,
        [EnumMember(Value = "白鷺 千聖")]
        Chisato,
        [EnumMember(Value = "大和 麻弥")]
        Maya,
        [EnumMember(Value = "若宮 イヴ")]
        Eve,

        #endregion

        #region Roselia

        [EnumMember(Value = "湊 友希那")]
        Yukina,
        [EnumMember(Value = "氷川 紗夜")]
        Sayo,
        [EnumMember(Value = "今井 リサ")]
        Lisa,
        [EnumMember(Value = "宇田川 あこ")]
        Ako,
        [EnumMember(Value = "白金 燐子")]
        Rinko,

        #endregion

        #region Hello Happy world

        [EnumMember(Value = "弦巻 こころ")]
        Kokoro,
        [EnumMember(Value = "瀬田 薫")]
        Kaoru,
        [EnumMember(Value = "松原 花音")]
        Kanon,
        [EnumMember(Value = "北沢 はぐみ")]
        Hagumi,
        [EnumMember(Value = "奥沢 美咲")]
        Misaki

        #endregion
    }
}
