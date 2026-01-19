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

        //Konstruktor
        public Bankkonto(string kontoinhaber, string bank, string filiale)
        {
            this.kontoinhaber = kontoinhaber;
            this.bank = bank;
            this.filiale = filiale;
            kontostand = 0;
            pin = PinErstellen();
            bic = BicErstellen();
            Console.WriteLine(bic);
            //iban
            //kontonummer
            //bic
            //Anforderungen für BIC:
            //BIC soll zufällig 4 zeichen erstellen und abspeicher, dann DE abspeicher, dann 2 zufällige Buchstaben, dann erste 2 Buchstaben von filiale und eine zufällige zwahl zwischen 0 und 9
            //pin
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
                bankcode += random.Next(0, 10);
            }

            BIC += bankcode + countrycode + stadt + filiale;
            return BIC;
        }

        //Methode



    }
}
