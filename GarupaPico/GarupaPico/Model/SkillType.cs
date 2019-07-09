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
        ScoreUp = 1,
        [EnumMember(Value = "判定強化")]
        JudgeStrength = 2,
        [EnumMember(Value = "ライフ回復")]
        LifeRecover = 3,
        [EnumMember(Value = "判定＆スコア")]
        JudgeAndScore = 4,
        [EnumMember(Value = "回復＆スコア")]
        RecoverAndScore = 5, 
        [EnumMember(Value = "回復＆判定")]
        RecoverAndJudge = 6,
        [EnumMember(Value = "(L)スコアUP")]
        LifeScoreUp = 7,
        [EnumMember(Value = "(P)スコアUP")]
        PerfectScoreUp = 8,
        [EnumMember(Value = "(L)ライフ回復")]
        LifeScoreUpOrRecover = 9,
        [EnumMember(Value = "ダメガード")]
        BadGuard = 10,
        [EnumMember(Value = "(G)スコアUP")]
        NoGreatScoreUp = 11,
    }
}
