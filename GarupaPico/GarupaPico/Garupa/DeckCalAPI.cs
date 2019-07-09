using System;
using System.Collections.Generic;
using System.Text;
using GarupaPico.Model;

namespace GarupaPico.Garupa
{
    class DeckCalAPI {

        /// <summary>
        /// This API version.
        /// </summary>
        public string API_Version { get; } = "Build 34";

        /*/// <summary>
        /// Old Version. But don't remove as reference.
        /// </summary>
        public double[] mi_effect = { 4.5, 4.0, 3.5, 3.0, 2.5, 2.0, 0.0 }; // music instruments
        public double[] pf_effect = { 10.0, 9.0, 8.0, 7.0, 6.0, 0.0 };     // poster & fryer
        public double[] fd_effect = { 10.0, 7.0, 5.0, 3.0, 1.0, 0.0 };     // food 
        public double[] ryu_effect = { 10.0, 7.0, 5.0, 3.0, 1.0, 0.0 };    // ryuusei

        //public string[] mi_itemLevel = {"6","5","4","3","2","1","0"};    // Music Instruments
        public string[] pf_itemLevel = {"5","4","3","2","1","0"};        // Poster & Fryer
        public string[] fd_itemLevel = {"5","4","3","2","1","0"};        // Food
        public string[] ryu_itemLevel = {"5","4","3","2","1","0"};       // Ryuusei
        */

        /// <summary>
        /// Master card list pull from server.
        /// </summary>
        public Card[] MasterList;

        /// <summary>
        /// Display list sorted / filtered by selection.
        /// </summary>
        public Card[] DisplayList;

        /// <summary>
        /// Music instruments items level mapping.
        /// </summary>
        public Dictionary<int, double> MusicInstr_Effect { get; } = new Dictionary<int, double>() {
            { 6, 4.5 },
            { 5, 4.0 },
            { 4, 3.5 },
            { 3, 3.0 },
            { 2, 2.5 },
            { 1, 2.0 },
            { 0, 0.0 }
        };

        /// <summary>
        /// Poster and Fryer items level mapping.
        /// </summary>
        public Dictionary<int, double> PosterFryer_Effect { get; } = new Dictionary<int, double>() {
            { 6, 11.0 },
            { 5, 10.0 },
            { 4, 9.0 },
            { 3, 8.0 },
            { 2, 7.0 },
            { 1, 6.0 },
            { 0, 0.0 }
        };

        /// <summary>
        /// Food item level mapping.
        /// </summary>
        public Dictionary<int, double> Food_Effect { get; } = new Dictionary<int, double>() {
            { 6, 12.0 },
            { 5, 10.0 },
            { 4, 8.0 },
            { 3, 6.0 },
            { 2, 4.0 },
            { 1, 2.0 },
            { 0, 0.0 }
        };

        /// <summary>
        /// RyuuseiHouse_Effect items level mapping.
        /// </summary>
        public Dictionary<int, double> RyuuseiHouse_Effect { get; } = new Dictionary<int, double>() {
            { 6, 12.0 },
            { 5, 10.0 },
            { 4, 8.0 },
            { 3, 6.0 },
            { 2, 4.0 },
            { 1, 2.0 },
            { 0, 0.0 }
        };

        /// <summary>
        /// Auto max level of all area items.
        /// </summary>
        public string[] Auto_itemLevel { get; } = { "MAX", "5", "4", "3", "2", "1", "0" };

        /// <summary>
        /// Filter list 1 filter by band names.
        /// </summary>
        public string[] FilterList { get; } = { "<なし>", "PPP", "AG", "P*P", "Roselia", "HHW" };

        /// <summary>
        /// Filter list 2 filter by rarity (1 - 4 stars).
        /// </summary>
        public string[] FilterList2 { get; } = { "<なし>", "★1", "★2", "★3", "★4", "★3↑" };

        /// <summary>
        /// Filter list 3 filter by card type.
        /// </summary>
        public string[] FilterList3 { get; } = { "<なし>", "パワフル", "クール", "ピュア", "ハッピー" };

        /// <summary>
        /// Event available types.
        /// </summary>
        public string[] EventTypes { get; } = { "<なし>", "パワフル", "クール", "ピュア", "ハッピー" };

