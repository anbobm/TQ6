//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ErsterProjekt
//{
//    class FehlerbehandlungsAufgabe
//    {
//        static void Main()
//        {
//            Console.Write("Pfad zur Notendatei eingeben (Enter für grades.txt): ");
//            string path = Console.ReadLine();
//            if (string.IsNullOrWhiteSpace(path))
//                path = "\\TQ6\\ErsterProjekt\\grades.txt";

//            File.AppendAllText("C:\\Users\\nicoa\\Desktop\\TQ6\\ErsterProjekt\\Log.txt", $"\n\n[INFO] - {DateTime.Now} - Eingegebener Pfad: {path}");

//            List<(string Name, int Note)> valid = new();
//            int skipped = 0;

//            try
//            {
//                string[] lines = File.ReadAllLines(path);
//                //Pfad ist unguelitg
//                //Wir duerfen auf diesen Pfad nicht zugreifen.

//                for (int i = 0; i < lines.Length; i++)
//                {
//                    try
//                    {
//                        var entry = ParseGradeLine(lines[i]);
//                        valid.Add(entry);
//                    }
//                    catch
//                    {
//                        skipped++;
//                        Console.WriteLine($"Zeile {i + 1} übersprungen: ungültige Daten");
//                        File.AppendAllText("C:\\Users\\nicoa\\Desktop\\TQ6\\ErsterProjekt\\Log.txt", $"\n\n[INFO] - {DateTime.Now} - Zeile {i + 1} übersprungen: ungültige Daten");
//                    }
//                }
                
//                if (valid.Count == 0)
//                    throw new InvalidOperationException("Keine gültigen Noten gefunden.");
//                //Invalid operation exception wenn keine gueltige noten

//                double average = valid.Average(e => e.Note);
//                var highest = valid.OrderByDescending(e => e.Note).First();
//                var lowest = valid.OrderBy(e => e.Note).First();

//                Console.WriteLine($"Gültige Einträge: {valid.Count}");
//                Console.WriteLine($"Übersprungene Einträge: {skipped}");
//                Console.WriteLine($"Durchschnitt: {average:F2}");
//                Console.WriteLine($"Beste Note: {highest.Name} ({highest.Note})");
//                Console.WriteLine($"Schlechteste Note: {lowest.Name} ({lowest.Note})");
//                File.AppendAllText("C:\\Users\\nicoa\\Desktop\\TQ6\\ErsterProjekt\\Log.txt", $"\n\n[INFO] - {DateTime.Now} - Gültige Einträge: {valid.Count}");
//                File.AppendAllText("C:\\Users\\nicoa\\Desktop\\TQ6\\ErsterProjekt\\Log.txt", $"\n\n[INFO] - {DateTime.Now} - Übersprungene Einträge: {skipped}");
//                File.AppendAllText("C:\\Users\\nicoa\\Desktop\\TQ6\\ErsterProjekt\\Log.txt", $"\n\n[INFO] - {DateTime.Now} - Durchschnitt: {average:F2}");
//                File.AppendAllText("C:\\Users\\nicoa\\Desktop\\TQ6\\ErsterProjekt\\Log.txt", $"\n\n[INFO] - {DateTime.Now} - Beste Note: {highest.Name} ({highest.Note})");
//                File.AppendAllText("C:\\Users\\nicoa\\Desktop\\TQ6\\ErsterProjekt\\Log.txt", $"\n\n[INFO] - {DateTime.Now} - Schlechteste Note: {lowest.Name} ({lowest.Note})");
//            }
//            catch (DirectoryNotFoundException ex)
//            {
//                Console.WriteLine("Ungueltiger Pfad.");
//                File.AppendAllText("C:\\Users\\nicoa\\Desktop\\TQ6\\ErsterProjekt\\Log.txt", $"\n\n[ERROR] - {DateTime.Now} - {ex.ToString()}");
//            }
//            catch (InvalidOperationException ex)
//            {
//                Console.WriteLine("Keine gueltige Noten in diese Datei gefunden.");
//                File.AppendAllText("C:\\Users\\nicoa\\Desktop\\TQ6\\ErsterProjekt\\Log.txt", $"\n\n[ERROR] - {DateTime.Now} - {ex.ToString()}");
//            }
//            catch (UnauthorizedAccessException ex)
//            {
//                Console.WriteLine("Fuer diesen Pfad brauchen wir Admin rechte.");
//                File.AppendAllText("C:\\Users\\nicoa\\Desktop\\TQ6\\ErsterProjekt\\Log.txt", $"\n\n[ERROR] - {DateTime.Now} - {ex.ToString()}");
//            }
//            catch (ArgumentException ex)
//            {
//                Console.WriteLine("Problem mit Daten");
//                File.AppendAllText("C:\\Users\\nicoa\\Desktop\\TQ6\\ErsterProjekt\\Log.txt", $"\n\n[ERROR] - {DateTime.Now} - {ex.ToString()}");
//            }
//            finally
//            {
//                File.AppendAllText("C:\\Users\\nicoa\\Desktop\\TQ6\\ErsterProjekt\\Log.txt", $"\n\n[INFO] - {DateTime.Now} - Dateiverarbeitung abgeschlossen.");
//                Console.WriteLine("Dateiverarbeitung abgeschlossen.");
//            }
//        }

//        static (string Name, int Note) ParseGradeLine(string line)
//        {
//            string[] parts = line.Split(';');

//            if (parts.Length != 2)
//                throw new ArgumentException("Zeile muss genau ein Semikolon enthalten");

//            if (string.IsNullOrWhiteSpace(parts[0]))
//                throw new ArgumentException("Name fehlt");

//            int note = int.Parse(parts[1]);

//            if (note < 0 || note > 100)
//                throw new ArgumentException("Note muss zwischen 0 und 100 liegen");

//            return (parts[0], note);
//        }
//    }

//}
