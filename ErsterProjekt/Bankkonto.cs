using System;
using System.Collections.Generic;
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
        private decimal kontostand;
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
        private static int zaehler = 0;

        //Konstruktor
        public Bankkonto(string kontoinhaber, string bank, string filiale)
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
            Console.WriteLine($"Iban von {kontoinhaber} ist: " + iban);
            //iban
            //kontonummer
            //bic
            //Anforderungen für BIC:
            //BIC soll zufällig 4 zeichen erstellen und abspeicher, dann DE abspeicher,
            //dann 2 zufällige Buchstaben, dann erste 2 Buchstaben von filiale und eine zufällige zwahl zwischen 0 und 9
            //pin
        }
        private string KontonummerErstellen()
        {
            string kontonummer = "";
            int zaehlerLaenge = (""+zaehler).Length;

            for (int i = 0; i < 10; i++)
            {
                //341
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



    }
}
