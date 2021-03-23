using System;
using System.Collections.Generic;
using System.Text;

namespace ViselicaNew
{
    class Word
    {
        private static List<string> text;
        public static List<string> words { get; private set; }
        public static int indWord { get; private set; }
        public static string word { get; private set; }
        public static List<string> letter { get; private set; }
        public static List<string> encodeChar { get; private set; }

        public static void GetWord()
        {
            words = new List<string>();
            text = new List<string> { "КОРОВА", "МОЧАЛКА", "ПРЕДСЕДАТЕЛЬ", "ОБЪЯВЛЕНИЕ", "КОТ" };
            words.AddRange(text);
            Random rnd = new Random();
            indWord = rnd.Next(0, words.Count);
            word = words[indWord];
        }
        public static void Encode()
        {
            encodeChar = new List<string>();
            letter = new List<string>();
            for(int i = 0; i < word.Length; i++)
            {
                letter.Add(word[i].ToString());
            }

            for(int i = 0; i < word.Length; i++)
            {
                encodeChar.Add("_ ");
            }
        }
    }
}
