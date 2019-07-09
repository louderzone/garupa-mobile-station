using System;
using System.Collections.Generic;
using System.Text;

namespace GarupaPico.Model
{
    public class Song
    {
        /// <summary>
        /// Gets song ID from the game.
        /// </summary>
        public int Id { get; private set; } = -1;

        /// <summary>
        /// Gets the song name.
        /// </summary>
        public string SongName { get; private set; } = "<なし>";

        /// <summary>
        /// Gets the song from which band ( Poppin' Party / Afterglow / Pastel*Palettes / Roselia / Hello Happy World! ).
        /// "N/A" for dummy card, which is set when you create dummy object.
        /// </summary>
        public BandName? Band { get; private set; }

        /// <summary>
        /// Gets whether the song is original or cover song
        /// Return true if it is original song, false if it is cover song.
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

        #region Skill keys

        /// <summary>
        /// Gets the number of skill keys of the song, fixed at 6 unless game updates.
        /// </summary>
        public const int NumOfKeys = 6;

        public int[] Keys { get; } = new int[NumOfKeys];

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

        #endregion

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
        /// Creates song object.
        /// </summary>
        /// <param name="keys"></param>
        /// <param name="invertBeat"></param>
        public Song(IReadOnlyList<int[]> keys, IReadOnlyList<int> invertBeat) {
            for (var i = 0; i < NumOfKeys; i++)
            {
                Key_start[i] = keys[i][0];
                Key_7_0[i] = keys[i][1];
                Key_7_5[i] = keys[i][2];
                Key_8_0[i] = keys[i][3];
                InvertBeat[i] = invertBeat[i];
            }
        }
    }
}
