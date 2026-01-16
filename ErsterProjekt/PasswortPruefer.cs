using System;
using System.Collections.Generic;
using System.Text;

namespace ErsterProjekt
{
    internal class PasswortPruefer
    {
        public static bool HasMinLength(string text, int minLength = 8)
        {
            if (text == null)
                return false;

            return text.Length >= minLength;
        }

        public static bool ContainsDigit(string text)
        {
            if (text == null)
                return false;

            foreach (char c in text)
            {
                if (char.IsDigit(c))
                    return true;
            }
            return false;
        }

        public static bool ContainsUppercase(string text)
        {
            if (text == null)
                return false;

            foreach (char c in text)
            {
                if (char.IsUpper(c))
                    return true;
            }
            return false;
        }

        public static bool ContainsSpecialChar(string text, string special = "!@#$%^&*")
        {
            if (text == null)
                return false;

            foreach (char c in text)
            {
                if (special.Contains(c))
                    return true;
            }
            return false;
        }

        public static int StrengthScore(string password)
        {
            int score = 0;

            if (HasMinLength(password))
                score++;

            if (ContainsDigit(password))
                score++;

            if (ContainsUppercase(password))
                score++;

            if (ContainsSpecialChar(password))
                score++;

            return score;
        }

        public static void PrintStrengthReport(string password)
        {
            Console.WriteLine();
            Console.WriteLine("Passwort-Stärke-Report");
            Console.WriteLine("----------------------");

            Console.WriteLine($"Mindestlänge (8): {HasMinLength(password)}");
            Console.WriteLine($"Zahl enthalten: {ContainsDigit(password)}");
            Console.WriteLine($"Großbuchstabe enthalten: {ContainsUppercase(password)}");
            Console.WriteLine($"Sonderzeichen enthalten: {ContainsSpecialChar(password)}");

            int score = StrengthScore(password);
            Console.WriteLine();
            Console.WriteLine($"Gesamtpunktzahl: {score} von 4");
        }
    }
}
