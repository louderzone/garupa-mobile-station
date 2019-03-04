using System;
using System.Collections.Generic;
using System.Text;

namespace GarupaPico.Model
{
    class Song {

        /// <summary>
        /// Gets song ID from the game.
        /// </summary>
        public int SongID { get; private set; }

        /// <summary>
        /// Gets the song name.
        /// </summary>
        public string SongName { get; private set; }

        /// <summary>
        /// Gets the song from which band ( Poppin' Party / Afterglow / Pastel*Palettes / Roselia / Hello Happy World! ).
        /// "N/A" for dummy card, which is set when you create dummy object.
        /// </summary>
        public string Band { get; private set; }

        /// <summary>
        /// Gets whether the song is original or cover song
        /// Return true if it is orignal song, false if it is cover song.
        /// </summary>
        public bool Original { get; private set; }

        /// <summary>
        /// Gets the interval of the song in seconds.
        /// In Africa, every 60 seconds passing 1 minute, LUL.
        /// </summary>
        public int SongLength { get; private set; }

        /// <summary>
        /// Gets the level of the song (level 5-29 so far). 
        /// </summary>
        public int SongLevel { get; private set; }

        /// <summary>
        /// Gets the number of notes of the song.
        /// </summary>
        public int SongNotes { get; private set; }

        /// <summary>
        /// Gets the number of skill keys of the song, fixed at 6 unless game updates.
        /// </summary>
        public const int NumOfKeys = 6;

        /// <summary>
        /// Gets which note triggers skill start, in array (0-5).
        /// </summary>
        public int[] Key_start { get; private set; } = new int[NumOfKeys];

        /// <summary>
        /// Gets which note as the skill ends if lasts 7.0 seconds, in array (0-5).
        /// </summary>
        public int[] Key_7_0 { get; private set; } = new int[NumOfKeys];

        /// <summary>
        /// Gets which note as the skill ends if lasts 7.5 seconds, in array (0-5).
        /// </summary>
        public int[] Key_7_5 { get; private set; } = new int[NumOfKeys];

        /// <summary>
        /// Gets which note as the skill ends if lasts 8.0 seconds, in array (0-5).
        /// </summary>
        public int[] Key_8_0 { get; private set; } = new int[NumOfKeys];

        /// <summary>
        /// Gets which note in the song starts fever.
        /// </summary>
        public int FeverStart { get; private set; }

        /// <summary>
        /// Gets which note in the song as last fever note.
        /// </summary>
        public int FeverEnd { get; private set; }

        /// <summary>
        /// which note triggers skill with high level hitting skill (餡蜜), in array (0-5).
        /// </summary>
        public int[] InvertBeat { get; private set; } = new int[NumOfKeys];

        /// <summary>
        /// Creates dummy song object.
        /// </summary>
        public Song() {
            SongID = -1;
            SongName = "<なし>";
            Original = false;
            Band = "N/A";
            SongLevel = 0;
            SongNotes = 0;
            for (int i = 0; i < NumOfKeys; i++) {
                Key_start[i] = 0;
                Key_7_0[i] = 0;
                Key_7_5[i] = 0;
                Key_8_0[i] = 0;
                InvertBeat[i] = 0;
            }
            FeverStart = 0;
            FeverEnd = 0;
        }

        /// <summary>
        /// Creates normal song object.
        /// </summary>
        /// <param name="SongID"></param>
        /// <param name="SongName"></param>
        /// <param name="Band"></param>
        /// <param name="Original"></param>
        /// <param name="SongLevel"></param>
        /// <param name="SongNotes"></param>
        /// <param name="Keys"></param>
        /// <param name="FeverStart"></param>
        /// <param name="FeverEnd"></param>
        /// <param name="InvertBeat"></param>
        public Song(int SongID, string SongName, string Band, bool Original, int SongLevel, int SongNotes, int[][] Keys, int FeverStart, int FeverEnd, int[] InvertBeat) {
            if (Keys.Length != NumOfKeys || InvertBeat.Length != NumOfKeys) {
                throw new ArgumentOutOfRangeException("Failed to create object. Illegal number of arguments for class song.");
            }
            for (int i = 0; i < 6; i++) { // Safe Check
                if (Keys[i].Length != 4)
                    throw new ArgumentOutOfRangeException("Failed to create object. Illegal number of arguments for class song.");
            }
            this.SongID = SongID;
            this.SongName = SongName;
            this.Band = Band;
            this.Original = Original;
            this.SongLevel = SongLevel;
            this.SongNotes = SongNotes;
            for (int i = 0; i < NumOfKeys; i++)
            {
                this.Key_start[i] = Keys[i][0];
                this.Key_7_0[i] = Keys[i][1];
                this.Key_7_5[i] = Keys[i][2];
                this.Key_8_0[i] = Keys[i][3];
                this.InvertBeat[i] = InvertBeat[i];
            }
            this.FeverStart = FeverStart;
            this.FeverEnd = FeverEnd;
        }
    }
}
