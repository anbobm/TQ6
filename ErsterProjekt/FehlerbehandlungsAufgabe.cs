using System;
using System.Collections.Generic;
using System.Text;

namespace ErsterProjekt
{
    class FehlerbehandlungsAufgabe
    {
        static void Main()
        {
            Console.Write("Pfad zur Notendatei eingeben (Enter für grades.txt): ");
            string path = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(path))
                path = "\\TQ6\\ErsterProjekt\\grades.txt";

            List<(string Name, int Note)> valid = new();
            int skipped = 0;

            try
            {
                string[] lines = File.ReadAllLines(path);

                for (int i = 0; i < lines.Length; i++)
                {
                    try
                    {
                        var entry = ParseGradeLine(lines[i]);
                        valid.Add(entry);
                    }
                    catch
                    {
                        skipped++;
                        Console.WriteLine($"Zeile {i + 1} übersprungen: ungültige Daten");
                    }
                }

                if (valid.Count == 0)
                    throw new InvalidOperationException("Keine gültigen Noten gefunden.");

                double average = valid.Average(e => e.Note);
                var highest = valid.OrderByDescending(e => e.Note).First();
                var lowest = valid.OrderBy(e => e.Note).First();

                Console.WriteLine($"Gültige Einträge: {valid.Count}");
                Console.WriteLine($"Übersprungene Einträge: {skipped}");
                Console.WriteLine($"Durchschnitt: {average:F2}");
                Console.WriteLine($"Beste Note: {highest.Name} ({highest.Note})");
                Console.WriteLine($"Schlechteste Note: {lowest.Name} ({lowest.Note})");
            }

            // HIER DIE PASSENDEN CATCH-BLÖCKE ERGÄNZEN

            finally
            {
                Console.WriteLine("Dateiverarbeitung abgeschlossen.");
            }
        }

        static (string Name, int Note) ParseGradeLine(string line)
        {
            string[] parts = line.Split(';');

            if (parts.Length != 2)
                throw new ArgumentException("Zeile muss genau ein Semikolon enthalten");

            if (string.IsNullOrWhiteSpace(parts[0]))
                throw new ArgumentException("Name fehlt");

            int note = int.Parse(parts[1]);

            if (note < 0 || note > 100)
                throw new ArgumentException("Note muss zwischen 0 und 100 liegen");

            return (parts[0], note);
        }
    }

}
