using System;

namespace TextStatistikTool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie einen Text ein:");
            string text = Console.ReadLine();

            // Beispieltext für Tests:
            // string text = "Dies   ist   ein   Beispieltext mit  Vokalen.";

            PrintTextStats(text);

            Console.ReadLine();
        }

        static int CountLetters(string text, bool countSpaces = false)
        {
            int count = 0;

            foreach (char c in text)
            {
                if (c != ' ')
                {
                    count++;
                }
                else if (countSpaces && c == ' ')
                {
                    count++;
                }
            }

            return count;
        }

        static int CountVowels(string text, string vowels = "aeiouAEIOU")
        {
            int count = 0;

            foreach (char c in text)
            {
                if (vowels.Contains(c))
                {
                    count++;
                }
            }

            return count;
        }

        static int CountWords(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return 0;
            }

            string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        static void PrintTextStats(string text)
        {
            Console.WriteLine();
            Console.WriteLine("Text:");
            Console.WriteLine(text);
            Console.WriteLine();

            Console.WriteLine("Text-Statistik:");
            Console.WriteLine($"Buchstaben (ohne Leerzeichen): {CountLetters(text)}");
            Console.WriteLine($"Buchstaben (mit Leerzeichen):  {CountLetters(text, true)}");
            Console.WriteLine($"Vokale:                        {CountVowels(text)}");
            Console.WriteLine($"Wörter:                        {CountWords(text)}");
        }
    }
}

