using System;
using System.Collections.Generic;
using System.Text;

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
        private decimal kontostand;
        //                      DE              89              37040          04405        3201300
        private string iban;//country code - check digit - bank id code - branche code - kontonummer
        private string kontonummer;

        private string kontoinhaber;
        private string bank;
        private string filiale;
        //    PSTB       DE                MU           MU2       => PSTBDEMUMU2
        //Bank code - laendercode - standort stadt - filiale
        private string bic;
        private string pin;
        private List<string> verlauf;
        private static int zaehler = 0;

        //Konstruktor
        public Bankkonto(string kontoinhaber, string bank="SuperBank", string filiale="Muenchen")
        {
            this.kontoinhaber = kontoinhaber;
            this.bank = bank;
            this.filiale = filiale;
            kontostand = 0;
            pin = PinErstellen();
            bic = BicErstellen();
            kontonummer = KontonummerErstellen();
            iban = IBANErstellen();
            verlauf = new List<string>() {"OP\tBetrag\tQuelle\t\tZiel"};
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
        public virtual bool Einzahlen(decimal betrag, string quelle="==========")
        {
            if(betrag <= 0)
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
        public bool Auszahlen(decimal betrag, string ziel="==========")
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
            int zaehlerLaenge = (""+zaehler).Length;

            for(int i = 0; i < 10-zaehlerLaenge; i++)
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

            for(int i = 0; i< 4; i++)
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
}
