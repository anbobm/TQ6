namespace Bibliotheksverwaltungssystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TEST3
            // -------------------------
            // Bibliothek und Testdaten
            // -------------------------
            Bibliothek bibliothek = new Bibliothek();

            // Kunden erstellen
            Kunde kunde1 = bibliothek.KundeErstellen(1, "Max Mustermann", "Musterstraße 1, 88888 Musterstadt");

            // Bücher erstellen
            Buch buch1 = new Buch("978-3-16-148410-0", "C# lernen", "Peter Schmidt", 2022);
            Buch buch2 = new Buch("978-1-23-456789-0", "Programmieren für Anfänger", "Anna Becker", 2021);
            Buch buch3 = new Buch("978-0-12-345678-9", "Datenstrukturen", "John Doe", 2020);
            Buch buch4 = new Buch("978-0-98-765432-1", "Algorithmen", "Jane Smith", 2019);
            Buch buch5 = new Buch("978-1-11-111111-1", "Datenbanken", "Alice Meyer", 2018);
            Buch buch6 = new Buch("978-2-22-222222-2", "Netzwerke", "Bob Schulz", 2017);

            // -------------------------
            // 1. Ausleihen testen
            // -------------------------
            Console.WriteLine("\n=== Ausleihen testen (Limit 5) ===");

            Buch[] alleBuecher = { buch1, buch2, buch3, buch4, buch5, buch6 };

            for (int i = 0; i < alleBuecher.Length; i++)
            {
                bool erfolgreich = bibliothek.AusleihProzessStarten(alleBuecher[i], kunde1);
                Console.WriteLine($"Versuch {i + 1}: Ausleihe von '{alleBuecher[i].Titel}' an {kunde1.Name} erfolgreich? {erfolgreich}");
            }

            // -------------------------
            // 2. Endstatus anzeigen
            // -------------------------
            Console.WriteLine("\n=== Kunde Endstatus ===");
            kunde1.KundendetailsAnzeigen();

            Console.WriteLine("\n=== Bücherstatus ===");
            foreach (Buch b in alleBuecher)
            {
                Console.WriteLine(b);
            }

            Console.WriteLine("\nDrücke eine Taste zum Beenden...");



            ////TEST2
            //// -------------------------
            //// Bibliothek und Testdaten
            //// -------------------------
            //Bibliothek bibliothek = new Bibliothek();

            //// Kunden erstellen
            //Kunde kunde1 = bibliothek.KundeErstellen(1, "Max Mustermann", "Musterstraße 1");
            //Kunde kunde2 = bibliothek.KundeErstellen(2, "Anna Müller", "Beispielweg 5");

            //// Bücher erstellen
            //Buch buch1 = new Buch("978-3-16-148410-0", "C# lernen", "Peter Schmidt", 2022);
            //Buch buch2 = new Buch("978-1-23-456789-0", "Programmieren für Anfänger", "Anna Becker", 2021);
            //Buch buch3 = new Buch("978-0-12-345678-9", "Datenstrukturen", "John Doe", 2020);

            //// -------------------------
            //// Kunden & Bücher anzeigen
            //// -------------------------
            //Console.WriteLine("=== Kunden ===");
            //kunde1.KundendetailsAnzeigen();
            //kunde2.KundendetailsAnzeigen();

            //Console.WriteLine("\n=== Bücher ===");
            //Console.WriteLine(buch1);
            //Console.WriteLine(buch2);
            //Console.WriteLine(buch3);

            //// -------------------------
            //// 1. Ausleihen
            //// -------------------------
            //Console.WriteLine("\n=== Ausleihen starten ===");

            //// Maximal 5 Ausleihen testen
            //for (int i = 0; i < 6; i++)
            //{
            //    bool erfolgreich = bibliothek.AusleihProzessStarten(buch1, kunde1);
            //    Console.WriteLine($"Versuch {i + 1}: Ausleihe von '{buch1.Titel}' an {kunde1.Name} erfolgreich? {erfolgreich}");
            //}

            //// Andere Bücher ausleihen
            //bibliothek.AusleihProzessStarten(buch2, kunde2);
            //bibliothek.AusleihProzessStarten(buch3, kunde2);

            //// -------------------------
            //// Status nach Ausleihe
            //// -------------------------
            //Console.WriteLine("\n=== Bücher nach Ausleihe ===");
            //Console.WriteLine(buch1);
            //Console.WriteLine(buch2);
            //Console.WriteLine(buch3);

            //Console.WriteLine("\n=== Kunden nach Ausleihe ===");
            //kunde1.KundendetailsAnzeigen();
            //kunde2.KundendetailsAnzeigen();

            //// -------------------------
            //// 2. Rückgabe testen
            //// -------------------------
            //Console.WriteLine("\n=== Rückgabe testen ===");
            //bool rueckgabe1 = kunde1.BuchZurueckgeben(new Ausleihe(buch1, kunde1)); // hier sollte normalerweise das gleiche Ausleih-Objekt genutzt werden
            //Console.WriteLine($"Rückgabe von '{buch1.Titel}' durch {kunde1.Name} erfolgreich? {rueckgabe1}");
            //buch1.SetzeVerfuegbar(); // Status aktualisieren

            //// -------------------------
            //// 3. Rückgabedatum ändern
            //// -------------------------
            //Console.WriteLine("\n=== Rückgabedatum ändern ===");
            //Ausleihe ausleiheBuch2 = new Ausleihe(buch2, kunde2);
            //DateOnly neuesDatum = DateOnly.FromDateTime(DateTime.Now.AddDays(7));
            //ausleiheBuch2.AendereRueckgabedatum(neuesDatum);
            //Console.WriteLine($"Neues Rückgabedatum für '{buch2.Titel}' gesetzt auf {neuesDatum}");

            //// -------------------------
            //// 4. Endstatus anzeigen
            //// -------------------------
            //Console.WriteLine("\n=== Bücher Endstatus ===");
            //Console.WriteLine(buch1);
            //Console.WriteLine(buch2);
            //Console.WriteLine(buch3);

            //Console.WriteLine("\n=== Kunden Endstatus ===");
            //kunde1.KundendetailsAnzeigen();
            //kunde2.KundendetailsAnzeigen();

            //Console.WriteLine("\nDrücke eine Taste zum Beenden...");




            ////TEST 1
            //// 1. Bibliothek erstellen
            //// -------------------------
            //Bibliothek bibliothek = new Bibliothek();

            //// -------------------------
            //// 2. Kunden erstellen
            //// -------------------------
            //Kunde kunde1 = bibliothek.KundeErstellen(1, "Max Mustermann", "Musterstraße 1");
            //Kunde kunde2 = bibliothek.KundeErstellen(2, "Anna Müller", "Beispielweg 5");

            //// -------------------------
            //// 3. Bücher erstellen
            //// -------------------------
            //Buch buch1 = new Buch("978-3-16-148410-0", "C# lernen", "Peter Schmidt", 2022);
            //Buch buch2 = new Buch("978-1-23-456789-0", "Programmieren für Anfänger", "Anna Becker", 2021);

            //// Bücher der Bibliothek hinzufügen
            //// (Optional: falls du noch eine Liste der Bücher in Bibliothek hast)
            //// bibliothek.BuecherHinzufuegen(buch1);
            //// bibliothek.BuecherHinzufuegen(buch2);

            //// -------------------------
            //// 4. Kunden und Bücher ausgeben
            //// -------------------------
            //Console.WriteLine("=== Kunden ===");
            //Console.WriteLine(kunde1);
            //Console.WriteLine(kunde2);

            //Console.WriteLine("\n=== Bücher ===");
            //Console.WriteLine(buch1);
            //Console.WriteLine(buch2);

            //// -------------------------
            //// 5. Ausleihe testen
            //// -------------------------
            //Console.WriteLine("\n=== Ausleihe starten ===");
            //bool ausleihe1 = bibliothek.AusleihProzessStarten(buch1, kunde1);
            //Console.WriteLine($"Ausleihe von '{buch1.Titel}' an {kunde1.Name} erfolgreich? {ausleihe1}");

            //bool ausleihe2 = bibliothek.AusleihProzessStarten(buch2, kunde2);
            //Console.WriteLine($"Ausleihe von '{buch2.Titel}' an {kunde2.Name} erfolgreich? {ausleihe2}");

            //// -------------------------
            //// 6. Status nach Ausleihe
            //// -------------------------
            //Console.WriteLine("\n=== Bücher nach Ausleihe ===");
            //Console.WriteLine(buch1);
            //Console.WriteLine(buch2);

            //Console.WriteLine("\n=== Kunden nach Ausleihe ===");
            //Console.WriteLine(kunde1);
            //Console.WriteLine(kunde2);

            //Console.WriteLine("\nDrücke eine Taste zum Beenden...");
            ////Console.ReadKey();

            //Console.WriteLine("\n=== Kundendetails ===");
            //kunde1.KundendetailsAnzeigen();











        }
}
}
