namespace ErsterProjekt
{

    /*
     * Wir brauchen zunaechst drei weitere Klassen! Kindklassen von Bankkonto.
     * 1. Kreditkonto: Es soll moeglich sein, dass der kontostand negativ ist.
     * 2. Investmentkonto: Wir duerfen hiervon nicht auszahlen bis der aktueller datum gleich 2060-01-01 ist.
     *                      Zusaetzlich bekommen wir jeden Monat eine erhoehung vom kontostand um 1.25%.
     * 3. Tagesgeldkonto: Eine Tagesgeldkonto darf maximal 500$ pro tag auszahlen, 
     *                      und bekommt jeden monat eine erhoehung vom Kontostand um 0.7%.
     */

    internal class Bankkonto
    {
        //Attribute
        protected decimal kontostand;
        //                      DE              89              37040          04405        3201300
        private string iban;//country code - check digit - bank id code - branche code - kontonummer
        protected string kontonummer;

        private string kontoinhaber;
        private string bank;
        private string filiale;
        //    PSTB       DE                MU           MU2       => PSTBDEMUMU2
        //Bank code - laendercode - standort stadt - filiale
        private string bic;
        private string pin;
        protected List<string> verlauf;
        private static int zaehler = 0;

        //Konstruktor
        public Bankkonto(string kontoinhaber, string bank = "SuperBank", string filiale = "Muenchen")
        {
            this.kontoinhaber = kontoinhaber;
            this.bank = bank;
            this.filiale = filiale;
            kontostand = 0;
            pin = PinErstellen();
            bic = BicErstellen();
            kontonummer = KontonummerErstellen();
            iban = IBANErstellen();
            verlauf = new List<string>() { "OP\tBetrag\tQuelle\t\tZiel" };
            zaehler++;
            Kontodetails();
        }

        //Methoden

        public void SetKontonummer(string kontonummer)
        {
            this.kontonummer = kontonummer;
        }
        public string GetKontonummer()
        {
            return kontonummer;
        }

        public string GetIBAN()
        {
            return iban;
        }
        public string GetPIN()
        {
            return pin;
        }
        public string GetKontoinhaber()
        {
            return kontoinhaber;
        }

        //bool Einzahlen(decimal betrag, string pin)
        public virtual bool Einzahlen(decimal betrag, string quelle = "==========")
        {
            if (betrag <= 0)
            {
                Console.WriteLine("Ungueltiger Betrag. Bitte nur Zahlen groesser 0 eingeben.");
                return false;
            }

            kontostand += betrag;
            verlauf.Add($"+\t{betrag}\t{quelle}\t{kontonummer}");
            return true;

        }

        //void Kontoauszug(string pin)
        public void Kontoauszug()
        {
            Console.WriteLine("==========KONTOAUSZUG==========");
            foreach (string eintrag in verlauf)
            {
                Console.WriteLine(eintrag);
            }
            KontostandAnzeigen();
            Console.WriteLine("==========ENDEAUSZUG==========");
        }


        //bool Auszahlen(decimal betrag, string pin)
        public virtual bool Auszahlen(decimal betrag, string ziel = "==========")
        {
            if (betrag <= 0)
            {
                Console.WriteLine("Ungueltiger Betrag. Bitte nur Zahlen groesser 0 eingeben.");
                return false;
            }
            if (kontostand < betrag)
            {
                Console.WriteLine("Nicht abgedeckt.");
                return false;
            }
            kontostand -= betrag;
            verlauf.Add($"-\t{betrag}\t{kontonummer}\t{ziel}");
            return true;
        }

        //void KontostandAnzeigen(string pin)
        public void KontostandAnzeigen()
        {
            Console.WriteLine($"Dein Aktueller Kontostand betraegt: {kontostand.ToString("F2")} EUR.");
        }

        //void Kontodetails() - kontonummer, iban, kontoinhaber, bank, pin
        public void Kontodetails()
        {
            Console.WriteLine("=========== KONTODETAILS ===========");
            Console.WriteLine($"Kontoinhaber : {kontoinhaber}");
            Console.WriteLine($"Bank         : {bank}");
            Console.WriteLine($"Filiale      : {filiale}");
            Console.WriteLine($"Kontonummer  : {kontonummer}");
            Console.WriteLine($"IBAN         : {iban}");
            Console.WriteLine($"BIC          : {bic}");
            Console.WriteLine($"PIN          : {this.pin}");
            Console.WriteLine("===========================");

        }


        private string BicErstellen()
        {
            Random random = new Random();
            string neuerBic = "";
            for (int i = 0; i < 4; i++)  // 4 zufällige Buchstaben
            {
                char buchstabe = (char)random.Next('A', 'Z' + 1);
                neuerBic += buchstabe;
            }


            neuerBic += "DE"; // DE hinzufügen


            for (int i = 0; i < 2; i++) // 2 zufällige Buchstaben
            {
                char buchstabe = (char)random.Next('A', 'Z' + 1);
                neuerBic += buchstabe;
            }


            string filialeKurz = filiale.Substring(0, 2).ToUpper(); //  Die ersten 2 Buchstaben der Filiale
            neuerBic += filialeKurz;


            neuerBic += random.Next(0, 10); // Eine Zufällige Zahl hinzufügen

            return neuerBic;
        }
        private string KontonummerErstellen()
        {
            string kontonummer = "";
            int zaehlerLaenge = ("" + zaehler).Length;

            for (int i = 0; i < 10 - zaehlerLaenge; i++)
            {
                kontonummer += 0;
            }
            kontonummer += zaehler;

            return kontonummer;
        }

        private string PinErstellen()
        {
            Random random = new Random();
            string neuerPin = "";

            for (int i = 0; i < 4; i++)
            {
                neuerPin += random.Next(0, 10);
            }
            return neuerPin;
        }

