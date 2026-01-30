namespace ErsterProjekt
{
    internal class Program
    {
        static void Main()
        {

            Bank deutscheBank = new Bank("Deutsche Bank", "Berlin Brandenburg", "Berlin", "Hauptstrasse 2");
            deutscheBank.BankMenueOeffnen();


            ////Tagesgeldkonto erstellen und testen

            //Tagesgeldkonto tgk = new Tagesgeldkonto("Max");


            //tgk.Einzahlen(1000, "Startguthaben");

            //// 3️⃣ Erste Auszahlung
            //Console.WriteLine("\n--- Auszahlung 1: 300 EUR ---");
            //tgk.Auszahlen(300, "ATM");

            //// 4️⃣ Zweite Auszahlung (innerhalb Tageslimit)
            //Console.WriteLine("\n--- Auszahlung 2: 200 EUR ---");
            //tgk.Auszahlen(200, "ATM");

            //// 5️⃣ Dritte Auszahlung (wird fehlschlagen)
            //Console.WriteLine("\n--- Auszahlung 3: 100 EUR ---");
            //tgk.Auszahlen(100, "ATM");

            //// 6️⃣ Zinsen berechnen
            //Console.WriteLine("\n--- Zinsen berechnen (0.7 %) ---");
            //tgk.ZinsenBerechnen();

            //// 7️⃣ Kontoauszug anzeigen
            //Console.WriteLine("\n--- Kontoauszug ---");
            //tgk.Kontoauszug();



            ////Investmentkonto erstellen und testen
            //Investmentkonto invest = new Investmentkonto("Max");

            //invest.Einzahlen(1000);
            //invest.Auszahlen(100);        // testen ob verboten greift
            //invest.ZinsenBerechnen();     // +1.25% Zinsen
            //invest.Kontoauszug();



            //// Kreditkonto erstellen mit Kreditrahmen 500 €
            //Kreditkonto kreditKonto = new Kreditkonto("Max Mustermann", 500);

            //// Einzahlen
            //kreditKonto.Einzahlen(100, "Geschenke");

            //// Auszahlung ins Minus aber innerhalb des Kreditrahmens
            //kreditKonto.Auszahlen(1500, "Reisen");

            //// Kontoauszug anzeigen
            //kreditKonto.Kontoauszug();







            //// Objekte der Klassen Lebensmittel, Getränk und Haushaltsartikel erstellen

            //Lebensmittel brot = new Lebensmittel("Brot", 2.49m, "12.02.2026");
            //brot.AlleInfosAusgeben();

            //Console.WriteLine();

            //Getraenk cola = new Getraenk("Cola", 1.79m, 1.5);
            //cola.AlleInfosAusgeben();

            //Console.WriteLine();

            //Haushaltsartikel schwamm = new Haushaltsartikel("Topfreiniger", 0.99m, "Reinigung");
            //schwamm.AlleInfosAusgeben();




            //// Objekt der Klasse Azubi erstellen
            //Azubi azubi = new Azubi("Max", 1050.08m, "Fachinformatiker");

            //// Alle Informationen ausgeben
            //azubi.AlleInfosAusgeben();




            //// Objekt der Kindklasse Schueler erstellen
            //Schueler schueler = new Schueler("Anna", 16, "10B");

            //// Alle Informationen ausgeben
            //schueler.AlleInfosAusgeben();








            // Damit das Konsolenfenster offen bleibt (optional)
            //Console.ReadKey();


            //Bank meineBank = new Bank("Super Bank", "Muenchen1", "Muenchen", "Leopold Str.11");
            //meineBank.BankMenueOeffnen();
            //Console.WriteLine("Programm beendet. Danke für die Nutzung der Bank.");









            //Bankkonto aufrufen

            //Bankkonto meinBankkonto = new Bankkonto("hilmar");

            //Bankkonto nicoKonto = new Bankkonto("Nicolas Arevalo Hoelscher");

            //Console.WriteLine("Geben Sie bitte Ihre pin ein:");
            //string pin = Console.ReadLine();
            //meinBankkonto.Einzahlen(200, pin);
            //meinBankkonto.Auszahlen(100.50m, pin);
            //meinBankkonto.Kontoauszug(pin);                         
            //meinBankkonto.Kontodetails();    

            //Bank meineBank = new Bank("SuperBank", "Muenchen-Zentrum", "Muenchen","Maximilianstraße 8");

            //meineBank.KontoErstellen("Nico");

            //meineBank.KontoErstellen("Saba");

            //meineBank.KontoErstellen("Hannes");

            //meineBank.KontoErstellen("Ron");

            //meineBank.KontoErstellen("Vache");

            //meineBank.KontoErstellen("Hilmar");

            //meineBank.BankDetailsAusgeben();



            //superBank.KontoErstellen("Nicolas Arevalo Hoelscher");
            //superBank.KontoErstellen("Hilmar");
            //superBank.KontoErstellen("Hannes");
            //superBank.KontoErstellen("Ron");
            //superBank.KontoErstellen("Saba");
            //superBank.KontoErstellen("Vache");
            //superBank.KontoErstellen("Sascha");
            //superBank.KontoErstellen("Bobby");

            //Console.WriteLine("Geben Sie bitte Ihre IBAN ein:");
            //string ibanEingabe = Console.ReadLine();
            //Bankkonto meinKonto = superBank.KontoFindenDurchIBAN(ibanEingabe);
            //meinKonto.Einzahlen(100m);
            //meinKonto.Auszahlen(73m);
            //meinKonto.Einzahlen(97m);
            //meinKonto.Einzahlen(2000m);
            //Console.WriteLine("Geben Sie fuer die Ueberweisung einen Ziel IBAN ein:");
            //string zielIban = Console.ReadLine();
            //Console.WriteLine("Geben Sie den Betrag den Sie Ueberweisen moechten ein:");
            //decimal betrag = decimal.Parse(Console.ReadLine());
            //superBank.UeberweisungDurchfuehren(ibanEingabe, zielIban, betrag);
            //meinKonto.Kontoauszug();
            //superBank.KontoFindenDurchIBAN(zielIban).Kontoauszug();

            //Bankkonto nicoKonto = new Bankkonto("Nicolas Arevalo Hoelscher");
            //nicoKonto.Kontodetails();
            //Console.WriteLine("Geben Sie Ihr pin bitte ein:");
            //string pin = Console.ReadLine();
            //nicoKonto.Einzahlen(100m,pin);
            //nicoKonto.Auszahlen(73m, pin);
            //nicoKonto.Einzahlen(97m, pin);
            //nicoKonto.Einzahlen(2000m, pin);
            //nicoKonto.Kontoauszug(pin);





            // Hund-Objekt erstellen (Konstruktor aufrufen)

            //Hund meinHund = new Hund("Labrador", "braun", "Max", 28.5);           

            // 2️⃣ Methoden aufrufen
            //meinHund.Bellen();
            //meinHund.Laufen(30);
            //meinHund.Sitzen();
            //meinHund.Rollen();

            //Console.ReadKey();




        }
    }
}