        /// <summary>
        /// Event available bonus.
        /// </summary>
        public string[] BounsTypes { get; } = { "<なし>", "パフォー", "テクニック", "ビジュアル" };

        /// <summary>
        /// Member selected card attributes Perf, Tech & Vis for each member, 5 total.
        /// First Performance, Second Technique, Last Visual
        /// </summary>
        public int[ , ] MemberValues = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };

        /// <summary>
        /// Member selected card attributes Band & Types for each member, 5 total.
        /// Band goes first, Type second.
        /// </summary>
        public int[ , ] MemberBandTypes = { { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 } };

        /// <summary>
        /// Member selected index.
        /// </summary>
        public int[] MemberNames = { -1, -1, -1, -1, -1 };

        /// <summary>
        /// Event attribute -> Event Type.
        /// </summary>
        public int EventType { get; private set; } = -1;

        /// <summary>
        /// Event attribute -> Bonus Type.
        /// </summary>
        public int EventBonusType { get; private set; } = -1;

        /// <summary>
        /// Event attribute -> Buff Member Type.
        /// </summary>
        private int[] EventBuffMember = { -1, -1, -1, -1, -1 };

        /// <summary>
        /// Private calculate variables.
        /// </summary>
        private const int _maxMember = 5;
        private const int _areaItems = 14;
        private int[ , ] _items = new int[_areaItems, 2]; // 0= PPP, 1=AG, 2=P*P, 3=Roselia, 4=HHW || Level 5-0
        // For each member, calculate must separate.
        private double[] _member = new double[_maxMember] { 0.0, 0.0, 0.0, 0.0, 0.0 };
        private double[] _memberChallenge = new double[_maxMember] { 0.0, 0.0, 0.0, 0.0, 0.0 };
        private double[] _challengeBuff = new double[_maxMember] { 0.0, 0.0, 0.0, 0.0, 0.0 };

        /// <summary>
        /// Variables Initializations.
        /// </summary>
        private void Initialize() {

            for(int i = 0, j = 0; i < _areaItems; i++) {
                for (j = 0; j < _items.GetLength(1); j++)
                    _items[i, j] = -1;
            }
            for(int i = 0; i < _maxMember; i ++) {
                _member[i] = 0.0;
                _memberChallenge[i] = 0.0;
                _challengeBuff[i] = 0.0;
            }
        }

        /// <summary>
        /// Card Loading / Pulling from server.
        /// </summary>
        public void BuildCardList() {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        public DeckCalAPI() {
            BuildCardList();
            Initialize();
        }

        /// <summary>
        /// Set Event type for extra additional to team sum up.
        /// </summary>
        /// <param name="type"></param>
        public void SetEventType(int type) {
            if (type >= 1 && type <= 4) {
                EventType = type;
            } else {
                EventType = -1;
            }
        }

        /// <summary>
        /// Set Event bouns type for extra additional to team sum up.
        /// </summary>
        /// <param name="type"></param>
        public void SetEventBonusType(int type) {
            if (type >= 1 && type <= 3) {
                EventBonusType = type;
            } else {
                EventBonusType = -1;
            }
        }

        /// <summary>
        /// Gets specific member name in index, which usually returns 0-24.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int GetMemberNameIndex(int index) {
            if (index < 0 || index >= MemberNames.Length)
                return -1;
            return MemberNames[index];
        }

