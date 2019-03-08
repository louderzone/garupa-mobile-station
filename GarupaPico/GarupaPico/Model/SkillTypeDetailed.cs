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
        ScoreUp10 = 1,
        [EnumMember(Value = "スコア30%ＵＰ")]
        ScoreUp30 = 2,
        [EnumMember(Value = "スコア60%ＵＰ")]
        ScoreUp60 = 3,
        [EnumMember(Value = "スコア100%ＵＰ")]
        ScoreUp100 = 4,
        [EnumMember(Value = "判定強化(中)＆スコア10%ＵＰ")]
        JudgeMidAndScoreUp10 = 5,
        [EnumMember(Value = "判定強化(大)＆スコア20%ＵＰ")]
        JudgeBigAndScoreUp20 = 6,
        [EnumMember(Value = "判定強化(特大)＆スコア40%ＵＰ")]
        JudgeExBigAndScoreUp40 = 7,
        [EnumMember(Value = "ライフ300回復＆スコア10%ＵＰ")]
        LifeRecover300AndScoreUp10 = 8,
        [EnumMember(Value = "ライフ450回復＆スコア20%ＵＰ")]
        LifeRecover450AndScoreUp20 = 9,
        [EnumMember(Value = "ライフ750回復＆スコア40%ＵＰ")]
        LifeRecover750AndScoreUp40 = 10,
        [EnumMember(Value = "判定強化(中)＆スコア30%ＵＰ")]
        JudgeMidAndScoreUp30 = 11,
        [EnumMember(Value = "判定強化(大)＆スコア60%ＵＰ")]
        JudgeBigAndScoreUp60 = 12,
        [EnumMember(Value = "ライフ300回復＆スコア30%ＵＰ")]
        LifeRecover300ScoreUp30 = 13,
        [EnumMember(Value = "ライフ450回復＆スコア60%ＵＰ")]
        LifeRecover450AndScoreUp60 = 14,
        [EnumMember(Value = "ライフ300回復＆判定強化(中)	")]
        LifeRecover300AndJudgeMid = 15,
        [EnumMember(Value = "ライフ450回復＆判定強化(大)")]
        LifeRecover450AndJudgeMid = 16,
        [EnumMember(Value = "ライフ900以上でスコア65%UP | ライフ900未満の場合スコア55%UP")]
        ScoreUp65or55 = 17,
        [EnumMember(Value = "ライフ900以上でスコア110%UP | ライフ900未満の場合スコア90%UP")]
        ScoreUp110or90 = 18,
        //19 not exist, perhaps future extension.
        [EnumMember(Value = "PERFECTのみスコア115%UP")]
        PerfectScoreUp115 = 20,
        [EnumMember(Value = "ライフ600以上でスコア40%UP | ライフ600未満の場合ライフ450回復")]
        ScoreUp40orLifeRecover450 = 21,
        [EnumMember(Value = "ライフ600以上でスコア80%UP | ライフ600未満の場合ライフ500回復")]
        ScoreUp80orLifeRecover500 = 22,
        [EnumMember(Value = "ライフ減少無効＆スコア10％UP")]
        BadGuardAndScoreUp10 = 23,
        [EnumMember(Value = "GREAT以下を出すまでスコアが65％UP")]
        // 24 not exist, perhaps future extension.
        NoGreatScoreUp65 = 25,
        [EnumMember(Value = "GREAT以下を出すまでスコアが110％UP")]
        NoGreatScoreUp110 = 26
    }
}
