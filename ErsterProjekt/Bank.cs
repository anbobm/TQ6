
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
        private void KontoErstellen(string kontoinhaber, string kontoArt)
        {
            if (kontoArt.ToLower() == "tagesgeld")
            {
                kontos.Add(new Tagesgeldkonto(kontoinhaber, bankName, filiale));
            }
            else if (kontoArt.ToLower() == "investment")
            {
                kontos.Add(new Investmentkonto(kontoinhaber, bankName, filiale));
            }
            else if (kontoArt.ToLower() == "kredit")
            {
                kontos.Add(new Kreditkonto(kontoinhaber, 500, bankName, filiale));
            }
            else
            {
                kontos.Add(new Bankkonto(kontoinhaber, bankName, filiale));
            }
            Console.WriteLine("Dein Konto wurde erfolgreich erstellt!");
        }

        private bool KontoLoeschen(string kontonummer)
        {
            foreach (Bankkonto konto in kontos)
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

            if (quelleKonto == null)
            {
                Console.WriteLine($"Quelle Konto {quelleIBAN} existiert nicht.");
                return false;
            }
            else if (zielKonto == null)
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
                Console.WriteLine($"Wilkommen in der {bankName}. Was moechtest du heute tun?\n1. Konto Erstellen.\n2. Konto Loeschen\n3. Einloggen.\n0. Beenden.");
                string eingabe = Console.ReadLine();
                switch (eingabe)
                {
                    case "1":
                        Console.WriteLine("Sie moechten ein Konto Erstellen.");
                        Console.WriteLine("Geben Sie bitte Ihr Name ein:");
                        string name = Console.ReadLine();
                        Console.WriteLine($"Hallo {name}, was fuer einen Konto moechten Sie haben? Tagesgeld, Investment, Kredit oder Normal?");
                        Console.WriteLine("Bei ungueltiger Eingabe wird einen Normalen Konto fuer Ihnen erstellt.");
                        string kontotyp = Console.ReadLine();
                        KontoErstellen(name, kontotyp);
                        
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
                        else
                        {
                            KontoMenueOeffnen(eingelogtesKonto);
                        }
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
        //1. Einzahlen 2. Auszahlen 3. Kontostand 4. Kontoauszug 5. Ueberweisung 0. Beenden

        private void KontoMenueOeffnen(Bankkonto eingelogtesKonto)
        {
            bool aktiv = true;

            while (aktiv)
            {
                Console.WriteLine($"\nWillkommen {eingelogtesKonto.GetKontoinhaber()}");
                Console.WriteLine("Was moechten Sie heute tun?\n");
                Console.WriteLine(
                    "1. Einzahlen\n" +
                    "2. Auszahlen\n" +
                    "3. Kontostand anzeigen\n" +
                    "4. Kontoauszug anzeigen\n" +
                    "5. Ueberweisung\n" +
                    "0. Abmelden");
                string eingabe = Console.ReadLine();
                switch (eingabe)
                {
                    case "1":

                        Console.WriteLine("Bitte Betrag eingeben: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal betragEin))
                        {
                            eingelogtesKonto.Einzahlen(betragEin);
                        }
                        else
                        {
                            Console.WriteLine("Ungueltige Eingabe. Bitte eine Zahl eingeben.");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Bitte Betrag eingeben: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal betragAus))
                        {
                            eingelogtesKonto.Auszahlen(betragAus);
                        }
                        else
                        {
                            Console.WriteLine("Ungueltige Eingabe. Bitte eine Zahl eingeben.");
                        }
                        break;

                    case "3":
                        eingelogtesKonto.KontostandAnzeigen();
                        break;

                    case "4":
                        eingelogtesKonto.Kontoauszug();
                        break;

                    case "5":
                        Console.WriteLine("Bitte Ziel-IBAN eingeben:");
                        string zielIban = Console.ReadLine();
                        Console.WriteLine("Bitte Betrag eingeben:");
                        if (decimal.TryParse(Console.ReadLine(), out decimal betragUeberweisung))
                        {
                            bool erfolg = UeberweisungDurchfuehren(eingelogtesKonto.GetIBAN(), zielIban, betragUeberweisung);
                            if (!erfolg)
                            {
                                Console.WriteLine("Die Überweisung konnte nicht durchgeführt werden.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ungültiger Betrag.");
                        }
                        break;

                    case "0":
                        aktiv = false;
                        break;


                }
            }
        }
        private Bankkonto? Einloggen()
        {
            Console.WriteLine("Sie moechten einloggen.");
            Console.WriteLine("Geben Sie bitte Ihr Kontonummer ein:");
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
