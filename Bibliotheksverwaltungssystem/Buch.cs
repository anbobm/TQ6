using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotheksverwaltungssystem
{
    internal class Buch
    {
        //Atribute
        private string isbn;
        private string titel;
        private string autor;
        private int erscheinungsjahr;
        private bool verfuegbar;

        //Konstruktor
        public Buch(string isbn, string titel, string autor, int erscheinungsjahr)
        {
            this.isbn = isbn;
            this.titel = titel;
            this.autor = autor;
            this.erscheinungsjahr = erscheinungsjahr;
            this.verfuegbar = true;
        }
        //Methoden
        public bool IstVerfuegbar()
        { return verfuegbar; 
        }
        public void SetzeVerfuegbar()
        {  verfuegbar = true; 
        }
        public void SetzeAusgeliehen()
        {
            verfuegbar=false;
        }
        public override string ToString()
        {
            return $"[{isbn}] {titel} von {autor} ({(verfuegbar ? "verfügbar" : "ausgeliehen")})";
        }
        public string Titel
        {
            get { return titel; }
        }
    }
}
