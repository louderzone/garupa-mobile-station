using System;
using System.Collections.Generic;
using System.Text;

namespace GarupaPico.Model
{
    class Card
    {
        public static int ID = 0;                       // card id for the app.
        public int Id { get; private set; }             // card id from the game.
        public string CardName { get; private set; }    // card title.
        public string Band { get; private set; }        // card character band.
        public string CharaName { get; private set; }   // card character name.
        public int Rarity { get; private set; }         // 1-4 star.
        public string Type { get; private set; }        // powerful / pure / cool / happy
        public int Pow { get; private set; }            // power
        public int Tech { get; private set; }           // techique
        public int Vis { get; private set; }            // visual
        public int Total { get; private set; }          // above 3 sum up.
        public string SkillType { get; private set; }   // card skill description.
        public int ScorePerc { get; private set; }      // percentage of score up
        public float SkillLastS { get; private set; }   // skill last at minimum skill level.
        public float SkillLastL { get; private set; }   // skill last at maximum skill level.
        public string ImgPath { get; private set; }     // online image path
        // default constructor
        public Card(string CardName, string Band, string CharaName, 
            int Rarity, string Type, int Pow, int Tech, int Vis, string ImgPath, string SkillType)
        {
            Id = -1;
            this.CardName = CardName;
            this.Band = Band;
            this.CharaName = CharaName;
            this.Rarity = Rarity;
            this.Type = Type;
            this.Pow = Pow;
            this.Tech = Tech;
            this.Vis = Vis;
            Total = (this.Pow + this.Tech + this.Vis);
            //this.ImgPath = "" + this.getResource("/cardIcons/card0.png");
            this.SkillType = SkillType;
            ScorePerc = 0;
            SkillLastS = 0.0f;
            SkillLastL = 0.0f;
            ID++;
        }
        // full data contrustor
        public Card(int Id, string CardName, string Band, string CharaName, 
            int Rarity, string Type, int Pow, int Tech, int Vis, string SkillType, int ScorePerc, float SkillLastL, string ImgPath)
        {
            this.Id = Id;
            this.CardName = CardName;
            this.Band = Band;
            this.CharaName = CharaName;
            this.Rarity = Rarity;
            this.Type = Type;
            this.Pow = Pow;
            this.Tech = Tech;
            this.Vis = Vis;
            Total = (this.Pow + this.Tech + this.Vis);
            this.SkillType = SkillType;
            this.ScorePerc = ScorePerc;
            SkillLastS = 5.0f;
            this.SkillLastL = SkillLastL;
            this.ImgPath = ("https://i.imgur.com/" + ImgPath);
            ID++;
        }
        public string GetBand()
        {
            if (Band.Equals("Poppin'Party", StringComparison.OrdinalIgnoreCase))
                return "Poppin' Party";
            return Band;
        }
    }
}
