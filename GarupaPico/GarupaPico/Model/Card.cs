using System;
using System.Collections.Generic;
using System.Text;

namespace GarupaPico.Model
{
    class Card {
        /// <summary>
        /// Gets card id from the game.
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Gets card title.
        /// </summary>
        public string CardName { get; private set; }

        /// <summary>
        /// Gets card character band.
        /// </summary>
        public string Band { get; private set; }

        /// <summary>
        /// Gets card character name.
        /// </summary>
        public MemberName CharacterName { get; private set; }

        /// <summary>
        /// Gets 1-4 star. 
        /// 0 for dummy card, which is set when you create dummy object.
        /// </summary>
        public int Rarity { get; private set; }

        /// <summary>
        /// Gets card type as powerful / pure / cool / happy.
        /// "N/A" for dummy card, which is set when you create dummy object.
        /// </summary>
        public string Type { get; private set; }

        /// <summary>
        /// Gets power value of the card.
        /// 0 for dummy card, which is set when you create dummy object.
        /// </summary>
        public int Pow { get; private set; }

        /// <summary>
        /// Gets technique value of the card.
        /// 0 for dummy card, which is set when you create dummy object.
        /// </summary>
        public int Tech { get; private set; }

        /// <summary>
        /// Gets visual value of the card.
        /// 0 for dummy card, which is set when you create dummy object. 
        /// </summary>
        public int Vis { get; private set; }

        /// <summary>
        /// Gets the sum up value of power + technique + visual, calculated automatically. 
        /// </summary>
        public int Total => Pow + Tech + Vis;

        /// <summary>
        /// Gets card skill description.
        /// </summary>
        public string SkillType { get; private set; }

        /// <summary>
        /// Gets percentage of score up by card skill.
        /// </summary>
        public int ScorePercent { get; private set; }

        /// <summary>
        /// Gets skill last at minimum skill level.
        /// </summary>
        public float SkillLastS { get; private set; }

        /// <summary>
        /// Gets skill last at maximum skill level.
        /// </summary>
        public float SkillLastL { get; private set; }

        /// <summary>
        /// Gets online image path.
        /// </summary>
        public string ImgPath { get; private set; }
        
        // default dummy constructor
        public Card() {
            Id = -1;
            CardName = "<なし>";
            Band = "N/A";
            Rarity = 0;
            Type = "N/A";
            Pow = 0;
            Tech = 0;
            Vis = 0;
            //ImgPath = "" + this.getResource("/cardIcons/card0.png");
            this.SkillType = "N/A";
            ScorePercent = 0;
            SkillLastS = 0.0f;
            SkillLastL = 0.0f;
        }

        // full data contrustor
        public Card(int Id, string CardName, string Band, MemberName characterName, 
            int Rarity, string Type, int Pow, int Tech, int Vis, string SkillType, int scorePercent, float SkillLastL, string ImgPath) {
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
            this.ScorePercent = scorePercent;
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