        private string IBANErstellen()
        {
            Random random = new Random();
            string IBAN = "";
            string laendercode = "DE";
            string pruefsumme = "";
            string BLZ = "";
            for (int i = 0; i < 2; i++)
            {
                pruefsumme += random.Next(0, 10);
            }
            for (int i = 0; i < 6; i++)
            {
                BLZ += random.Next(0, 10);
            }
            IBAN += laendercode + pruefsumme + BLZ + kontonummer;
            return IBAN;
        }




    }

    /*
    * Wir brauchen zunaechst drei weitere Klassen! Kindklassen von Bankkonto.
    * 1. Kreditkonto: Es soll moeglich sein, dass der kontostand negativ ist.
    * 2. Investmentkonto: Wir duerfen hiervon nicht auszahlen bis der aktueller datum gleich 2060-01-01 ist.
     *                      Zusaetzlich bekommen wir jeden Monat eine erhoehung vom kontostand um 1.25%.
    * 3. Tagesgeldkonto: Eine Tagesgeldkonto darf maximal 500$ pro tag auszahlen, 
    *                      und bekommt jeden monat eine erhoehung vom Kontostand um 0.7%.
    */

    //Änderungen in Bankkonto für Kindklasse Kreditkonto:

    //1.Bei Attribute private in protected decimal kontostand !
    //2.Die Methode public bool Auszahlen in public virtual bool Auszahlen!
    //3.Bei Attribute private List<string> verlauf; ändern in protected List<string> verlauf;

    internal class Kreditkonto : Bankkonto
    {
        private decimal kreditrahmen;

        // Konstruktor
        public Kreditkonto(
        string kontoinhaber,
        decimal kreditrahmen = 500,
        string bank = "SuperBank",
        string filiale = "Muenchen")
        : base(kontoinhaber, bank, filiale)
        {
            this.kreditrahmen = kreditrahmen;
        }

        //Methoden

        public override bool Auszahlen(decimal betrag, string ziel = "==========")
        {
            if (betrag <= 0)
            {
                Console.WriteLine("Ungueltiger Betrag.");
                return false;
            }

            if (kontostand - betrag < -kreditrahmen)
            {
                Console.WriteLine("Kreditrahmen ueberschritten!");
                return false;
            }

            kontostand -= betrag;
            verlauf.Add($"-\t{betrag}\t{kontonummer}\t{ziel}");
            return true;


        }
    }

    //2. Investmentkonto: Wir duerfen hiervon nicht auszahlen bis der aktueller datum gleich 2060-01-01 ist.
    //Zusaetzlich bekommen wir jeden Monat eine erhoehung vom kontostand um 1.25%.

    //Keine Änderungen in Elternklasse für die Kindklasse Investmentkonto!

    internal class Investmentkonto : Bankkonto
    {
        private DateTime sperrDatum = new DateTime(2060, 01, 01);

        // Konstruktor
        public Investmentkonto(
            string kontoinhaber,
            string bank = "SuperBank",
            string filiale = "Muenchen")
            : base(kontoinhaber, bank, filiale)
        {
        }
        //Methoden

        public override bool Auszahlen(decimal betrag, string ziel = "==========")
        {
            if (DateTime.Now < sperrDatum)
            {
                Console.WriteLine("Auszahlung erst ab dem 01.01.2060 erlaubt!");
                return false;
            }
            return base.Auszahlen(betrag, ziel);
        }
        public void ZinsenBerechnen()//Zinsenrechner
        {
            decimal zinsen = kontostand * 0.0125m;
            kontostand += zinsen;

            verlauf.Add($"+\t{zinsen:F2}\tZinsen\t{kontonummer}");
        }


    }

    //3. Tagesgeldkonto: Eine Tagesgeldkonto darf maximal 500$ pro tag auszahlen, 
    //und bekommt jeden monat eine erhoehung vom Kontostand um 0.7%.

    //Keine Änderungen in Elternklasse für die Kindklasse Tagesgeldkonto!

    internal class Tagesgeldkonto : Bankkonto
    {
        private decimal heuteAusgezahlt = 0;
        private DateTime letzterAuszahlungstag = DateTime.Today;
        private const decimal Tageslimit = 500m;

        // Konstruktor
        public Tagesgeldkonto(
            string kontoinhaber,
            string bank = "SuperBank",
            string filiale = "Muenchen")
            : base(kontoinhaber, bank, filiale)
        {
        }

        // Auszahlung mit Tageslimit
        public override bool Auszahlen(decimal betrag, string ziel = "==========")
        {
            if (betrag <= 0)
            {
                Console.WriteLine("Ungueltiger Betrag.");
                return false;
            }

            // Neuer Tag → Limit zurücksetzen
            if (DateTime.Today > letzterAuszahlungstag)
            {
                heuteAusgezahlt = 0;
                letzterAuszahlungstag = DateTime.Today;
            }

            if (heuteAusgezahlt + betrag > Tageslimit)
            {
                Console.WriteLine("Tageslimit von 500 EUR ueberschritten!");
                return false;
            }

            if (kontostand < betrag)
            {
                Console.WriteLine("Nicht genug Guthaben.");
                return false;
            }

            kontostand -= betrag;
            heuteAusgezahlt += betrag;
            verlauf.Add($"-\t{betrag}\t{kontonummer}\t{ziel}");
            return true;
        }

        // Monatliche Zinsen (0.7 %)
        public void ZinsenBerechnen()
        {
            decimal zinsen = kontostand * 0.007m;
            kontostand += zinsen;

            verlauf.Add($"+\t{zinsen:F2}\tZinsen\t{kontonummer}");
        }
    }
}
