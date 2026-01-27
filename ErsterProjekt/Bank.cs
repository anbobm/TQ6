using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

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
            Console.WriteLine("Welchen Kontotyp moechten Sie?");
            Console.WriteLine("1. Standardkonto");
            Console.WriteLine("2. Kreditkonto");
            Console.WriteLine("3. Investmentkonto");
            Console.WriteLine("4. Tagesgeldkonto");

            string auswahl = Console.ReadLine();

            switch (auswahl)
            {
                case "1":
                    kontos.Add(new Bankkonto(kontoinhaber));
                    break;
                case "2":
                    Console.Write("Bitte Kreditrahmen eingeben: ");
                    decimal kreditrahmen = decimal.Parse(Console.ReadLine());

                    kontos.Add(new Kreditkonto(kontoinhaber, kreditrahmen));
                    break;
                case "3":
                    kontos.Add(new Investmentkonto(kontoinhaber));
                    break;
                case "4":
                    kontos.Add(new Tagesgeldkonto(kontoinhaber));
                    break;
                default:
                    Console.WriteLine("Ungueltige Auswahl.");
                    return;
            }

            Console.WriteLine("Konto erfolgreich erstellt!");
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
        private Bankkonto? KontoFindenDurchKontonummer(string Kontonummer)
        {
            foreach (Bankkonto konto in kontos)

            {
                if (konto.GetKontonummer() == Kontonummer)

                {

                    Console.WriteLine($"Das gesuchte Konto wurde gefunden");
                    return konto;

                }

            }

            Console.WriteLine("Diese Kontonummer existiert nicht.");
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
            string kontonummer;
            bool aktiv = true;

            while (aktiv)
            {
                Console.WriteLine($"Wilkommen in die {bankName}. Was moechtest du heute tun?\n1. Konto Erstellen.\n2. Konto Loeschen\n3. Einloggen.\n4. Bank Details ausgeben\n0.Beenden");
                string eingabe = Console.ReadLine();
                switch (eingabe)
                {
                    case "1":
                        Console.WriteLine("Sie moechten ein Konto Erstellen.");
                        Console.WriteLine("Geben Sie bitte Ihren Namen ein:");
                        string name = Console.ReadLine();
                        KontoErstellen(name);
                        break;
                    case "2":
                        Console.WriteLine("Sie möchten ein Konto Löschen");
                        Console.WriteLine("Geben sie bitte die Kontonummer ein");
                        kontonummer = Console.ReadLine();
                        KontoLoeschen(kontonummer);
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
                    case "4":
                        BankDetailsAusgeben();
                        break;
                    case "0":
                        aktiv = false;
                        Console.WriteLine("Auf Wiedersehen");
                        break;
                    default:
                        Console.WriteLine("Ungültige Eingabe");
                        break;

                }
            }

            
            

        }

        private Bankkonto? Einloggen()
        {
            Console.WriteLine("Sie moechten einloggen.");
            Console.WriteLine("Geben Sie bitte Ihre Kontonummer ein:");
            string kontonummer = Console.ReadLine();
            Bankkonto meinKonto = KontoFindenDurchKontonummer(kontonummer);
            if (meinKonto != null)
            {
                Console.WriteLine("Geben Sie bitte Ihr pin ein:");
                string pinEingabe = Console.ReadLine();
                if (pinEingabe == meinKonto.GetPin())
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

        private void KontoMenueOeffnen(Bankkonto eingelogtesKonto)
        {
            string auswahl = "0";
            decimal betrag = 0;
            bool aktiv = true;
            while (aktiv)
            {
            Console.WriteLine("Willkommen in ihrem Kundenmenü");
            Console.WriteLine("\nWas wollen sie tun?");
            Console.WriteLine("\n1.Einzahlen");
            Console.WriteLine("\n2.Auszahlen");
            Console.WriteLine("\n3.Kontostand");
            Console.WriteLine("\n4.Kontoauszug");
            Console.WriteLine("\n5.Überweisung");
            Console.WriteLine("\n0.Beenden");
            auswahl = Console.ReadLine();
            
                switch (auswahl)
                {
                    case "1":
                        Console.WriteLine("Bitte gebe den gewünschten Betrag ein");
                        try
                        {
                            betrag = Convert.ToDecimal(Console.ReadLine());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        eingelogtesKonto.Einzahlen(betrag);
                        break;
                    case "2":
                        Console.WriteLine("Bitte gebe den gewünschten Betrag ein");
                        try
                        {
                            betrag = Convert.ToDecimal(Console.ReadLine());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        eingelogtesKonto.Auszahlen(betrag);
                        break;
                    case "3":
                        eingelogtesKonto.Kontostand();
                        break;
                    case "4":
                        eingelogtesKonto.Kontoauszug();
                        break;
                    case "5":
                        Console.Write("Ziel-IBAN: ");
                        string zielIBAN = Console.ReadLine();

                        Console.Write("Betrag: ");
                        betrag = Convert.ToDecimal(Console.ReadLine());

                        UeberweisungDurchfuehren(eingelogtesKonto.GetIBAN(),zielIBAN,betrag);
                        break;
                    case "0":
                        aktiv = false;
                        Console.WriteLine("Logout erfolgreich");
                        break;
                    default:
                        Console.WriteLine("Ungütlige Eingabe");
                        break;


                }
                    
            }

        }


    }

}

