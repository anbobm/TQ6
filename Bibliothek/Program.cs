using System.ComponentModel.Design;

namespace Bibliothek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bibliothek bib = new Bibliothek("Stadtbibliothek", "Mönchengladbach");

            bib.BuecherHinzufuegen(new Buch("Die Bibel", "Verschiedene", "0000000000000", 0, "Fantasy"));
            bib.BuecherHinzufuegen(new Buch("Per Anhalter durch die Galaxis", "Douglas Adams", "4204204200420", 1979, "Science Fiction"));
            bib.BuecherHinzufuegen(new Buch("Das Kapital", "Karl Marx", "1867186718671", 1867, "Wirtschaft"));
            bib.BuecherHinzufuegen(new Buch("Mord im Orient Express", "Agatha Christie", "1934193419340", 1934, "Kriminal Roman"));

            Console.WriteLine("=== Bücher in der Bibliothek ===");
            foreach (Buch b in bib.Buecher) 
            {
                Console.WriteLine($"Titel: {b.titel}, Autor: {b.autor}, ISBN: {b.isbn}, Jahr: {b.erscheinungsjahr} Genre: {b.genre}");
            }
            Console.WriteLine("==============================\n");

            Kunde eingeloggterKunde = null;

            while (true)
            {
                if (eingeloggterKunde == null)
                {
                    Console.WriteLine("=== Willkommen ===");
                    Console.WriteLine("\nWas möchten sie tun?");
                    Console.WriteLine("\n1. Account erstellen");
                    Console.WriteLine("\n2. Login");
                    Console.WriteLine("\n0. Beenden");

                    string eingabe = Console.ReadLine();

                    if (eingabe == "1")
                    {
                        Console.Write("Bitte geben sie ihren Namen ein:\n");
                        string name = Console.ReadLine();

                        Console.WriteLine("Bitte geben sie ihre Adresse ein:");
                        string adresse = Console.ReadLine();

                        eingeloggterKunde = bib.KundeErstellen(name, adresse);
                        Console.WriteLine($"Willkommen {eingeloggterKunde.name}!");
                        Console.WriteLine("\n=== Kontodetails ===");
                        Console.WriteLine($"\nKundennummer = {eingeloggterKunde.kundennummer}");
                        Console.WriteLine($"\nName = {eingeloggterKunde.name}");
                        Console.WriteLine($"\nAdresse = {eingeloggterKunde.adresse}");
                        Console.WriteLine("\n==================");
                    }
                    else if (eingabe == "2")
                    {
                        Console.WriteLine("Bitte scannen sie ihre Karte für den Login");
                        string kundennummer = Console.ReadLine();

                        eingeloggterKunde = bib.Login(kundennummer);
                        if (eingeloggterKunde != null)
                        {
                            Console.WriteLine($"Willkommen zurück {eingeloggterKunde.name}!");
                        }
                        else
                        {
                            Console.WriteLine("Kunde nicht gefunden");
                        }
                    }
                    else if (eingabe == "0")
                    {
                        Console.WriteLine("Auf Wiedersehen");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe");
                        break;
                    }

                }
                else
                {
                    Console.WriteLine("=== Willkommen ===");
                    Console.WriteLine("\nWas möchten sie tun?");
                    Console.WriteLine("\n1. Buch ausleihen");
                    Console.WriteLine("\n2. Buch zurück geben");
                    Console.WriteLine("\n3. Meine Daten anzeigen");
                    Console.WriteLine("\n0. Logout");

                    string eingabe = Console.ReadLine();
                    if (eingabe == "1")
                    {
                        Console.Write("Bitte den QR Code scannen:");
                        string isbn = Console.ReadLine();

                        bool erfolg = bib.Ausleihverfahren(isbn, eingeloggterKunde);
                    }
                    else if (eingabe == "2")
                    {
                        Console.WriteLine("Bitte den QR Code scannen:");
                        string isbn = Console.ReadLine();

                        bool erfolg = bib.Zurueckgeben(isbn, eingeloggterKunde);

                        if (!erfolg)
                        {
                            Console.WriteLine("Rückgabe nicht möglich. Bitte erneut probieren");
                        }
                    }
                    else if (eingabe == "3")
                    {
                        bib.KundendetailsAusgeben(eingeloggterKunde);   
                    }
                    else if (eingabe == "0")
                    {
                        eingeloggterKunde = null;
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe");
                    }
                }
            }
        }
    }
}