        /// <summary>
        /// Gets specific member full name.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string GetMemberNameText(int index) {
            if (index < 0 || index >= MemberNames.Length)
                return "N/A";
            MemberName mn = (MemberName)MemberNames[index];
            return mn.ToString();
        }

        /// <summary>
        /// Gets specifc event buff member index, which usually returns 0-24.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int GetEventMemberNameIndex(int index) {
            if (index < 0 || index >= EventBuffMember.Length)
                return -1;
            return EventBuffMember[index];
        }

        /// <summary>
        /// Gets specific event buff member full name.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string GetEventMemberNameText(int index) {
            if (index < 0 || index >= EventBuffMember.Length)
                return "N/A";
            MemberName mn = (MemberName)EventBuffMember[index];
            return mn.ToString();
        }

        /// <summary>
        /// Gets specific member band.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int GetMemberBand(int index) {
            if (index < 0 || index >= MemberBandTypes.Length)
                return -1;
            return MemberBandTypes[index, 0];
        }

        /// <summary>
        /// Gets specific member type.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int GetMemberType(int index) {
            if (index < 0 || index >= MemberBandTypes.Length)
                return -1;
            return MemberBandTypes[index, 1];
        }

        /// <summary>
        /// Get specifc member 1 attribute out of 3 basic attributes (Performance, Technique, Visual).
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public int GetMemberValue(int index, int value) {
            if (index >= 0 && index < MemberValues.Length
                && value >= 0 && value < MemberValues.GetLength(1)) {
                return MemberValues[index, value];
            }
            return -1;
        }

        /// <summary>
        /// Gets specific member 3 basic attributes (Performance, Technique, Visual) sum up.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int GetMemberTotal(int index) {
            if (index < 0 || index >= MemberValues.Length)
                return -1;
            int total = 0;
            for (int i = 0; i < MemberValues.GetLength(1); i++) {
                total += MemberValues[index, i];
            }
            return total;
        }

        /// <summary>
        /// Get all members 3 basic attributes (Performance, Technique, Visual) sum up.
        /// </summary>
        /// <returns></returns>
        public int GetAllMemberTotal() {
            int sum = 0;
            for (int i = 0, j; i < MemberValues.Length; i++) {

                for (j = 0; j < MemberValues.GetLength(1); j++)
                    sum += MemberValues[i, j];
            }
            return sum;
        }

        /// <summary>
        /// Get specific area item's band or type.
        /// <AreaItemMap>
        /// 0   - Mic               (Band)
        /// 1   - Guitar            (Band)       
        /// 2   - Bass              (Band)
        /// 3   - Drum              (Band)
        /// 4   - Piano/Keyboard    (Band)
        /// 5   - Poster            (Band)
        /// 6   - Counter           (Future extension)
        /// 7   - Mini Table        (Future extension)
        /// 8   - Magazine Rack     (Future extension)
        /// 9   - Near Entrance     (Band)
        /// 10  - Signboard         (Future extension)
        /// 11  - Center            (Type)
        /// 12  - Middle Court      (Future extension)
        /// 13  - Food Menu         (Type)
        /// </AreaItemMap>
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int GetAreaItemBandType(int index) {
            if (index < 0 || index > _items.Length)
                return 0;
            return _items[index, 0];
        }

        /// <summary>
        /// Set specific area item's band or type.
        /// <AreaItemMap>
        /// 0   - Mic               (Band)
        /// 1   - Guitar            (Band)       
        /// 2   - Bass              (Band)
        /// 3   - Drum              (Band)
        /// 4   - Piano/Keyboard    (Band)
        /// 5   - Poster            (Band)
        /// 6   - Counter           (Future extension)
        /// 7   - Mini Table        (Future extension)
        /// 8   - Magazine Rack     (Future extension)
        /// 9   - Near Entrance     (Band)
        /// 10  - Signboard         (Future extension)
        /// 11  - Center            (Type)
        /// 12  - Middle Court      (Future extension)
        /// 13  - Food Menu         (Type)
        /// </AreaItemMap>
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public void SetAreaItemBandType(int index, int level) {
            if (index >= 0 && index < _items.Length)
                _items[index, 0] = level;
        }

        /// <summary>
        /// Get specific area item's level.
        /// <AreaItemMap>
        /// 0   - Mic               (Band)
        /// 1   - Guitar            (Band)       
        /// 2   - Bass              (Band)
        /// 3   - Drum              (Band)
        /// 4   - Piano/Keyboard    (Band)
        /// 5   - Poster            (Band)
        /// 6   - Counter           (Future extension)
        /// 7   - Mini Table        (Future extension)
        /// 8   - Magazine Rack     (Future extension)
        /// 9   - Near Entrance     (Band)
        /// 10  - Signboard         (Future extension)
        /// 11  - Center            (Type)
        /// 12  - Middle Court      (Future extension)
        /// 13  - Food Menu         (Type)
        /// </AreaItemMap>
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int GetAreaItemLevel(int index) {
            if (index < 0 || index > _items.Length)
                return 0;
            return _items[index, 1];
        }

        /// <summary>
        /// Set specific area item's level.
        /// <AreaItemMap>
        /// 0   - Mic               (Band)
        /// 1   - Guitar            (Band)       
        /// 2   - Bass              (Band)
        /// 3   - Drum              (Band)
        /// 4   - Piano/Keyboard    (Band)
        /// 5   - Poster            (Band)
        /// 6   - Counter           (Future extension)
        /// 7   - Mini Table        (Future extension)
        /// 8   - Magazine Rack     (Future extension)
        /// 9   - Near Entrance     (Band)
        /// 10  - Signboard         (Future extension)
        /// 11  - Center            (Type)
        /// 12  - Middle Court      (Future extension)
        /// 13  - Food Menu         (Type)
        /// </AreaItemMap>
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public void SetAreaItemLevel(int index, int level) {
            if (index >= 0 && index < _items.Length)
                _items[index, 1] = level;
        }

        /// <summary>
        /// Calculates Team Sum up with area items
        /// </summary>
        /// <returns></returns>
        public int UpdateTeamSumUp() {

            double sum = 0, sum2 = 0;
            double addPercent;
            for (int i = 0; i < _maxMember; i++) {
                _memberChallenge[i] = _member[i] = (float)GetMemberTotal(i);
                _challengeBuff[i] = 0.0;
            }

            for (int i = 0, j; i < _maxMember; i++) {

                if (_member[i] <= 0.0f) continue; // skip the loop if unset

                if (EventType != -1) { // challenge event buff

                    if (GetMemberType(i) == EventType) { // type buff
                        _challengeBuff[i] = (_memberChallenge[i] * 0.2);
                    }
                    for (int orz = 0; orz < _maxMember; orz++) { // member buff

                        if (EventBuffMember[orz] == -1) continue;

                        if (GetMemberNameIndex(i) == GetEventMemberNameIndex(orz)) {

                            _memberChallenge[i] += (_memberChallenge[i] * 0.1);
                            if (EventBonusType != -1) { // Boost 50%

                                if (GetMemberType(i) + 1 == EventType) {
                                    _challengeBuff[i] += (float)(GetMemberValue(i, EventBonusType - 1) * 0.5);
                                }
                            }
                            break;
                        }
                    }
                }
                j = 0; addPercent = 0.0;    // reuse instead of create new
                // Additions by area items.
                // Becareful of some items using band and some using type.
                while (j < _areaItems) {     // j from 0 to 13 represents 14 items.

                    if (j >= 0 && j < 5) {  // Music instruments
                        if (GetMemberBand(i) == _items[j , 0]) { // item effects' band and types are the first number.
                            addPercent += MusicInstr_Effect[_items[j, 1]]; // item effects' level are the second number.
                        }
                    }
                    else if (j == 5 || j == 9) {  // Poster & Fryer
                        if (GetMemberBand(i) == _items[j, 0]) { // item effects' band and types are the first number.
                            addPercent += PosterFryer_Effect[_items[j, 1]]; // item effects' level are the second number.
                        }
                    }
                    else if (j == 11) { // Food
                        if (GetMemberType(i) == _items[j, 0]) { // item effects' band and types are the first number.
                            addPercent += Food_Effect[_items[j, 1]]; // item effects' level are the second number.
                        }
                    }
                    else if (j == 13) { // Ryuusei
                        if (GetMemberType(i) == _items[j, 0]) { // item effects' band and types are the first number.
                            addPercent += RyuuseiHouse_Effect[_items[j, 1]]; // item effects' level are the second number.
                        }
                    }
                    j++; // this is important
                }
                _member[i] = _member[i] + (_member[i] * (addPercent / 100.00));
                _memberChallenge[i] = (_memberChallenge[i] + _challengeBuff[i] + (_memberChallenge[i] * (addPercent / 100.00)));
                sum += _member[i];
                sum2 += _memberChallenge[i];
            }
            double res1 = Math.Floor(sum);
            double res2 = Math.Floor(sum2);
            /*
            String result;
            if (EventType == -1) {
                result = String.format("%,d", (int)res1);
                this.resultLabel5.setText("ソロ/協力ライブ:");
            } else {
                result = String.format("%,d", (int)res2);
                this.resultLabel5.setText("対バン/チャレンジ:");
            }
            //result = String.format("%,d (%,d)", sum, sum2); 
            this.resultTextField.setText("" + result); */

            //updateResultColor();

            if (EventType != -1) {
                return (int)res2;
            } else {
                return (int)res1;
            }
        }
    }
}
