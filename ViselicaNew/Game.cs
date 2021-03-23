using System;
using System.Collections.Generic;
using System.Text;

namespace ViselicaNew
{
    class Game
    {
        public static int count { get; private set; }
        public static string prLetter { get; set; }

        private static int letCoord;

        public Game()
        {
            count = Word.word.Length;
            
        }
        public static void SetLetter()
        {
            Program.Print();

            if (Word.letter.Contains(Game.prLetter))
            {
                Game.CheckLetter();

            }
            else
            {
                Game.count--;
            }
            
        }
        public static void CheckLetter()
        {
            letCoord = (Word.letter.IndexOf(prLetter));
            Word.encodeChar[letCoord] = Word.letter[letCoord];

            Word.letter[letCoord] = "*";

            if (Word.letter.Contains(prLetter))
                CheckLetter();
            else
                return;
        }
    }
}
