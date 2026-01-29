using System;
using System.Collections.Generic;

namespace Bibliotheksverwaltung
{
    class Program
    {
        static void Main(string[] args)
        {
            Bibliothek bibliothek = new Bibliothek();

            // Beispiel-Bücher (Systembestand, nicht durch Kunden änderbar)
            Buch buch1 = new Buch("978-0132350884", "Clean Code", "Robert C. Martin", 2008);
            Buch buch2 = new Buch("978-0201633610", "Design Patterns", "Gamma et al.", 1994);

            // Beispiel-Kunde (vereinfacht, kein Login-System)
            Kunde kunde = new Kunde(1, "Max Mustermann", "Musterstraße 1");

            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("=== Bibliotheksverwaltung ===");
                Console.WriteLine("1) Buch ausleihen");
                Console.WriteLine("2) Ausleihe verlängern");
                Console.WriteLine("3) Aktuelle Ausleihen anzeigen");
                Console.WriteLine("4) Kundendaten ändern");
                Console.WriteLine("0) Beenden");
                Console.Write("Auswahl: ");

                string eingabe = Console.ReadLine();

                switch (eingabe)
                {
                    case "1":
                        Console.WriteLine("1) Clean Code");
                        Console.WriteLine("2) Design Patterns");
                        Console.Write("Buch auswählen: ");

                        string buchAuswahl = Console.ReadLine();
                        Buch buch = buchAuswahl == "1" ? buch1 : buch2;

                        if (bibliothek.Ausleihen(buch, kunde, DateTime.Now))
                        {
                            Console.WriteLine("Buch erfolgreich ausgeliehen.");
                        }
                        else
                        {
                            Console.WriteLine("Buch ist aktuell nicht verfügbar.");
                        }
                        Pause();
                        break;

                    case "2":
                        List<Ausleihe> ausleihen = bibliothek.GetAktuelleAusleihen(kunde);

                        if (ausleihen.Count == 0)
                        {
                            Console.WriteLine("Keine aktiven Ausleihen.");
                            Pause();
                            break;
                        }

                        for (int i = 0; i < ausleihen.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}) {ausleihen[i].Buch.Titel}");
                        }

                        Console.Write("Ausleihe auswählen: ");
                        int index = int.Parse(Console.ReadLine()) - 1;

                        bibliothek.Verlaengern(ausleihen[index], DateTime.Now);
                        Console.WriteLine("Ausleihe wurde verlängert.");
                        Pause();
                        break;

                    case "3":
                        List<Ausleihe> aktuelleAusleihen = bibliothek.GetAktuelleAusleihen(kunde);

                        if (aktuelleAusleihen.Count == 0)
                        {
                            Console.WriteLine("Keine aktiven Ausleihen.");
                        }
                        else
                        {
                            foreach (Ausleihe a in aktuelleAusleihen)
                            {
                                Console.WriteLine(
                                    $"{a.Buch.Titel} | Rückgabe bis: {a.Rueckgabedatum:d}"
                                );
                            }
                        }
                        Pause();
                        break;

                    case "4":
                        Console.Write("Neuer Name: ");
                        kunde.SetName(Console.ReadLine());

                        Console.Write("Neue Adresse: ");
                        kunde.SetAdresse(Console.ReadLine());

                        Console.WriteLine("Kundendaten aktualisiert.");
                        Pause();
                        break;

                    case "0":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Ungültige Auswahl.");
                        Pause();
                        break;
                }
            }
        }

        private static void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Weiter mit Enter...");
            Console.ReadLine();
        }
    }
}