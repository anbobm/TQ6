using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace ErsterProjekt
{
    internal class Bankkonto
    {
        //Attribute
        /*
         * kontostand - decimal
         * iban - string
         * kontoinhaber - string
         * bank - string
         * filiale - string
         * bic - string
         * pin - string
         */
        protected decimal kontostand;
        //                          DE              89          37040           04405       3201300
        private string iban;//country code - check digit - bank id code - branche code - kontonummer
        private string kontonummer;
        private string kontoinhaber;
        private string bank;
        private string filiale;
        private string bic;
        // PSTB             DE          MU            MU2
        //Bank code - ländercode - standort stadt - filiale
        private string pin;
        private List<string> verlauf;
       
        private static int zaehler = 0;

        //Konstruktor
        public Bankkonto(string kontoinhaber, string bank="Parkbank", string filiale="Wegberg")
        {
            this.kontoinhaber = kontoinhaber;
            this.bank = bank;
            this.filiale = filiale;
            kontostand = 0;
            pin = PinErstellen();
            
            bic = BicErstellen();
            kontonummer = KontonummerErstellen();
            zaehler++;
            iban = IBANErstellen();
            verlauf = new List<string>() { "OP\tBetrag\tQuelle\t\t\tZiel" };
            Kontodetails();
            //Console.WriteLine($"Iban von {kontoinhaber} ist: " + iban);
            //Verlauf format:
            /* OP  Betrag Konto         Ziel
             * +    230   kontonummer   kontonummer
             * -    100   kontonummer   kontonummer
             */
        }
        
        public string GetPin()
        {
            return pin;
        }
        public string GetKontonummer()
        {
            return kontonummer;
        }
        public string GetIBAN()
        {
            return iban; 
        }
        public string GetKontoinhaber()
        {
            return kontoinhaber;
        }
        //bool Einzahlen(decimal betrag, string pin)
        public bool Einzahlen(decimal betrag, string quelle = "==========")
        {
            if (betrag <= 0)
            {
                Console.WriteLine("Ungültiger Betrag. Bitte nur Zahlen größer als 0 eingeben");
                return false;
            }
            kontostand += betrag;
            verlauf.Add($"+\t{betrag}\t{quelle}\t\t{iban}");
            return true;
        }
        //bool Auszahlen(decimal betrag, string pin)
        public virtual bool Auszahlen(decimal betrag, string ziel = "==========")
        {
            if (betrag <= 0)
            {
                Console.WriteLine("Ungültiger Betrag. Bitte nur Zahlen größer als 0 eingeben");
                return false;
            }
            
            kontostand -= betrag;
            if (kontostand < 0)
            {
                Console.WriteLine("Zu wenig geld zum abholen");
                kontostand += betrag;
                return false;
             }
             verlauf.Add($"-\t{betrag}\t{iban}\t\t{ziel}");
             return true;
       
            
                
            
        }
        //void KontostandAnzeigen(string pin)
        public void Kontostand()
        {
            Console.WriteLine($"Dein Aktueller Kontostand betraegt: {kontostand.ToString("F2")} EUR.");
            return;

        }

        //void Kontoauszug(string pin)
        public void Kontoauszug()
        {
            Console.WriteLine("==========KONTOAUSZUG==========");
            foreach (string eintrag in verlauf)
            {
                Console.WriteLine(eintrag);
            }
            Kontostand();
            Console.WriteLine("==========ENDEAUSZUG==========");
        }
        public void Kontodetails()
        {
            
             Console.WriteLine("============= Kontodetails =============");
             Console.WriteLine("\nKontoinhaber: \t" + kontoinhaber);
             Console.WriteLine("\nKontonummer: \t" + kontonummer);
             Console.WriteLine("\nIBAN: \t\t" + iban);
             Console.WriteLine("\nBank: \t\t" + bank); 
             Console.WriteLine("\nBIC: \t\t" + bic);
             Console.WriteLine("\nPin: \t\t" + pin);
             Console.WriteLine("========================================");
            
            return;
        }
        private string KontonummerErstellen()
        {
            string kontonummer = "";
            int zaehlerLaenge = ("" + zaehler).Length;

            for (int i = 0; i < 10; i++)
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
        private string BicErstellen()
        {
            Random random = new Random();
            string BIC = "";
            string bankcode = "";
            string countrycode = "DE";
            string stadt = "HS";
            string filiale = "HS4";

            for (int i = 0;i < 4;i++)
            {
                char buchstabe = (char)random.Next('A', 'Z' + 1);
                bankcode += buchstabe;
            }

            BIC += bankcode + countrycode + stadt + filiale;
            return BIC;
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
        

        //Methode



        //bool Überweisen(string iban, string pin, decimal betrag)
        //void Kontodetails(string pin)



    }
}
