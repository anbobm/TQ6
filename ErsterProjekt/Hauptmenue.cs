using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ErsterProjekt
{
    internal class Hauptmenue
    {
        
        public static void Mainmenue() 
        {
            Console.WriteLine("Willkommen in der TQ6");
            Console.WriteLine("\nHier findest du alle Programme die wir entwickelt haben.");
            Console.WriteLine("\nWähle ein Programm aus:");
            Console.WriteLine("\n1.Taschenrechner");
            Console.WriteLine("\n2.Passwort-Stärke-Prüfer");
            Console.WriteLine("\n3.Text Statistik");
            Console.WriteLine("\n4.Zahlen-Werkzeuge");
            Console.WriteLine("\n5.Bankkonto");
            Console.WriteLine("\nAuswahl:");

            int wahl;

            try
            {
                wahl = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nUngültige Eingabe: " + ex.Message);
                return;
            }
            switch (wahl)
            {
                case 1:
                    Rechnermenue();
                    break;
                case 2:
                    Passwortprüfer.Passwortpruefer();
                    break;
                case 3:
                    Textstatistik.Textstat();
                    break;
                case 4:
                    Zahlen_Werkzeug.ZahlenWerk();
                    break;
                case 5:
                    Bankkonto MeinBankkonto = new Bankkonto("Hannes", "Parkbank", "Wegberg");
                    break;

                default:
                    Console.WriteLine("Coming Soon!");
                    break;
            }
        
        }
        public static void Rechnermenue()
        {
            Console.WriteLine("=== Taschenrechner ===");
            Console.WriteLine("\nWillkommen beim Taschenrechner");
            Console.WriteLine("\nWas möchtest du machen?");
            Console.WriteLine("\n1. Addieren");
            Console.WriteLine("\n2. Subtrahieren");
            Console.WriteLine("\n3. Multiplizieren");
            Console.WriteLine("\n4. Dividieren");
            Console.WriteLine("\n5. Exponenten");
            Console.WriteLine("\nAuswahl:");

            int wahl;

            try
            {
                wahl = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ungültige Eingabe:" + ex.Message);
                return;
            }
            switch (wahl)
            {
                case 1:
                    Taschenrechner.Addieren();
                    break;
                case 2:
                    Taschenrechner.Subtrahieren();
                    break;
                case 3:
                    Taschenrechner.Multiplizieren();
                    break;
                case 4:
                    Taschenrechner.Dividieren();
                    break;
                case 5:
                    Taschenrechner.Exponent();
                    break;
                default:
                    Console.WriteLine("Coming Soon");
                    break;
            }

        }
    }
}
