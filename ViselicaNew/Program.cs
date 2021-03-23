using System;

namespace ViselicaNew
{
    class Program
    {
        static void Main(string[] args)
        {
            Word.GetWord();
            Word.Encode();
            new Game();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Ваше количество попыток: " + Game.count);

            ChangeLetters();

            LoseOrWin();
        }
        private static void ChangeLetters()
        {
            do
            {
                Game.prLetter = Console.ReadLine();
                Game.SetLetter();
                Console.Clear();
            }
            while (Game.count != 0 && Word.encodeChar.Contains("_ "));
        }
        private static void LoseOrWin()
        {
            if (Game.count == 0)
            {
                Console.WriteLine("Вы проиграли!");
                Console.ReadKey();
            }
            else if (!Word.encodeChar.Contains("_ "))
            {
                Console.WriteLine("Вы выиграли!");
            }
        }
        
        public static void Print()
        {
            Console.Clear();
            for (int i = 0; i < Word.word.Length; i++)
            {
                Console.Write(Word.encodeChar[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Ваше количество попыток:" + Game.count);
            Console.WriteLine();
        }
    }
}
