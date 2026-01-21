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
        private string bankName;
        private string filiale;
        private string ort;
        private string adresse;

        //Konstruktor
        public Bank(string bankName, string filiale, string ort, string adresse)
        {
            kontos = new List<Bankkonto>();
            this.bankName = bankName;
            this.filiale = filiale;
            this.ort = ort;
            this.adresse = adresse;
        }

        //Methoden
        private void KontoErstellen(string kontoinhaber)
        {
            kontos.Add(new Bankkonto(kontoinhaber));
            Console.WriteLine("Dein Konto wurde erfolgreich erstellt!");
        }

        private bool KontoLoeschen(string kontonummer)
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

        private Bankkonto? KontoFindenDurchIBAN(string iban)
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

        private Bankkonto? KontoFindenDurchKontonummer(string kontonummer)
        {
            foreach (Bankkonto konto in kontos)

            {
                if (konto.GetKontonummer() == kontonummer)

                {

                    Console.WriteLine($"Das gesuchte Konto wurde gefunden");
                    return konto;

                }

            }

            Console.WriteLine("Diese IBAN existiert nicht.");
            return null;
        }

        private void BankDetailsAusgeben()
        {
            Console.WriteLine("==== BANK DETAILS ====");
            Console.WriteLine($"Bankname        : {bankName}");
            Console.WriteLine($"Filiale         : {filiale}");
            Console.WriteLine($"Ort             : {ort}");
            Console.WriteLine($"Adresse         : {adresse}");
            Console.WriteLine($"Anzahl Konten   : {kontos.Count}");
            //Console.WriteLine();

            if (kontos.Count == 0)
            {
                Console.WriteLine("Keine Konten vorhanden.");
                return;
            }

            Console.WriteLine("===== KONTEN =====");

            foreach (Bankkonto konto in kontos)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine($"Kontoinhaber : {konto.GetKontoinhaber()}");
                Console.WriteLine($"Kontonummer  : {konto.GetKontonummer()}");
                Console.WriteLine($"IBAN         : {konto.GetIBAN()}");
            }
        }

        private bool UeberweisungDurchfuehren(string quelleIBAN, string zielIBAN, decimal betrag)
        {
            Bankkonto? quelleKonto = KontoFindenDurchIBAN(quelleIBAN);
            Bankkonto? zielKonto = KontoFindenDurchIBAN(zielIBAN);

            if(quelleKonto == null)
            {
                Console.WriteLine($"Quelle Konto {quelleIBAN} existiert nicht.");
                return false;
            }
            else if(zielKonto == null)
            {
                Console.WriteLine($"Quelle Konto {zielIBAN} existiert nicht.");
                return false;
            }

            if (quelleKonto.Auszahlen(betrag, zielIBAN))
            {
                zielKonto.Einzahlen(betrag, quelleIBAN);
                Console.WriteLine($"Die Ueberweisung von: {quelleIBAN} auf: {zielIBAN} in hoehe von: {betrag} war erfolgreich.");
                return true;
            }

            return false;
        }
    
    
        public void BankMenueOeffnen()
        {
            bool aktiv = true;

            while (aktiv)
            {
                Console.WriteLine($"Wilkommen in die {bankName}. Was moechtest du heute tun?\n1. Konto Erstellen.\n2. Konto Loeschen\n3. Einloggen.\n0. Beenden.");
                string eingabe = Console.ReadLine();
                switch (eingabe)
                {
                    case "1":
                        Console.WriteLine("Sie moechten ein Konto Erstellen.");
                        Console.WriteLine("Geben Sie bitte Ihr Name ein:");
                        string name = Console.ReadLine();
                        KontoErstellen(name);
                        break;
                    case "2":
                        Console.WriteLine("Sie möchten ein Konto löschen.");
                        Console.Write("Geben Sie bitte die Kontonummer ein: ");
                        string kontoNummer = Console.ReadLine();
                        bool geloescht = KontoLoeschen(kontoNummer);

                        if (geloescht)
                            Console.WriteLine("Das Konto wurde erfolgreich gelöscht.");
                        else
                            Console.WriteLine("Das Konto konnte nicht gelöscht werden.");
                        break;
                    case "3":
                        Bankkonto? eingelogtesKonto = Einloggen();
                        if (eingelogtesKonto == null)
                            return;
                        break;
                    case "0":
                        aktiv = false;
                        break;
                    default:
                        Console.WriteLine("Ungueltige Eingabe. Versuchen Sie es bitte nochmal.");
                        break;

                }
            }
        }

        public Bankkonto? Einloggen()
        {
            Console.WriteLine("Sie moechten einloggen.");
            Console.WriteLine("Geben Sie bitte Ihr Iban ein:");
            string kontonummer = Console.ReadLine();
            Bankkonto meinKonto = KontoFindenDurchKontonummer(kontonummer);
            if (meinKonto != null)
            {
                Console.WriteLine("Geben Sie bitte Ihr pin ein:");
                string pinEingabe = Console.ReadLine();
                if (pinEingabe == meinKonto.GetPIN())
                {
                    Console.WriteLine("Login erfolgreich!");
                    return meinKonto;
                }
                else
                {
                    Console.WriteLine("Falsches PIN eingegeben.");
                }
            }
            else
            {
                Console.WriteLine("Login nicht erfolgreich .");
            }
            return null;
        }
    
    
    
    }





}
