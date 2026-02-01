
using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliothekverwaltungsystemm
{
    internal class Bibliothek

    {
        //Attribute

        private List<Buch> buecher;
        private List<Ausleihe> ausleihen;
        private List<Kunde> kunden;


        //konstruktor


        public Bibliothek()
        {
            buecher = new List<Buch>();
            ausleihen = new List<Ausleihe>();
            kunden = new List<Kunde>();
        }


   

    //methoden
    public bool kundeErstellen(int kundennummer, string name, string adresse)
        {
            Kunde k = new Kunde(kundennummer, name, adresse);
            kunden.Add(k);
            Console.WriteLine("Kunde erfolgreich erstellt.");
            return true;
        }

        public bool kundeLoeschen(Kunde kunde)
        {
            if (!kunden.Contains(kunde))
            {
                Console.WriteLine("Kunde existiert nicht.");
                return false;
            }
            kunden.Remove(kunde);
            Console.WriteLine("Kunde erfolgreich gelöscht.");
            return true;

        }
        // ----------------------------- 
        // Buchverwaltung 
        // -----------------------------
        public void buchHinzufuegen(Buch buch)
        {
            buecher.Add(buch);
            Console.WriteLine("Buch hinzugefügt.");
        }
        public Buch findeBuch(string isbn)
        {
            return buecher.Find(b => b.isbn == isbn);
        }
        public bool pruefeBuchVerfuegbarkeit(string isbn)
        {
            Buch buch = findeBuch(isbn);
            if (buch == null)
            {
                Console.WriteLine("Buch nicht gefunden.");
                return false;
            }
            return buch.IstVerfuegbar();
        }
        // -----------------------------
        // Ausleihprozess starten
        // -----------------------------
        public bool ausleihProzessStarten(string isbn, int kundennummer)
        {
            Buch buch = findeBuch(isbn);
            Kunde kunde = kunden.Find(k => k.kundennummer == kundennummer);
            if (buch == null || kunde == null)
            {
                Console.WriteLine("Buch oder Kunde nicht gefunden.");
                return false;
            }
            if (!buch.IstVerfuegbar())
            {
                Console.WriteLine("Buch ist nicht verfügbar.");
                return false;
            }
            Ausleihe a = new Ausleihe(buch, kunde, DateOnly.FromDateTime(DateTime.Now));
            a.starteAusleihe();
            ausleihen.Add(a);
            Console.WriteLine("Ausleihe gestartet.");
            return true;
        }
        // ----------------------------- 
        // Ausleihe ändern 
        // -----------------------------
        public bool ausleihProzessAendern(Ausleihe ausleihe, DateOnly neuesRueckgabedatum)
        {
            if (!ausleihen.Contains(ausleihe))
            {
                Console.WriteLine("Ausleihe existiert nicht.");
                return false;
            }
            ausleihe.aendereRueckgabedatum(neuesRueckgabedatum);
            Console.WriteLine("Rückgabedatum geändert.");
            return true;
        }
        // -----------------------------
        // Ausleihe abschließen
        // -----------------------------
        public bool ausleihProzessAbschliessen(Ausleihe ausleihe)
        {
            if (!ausleihen.Contains(ausleihe))
            {
                Console.WriteLine("Ausleihe existiert nicht.");
                return false;
            }
            ausleihe.beendeAusleihe();
            ausleihen.Remove(ausleihe);
            Console.WriteLine("Ausleihe abgeschlossen.");
            return true;
        }
    }
}
