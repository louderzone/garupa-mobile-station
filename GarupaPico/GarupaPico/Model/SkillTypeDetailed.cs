using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GarupaPico.Model
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SkillTypeDetailed
    {
        [EnumMember(Value = "スコア10%ＵＰ")]
        ScoreUp_10 = 1,
        [EnumMember(Value = "スコア30%ＵＰ")]
        ScoreUp_30 = 2,
        [EnumMember(Value = "スコア60%ＵＰ")]
        ScoreUp_60 = 3,
        [EnumMember(Value = "スコア100%ＵＰ")]
        ScoreUp_100 = 4,
        [EnumMember(Value = "判定強化(中)＆スコア10%ＵＰ")]
        Judge_Mid_ScoreUp_10 = 5,
        [EnumMember(Value = "判定強化(大)＆スコア20%ＵＰ")]
        Judge_Big_ScoreUp_20 = 6,
        [EnumMember(Value = "判定強化(特大)＆スコア40%ＵＰ")]
        Judge_ExBig_ScoreUp_40 = 7,
        [EnumMember(Value = "ライフ300回復＆スコア10%ＵＰ")]
        LifeRecover_300_ScoreUp_10 = 8,
        [EnumMember(Value = "ライフ450回復＆スコア20%ＵＰ")]
        LifeRecover_450_ScoreUp_20 = 9,
        [EnumMember(Value = "ライフ750回復＆スコア40%ＵＰ")]
        LifeRecover_750_ScoreUp_40 = 10,
        [EnumMember(Value = "判定強化(中)＆スコア30%ＵＰ")]
        Judge_Mid_ScoreUp_30 = 11,
        [EnumMember(Value = "判定強化(大)＆スコア60%ＵＰ")]
        Judge_Big_ScoreUp_60 = 12,
        [EnumMember(Value = "ライフ300回復＆スコア30%ＵＰ")]
        LifeRecover_300_ScoreUp_30 = 13,
        [EnumMember(Value = "ライフ450回復＆スコア60%ＵＰ")]
        LifeRecover_450_ScoreUp_60 = 14,
        [EnumMember(Value = "ライフ300回復＆判定強化(中)	")]
        LifeRecover_300_Judge_Mid = 15,
        [EnumMember(Value = "ライフ450回復＆判定強化(大)")]
        LifeRecover_450_Judge_Mid = 16,
        [EnumMember(Value = "ライフ900以上でスコア65%UP | ライフ900未満の場合スコア55%UP")]
        ScoreUp_65_or_55 = 17,
        [EnumMember(Value = "ライフ900以上でスコア110%UP | ライフ900未満の場合スコア90%UP")]
        ScoreUp_110_or_90 = 18,
        //19 not exist, perhaps future extension.
        [EnumMember(Value = "PERFECTのみスコア115%UP")]
        PerfectScoreUp_115 = 20,
        [EnumMember(Value = "ライフ600以上でスコア40%UP | ライフ600未満の場合ライフ450回復")]
        ScoreUp_40_or_LifeRecover_450 = 21,
        [EnumMember(Value = "ライフ600以上でスコア80%UP | ライフ600未満の場合ライフ500回復")]
        ScoreUp_80_or_LifeRecover_500 = 22,
        [EnumMember(Value = "ライフ減少無効＆スコア10％UP")]
        BadGuard_ScoreUp_10 = 23,
        [EnumMember(Value = "GREAT以下を出すまでスコアが65％UP")]
        // 24 not exist, perhaps future extension.
        NoGreatScoreUp_65 = 25,
        [EnumMember(Value = "GREAT以下を出すまでスコアが110％UP")]
        NoGreatScoreUp_110 = 26
    }
}
