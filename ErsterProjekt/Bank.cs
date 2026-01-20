using System;
using System.Collections.Generic;
using System.Text;

namespace ErsterProjekt
{
    internal class Bank
    {
        //Attribute
        private List<Bankkonto> kontos;
        /*
         * liste von alle Bankkontos
         * Bank name
         * Filiale
         * Ort
         * Adresse
         * 
         */

        //Konstruktor
        public Bank()
        {
            kontos = new List<Bankkonto>();
        }

        //Methoden
        public void KontoErstellen(string kontoinhaber)
        {
            kontos.Add(new Bankkonto(kontoinhaber));
            Console.WriteLine("Dein Konto wurde erfolgreich erstellt!");
        }

        public bool KontoLoeschen(string kontonummer)
        {
            foreach(Bankkonto konto in kontos)
            {
                if (konto.GetKontonummer() == kontonummer)
                {
                    kontos.Remove(konto);
                    return true;
                }
            }
            Console.WriteLine("Diese Kontonummer existiert nicht.");
            return false;
        }

        public Bankkonto KontoFindenDurchIBAN(string iban)
        {
            foreach (Bankkonto konto in kontos)

            {
                if (konto.GetIBAN() == iban)

                {

                    Console.WriteLine($"Das gesuchte Konto wurde gefunden");
                    return konto;

                }

            }

            Console.WriteLine("Diese IBAN existiert nicht.");
            return null;
        }
        /*
         * bankDetailsAusgeben, public bool UeberweisungDurchfuehren(string quelleIBAN, string zielIBAN)
         */
        public bool UeberweisungDurchfuehren(string quelleIBAN, string zielIBAN)
        {
            //TODO
            return false;
        }
    }
}
