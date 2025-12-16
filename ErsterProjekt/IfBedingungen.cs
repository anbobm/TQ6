using System;
using System.Collections.Generic;
using System.Text;

namespace ErsterProjekt
{
    internal class IfBedingungen
    {
        static void Main()
        {
            //ÜBUNG 1: NOTENBEWERTUNG

            // int punkte;
            // Console.WriteLine("Geben Sie ihre Punktzahl ein:");
            // punkte = Convert.ToInt32(Console.ReadLine());

            // if (punkte < 0 || punkte > 100)
            // {
            //     Console.WriteLine("Ungültige Eingabe");
            // }
            // else
            // {
            //    if (punkte < 100)
            //    {
            //        if (punkte < 89)
            //        {
            //            if (punkte < 74)
            //            {
            //                if (punkte > 49)
            //                {
            //                    Console.WriteLine("Ausreichend");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Nicht Bestanden!");
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("Gut");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Sehr gut");
            //        }
            //    }
            // }

            // if (punkte < 0 || punkte > 100)
            // {
            //     Console.WriteLine("Ungültige Eingabe");
            // }
            // else if (punkte >= 90)
            // {
            //     Console.WriteLine("Sehr gut");
            // }
            // else if (punkte >= 75)
            // {
            //     Console.WriteLine("Gut");
            // }
            // else if (punkte >= 60)
            // {
            //     Console.WriteLine("Befriedigend");
            // }
            // else if (punkte >= 50)
            // {
            //     Console.WriteLine("Ausreichend");
            // }
            // else
            // {
            //     Console.WriteLine("Nicht Bestanden!");
            // }



            // ÜBUNG 2: ALTERSÜBERPRÜFUNG
            // Der Benutzer gibt sein Alter ein.
            // Das Programm soll entscheiden:
            // • Unter 0 → „Ungültiges Alter“
            // • Unter 18 → „Minderjährig“
            // • 18–64 → „Erwachsen“
            // • Ab 65 → „Rentner“

            int alter;
            Console.WriteLine("Geben Sie Ihr Alter ein:");
            alter = Convert.ToInt32(Console.ReadLine());

            if (alter < 0)
            {
                Console.WriteLine("Ungültiges Alter.");
            }
            else if (alter < 18)
            {
                Console.WriteLine("Minderjährig.");
            }
            else if (alter >= 18 || alter < 65)
            {
                Console.WriteLine("Erwachsen.");
            }
            else
            {
                Console.WriteLine("Rentner.");
            }



            // ÜBUNG 3: TEMPERATURBEWERTUNG
            // Der Benutzer gibt eine Temperatur in Grad Celsius ein.
            // Das Programm soll Folgendes ausgeben:
            // • Unter 0 → „Sehr kalt“
            // • 0–14 → „Kalt“
            // • 15–24 → „Angenehm“
            // • 25–34 → „Warm“
            // • Ab 35 → „Sehr heiß“

            float temperatur;
            Console.WriteLine("Geben Sie eine Temperatur in Grad Celsius ein:");
            if (!float.TryParse(Console.ReadLine(), out temperatur))
            {
                Console.WriteLine("Muss ich Dir erklären, was Temperatur ist?");
                return;
            }

            if (temperatur < 0)
            {
                Console.WriteLine("Sehr kalt.");
            }
            else if (temperatur <= 14)
            {
                Console.WriteLine("Kalt.");
            }
            else if (temperatur <= 14)
            {
                Console.WriteLine("Angenehm.");
            }
            else if (temperatur <= 34)
            {
                Console.WriteLine("Warm.");
            }
            else if (temperatur > 35)
            {
                Console.WriteLine("Sehr heiß.");
            }



            // ÜBUNG 4: BENUTZERAUTHENTIFIZIERUNG
            // Der Benutzer gibt sein Benutzername und Passwort ein. Das Programm soll überprüfen ob seine Zugangsdaten gültig sind.Das echte Benutzername und Passwort müssen wir davor definieren.
            // Bspw: 
            // String benutzername = bob1
            // String passwort = 1234

            // Eingabe => bob1 und 4321
            // Ausgabe: Benutzername oder Passwort falsch.

            string? benutzername;
            string? passwort;

            Console.WriteLine("Geben Sie Ihren Benutzernamen ein:");
            benutzername = Console.ReadLine();

            Console.WriteLine("Geben Sie Ihren Benutzernamen ein:");
            passwort = Console.ReadLine();

            if (benutzername == "bob1" && passwort == "4321")
            {
                Console.WriteLine("Authentifizierung erfolgreich");
            }
            else
            {
                Console.WriteLine("Benutzername oder Passwort falsch.");
            }


            // ALTERNATIVE LÖSUNG
            // Weniger sicher, weil ausgegeben wird, was von beidem falsch ist.
            Console.WriteLine("Geben Sie Ihren Benutzernamen ein:");
            benutzername = Console.ReadLine();

            if (benutzername == "bob1")
            {
                Console.WriteLine("Geben Sie Ihr Passwort ein:");
                passwort = Console.ReadLine();

                if (passwort == "4321")
                {
                    Console.WriteLine("Das Passwort ist falsch.");
                }
            }
            else
            {
                Console.WriteLine("Der Benutzername ist falsch.");
            }
        }
    }
}
