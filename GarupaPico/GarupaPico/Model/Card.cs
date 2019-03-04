using System;
using System.Collections.Generic;
using System.Text;

namespace GarupaPico.Model
{
    class Card {
        public int Id { get; private set; }             // card id from the game.
        public string CardName { get; private set; }    // card title.
        public string Band { get; private set; }        // card character band.
        public MemberName CharacterName { get; private set; }   // card character name.
        public int Rarity { get; private set; }         // 1-4 star.
        public string Type { get; private set; }        // powerful / pure / cool / happy
        public int Pow { get; private set; }            // power
        public int Tech { get; private set; }           // techique
        public int Vis { get; private set; }            // visual
        public int Total => Pow + Tech + Vis;           // above 3 sum up.
        public string SkillType { get; private set; }   // card skill description.
        public int ScorePerc { get; private set; }      // percentage of score up
        public float SkillLastS { get; private set; }   // skill last at minimum skill level.
        public float SkillLastL { get; private set; }   // skill last at maximum skill level.
        public string ImgPath { get; private set; }     // online image path

        // default dummy constructor
        public Card() {
            Id = -1;
            CardName = "<なし>";
            Band = "N/A";
            CharacterName = "N/A";
            Rarity = 0;
            Type = "N/A";
            Pow = 0;
            Tech = 0;
            Vis = 0;
            //ImgPath = "" + this.getResource("/cardIcons/card0.png");
            this.SkillType = "N/A";
            ScorePerc = 0;
            SkillLastS = 0.0f;
            SkillLastL = 0.0f;
        }

        // full data contrustor
        public Card(int Id, string CardName, string Band, string characterName, 
            int Rarity, string Type, int Pow, int Tech, int Vis, string SkillType, int ScorePerc, float SkillLastL, string ImgPath) {
            this.Id = Id;
            this.CardName = CardName;
            this.Band = Band;
            this.CharacterName = characterName;
            this.Rarity = Rarity;
            this.Type = Type;
            this.Pow = Pow;
            this.Tech = Tech;
            this.Vis = Vis;
            this.SkillType = SkillType;
            this.ScorePerc = ScorePerc;
            SkillLastS = 5.0f;
            this.SkillLastL = SkillLastL;
            this.ImgPath = ("https://i.imgur.com/" + ImgPath);
        }

        public string GetBand() {
            if (Band.Equals("Poppin'Party", StringComparison.OrdinalIgnoreCase))
                return "Poppin' Party";
            return Band;
        }
    }
}
