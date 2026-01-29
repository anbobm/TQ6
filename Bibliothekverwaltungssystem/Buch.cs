using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotheksverwaltung
{
    public class Buch
    {
        // Alle Attribute/Variablen sind private.
        private string isbn;
        private string titel;
        private string autor;
        private int erscheinungsjahr;

        // Konstruktor
        public Buch(string isbn, string titel, string autor, int erscheinungsjahr)
        {
            this.isbn = isbn;
            this.titel = titel;
            this.autor = autor;
            this.erscheinungsjahr = erscheinungsjahr;
        }

        // Methoden

        // + getISBN() : string
        public string ISBN
        {
            get { return isbn; }
        }

        // + getTitel() : string
        public string Titel
        {
            get { return titel; }
        }

        // + getAutor() : string
        public string Autor
        {
            get { return autor; }
        }

        // + getErscheinungsjahr() : int
        public int Erscheinungsjahr
        {
            get { return erscheinungsjahr; }
        }
    }
}