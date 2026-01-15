using System;
using System.Collections.Generic;
using System.Text;

namespace ErsterProjekt
{
    internal class Taschenrechner
    {
        private static double zahl1 = 0;
        private static double zahl2 = 0;
        private static double ergebnis;

        public static void Addieren()
        {
            Console.WriteLine("=== Addieren ===");
            Console.WriteLine("\nBitte gib die erste Zahl ein:");
            try
            {
                zahl1 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            { 
                Console.WriteLine("Ungültige Eingabe:" + ex.Message);

            }
            Console.WriteLine("Bitte gib die zweite Zahl ein:");
            try
            {
                zahl2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ungültige Eingabe:" + ex.Message);
            }
            ergebnis = zahl1 + zahl2;
            Console.WriteLine("\nDas Ergebnis ist:" + ergebnis);
        }

        public static void Subtrahieren()
        {
            Console.WriteLine("=== Subtrahieren ===");
            Console.WriteLine("\nBitte gib die erste Zahl ein:");
            try
            {
                zahl1 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ungültige Eingabe:" + ex.Message);

            }
            Console.WriteLine("Bitte gib die zweite Zahl ein:");
            try
            {
                zahl2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ungültige Eingabe:" + ex.Message);
            }
            ergebnis = zahl1 - zahl2;
            Console.WriteLine("\nDas Ergebnis ist " + ergebnis);
        }
        public static void Multiplizieren()
        {
            Console.WriteLine("=== Multiplizierne ===");
            Console.WriteLine("\nBitte gib die erste Zahl ein:");
            try
            {
                zahl1 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ungültige Eingabe:" + ex.Message);

            }
            Console.WriteLine("Bitte gib die zweite Zahl ein:");
            try
            {
                zahl2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ungültige Eingabe:" + ex.Message);
            }
            ergebnis = zahl1 * zahl2;
            Console.WriteLine("\nDas Ergebnis ist " + ergebnis);
        }

        public static void Dividieren()
        {
            Console.WriteLine("=== Dividieren ===");
            Console.WriteLine("\nBitte gib die erste Zahl ein:");
            try
            {
                zahl1 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ungültige Eingabe:" + ex.Message);

            }
            Console.WriteLine("Bitte gib die zweite Zahl ein:");
            try
            {
                zahl2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ungültige Eingabe:" + ex.Message);
            }
            if (zahl2 != 0)
            {
                ergebnis = zahl1 / zahl2;
                Console.WriteLine("\nDas Ergebnis ist " + ergebnis);
            }
            else
            {
                Console.WriteLine("\nFehler: Division durch 0 ist nicht erlaubt!");
            }
        }

        public static void Exponent()
        {
            int zaehler = 0;
            ergebnis = 1;

            Console.WriteLine("=== Exponenten ===");
            Console.WriteLine("\nBitte gib die erste Zahl ein:");
            try
            {
                zahl1 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ungültige Eingabe:" + ex.Message);

            }
            Console.WriteLine("Bitte gib die zweite Zahl ein:");
            try
            {
                zahl2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ungültige Eingabe:" + ex.Message);
            }
            for (zaehler = 1; zaehler <= zahl2; zaehler++)
            {
                ergebnis = ergebnis * zahl1;
            }
            Console.WriteLine("\nDas Ergebnis ist " + ergebnis);
        }

    }
}
