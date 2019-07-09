using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GarupaPico.Model
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SkillType
    {
        [EnumMember(Value = "スコアUP")]
        ScoreUp,
        [EnumMember(Value = "(L)スコアUP")]
        LargeScoreUp,
        [EnumMember(Value = "(P)スコアUP")]
        PerfectScoreUp,
        [EnumMember(Value = "ライフ回復")]
        HpRecover,
        [EnumMember(Value = "判定強化")]
        JudgeStrength,
        [EnumMember(Value = "判定＆スコア")]
        JudgeAndScore,
        [EnumMember(Value = "ダメガード")]
        BadGuard
    }
}
