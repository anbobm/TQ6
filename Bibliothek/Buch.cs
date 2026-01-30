using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliothek
{
    internal class Buch
    {
        public string isbn;
        public string titel;
        public string autor;
        public int erscheinungsjahr;
        public string genre;
        public bool status;

        public Buch(string titel, string autor, string isbn, int erscheinungsjahr, string genre)
        {
            this.titel = titel;
            this.autor = autor;
            this.isbn = isbn;
            this.erscheinungsjahr = erscheinungsjahr;
            this.genre = genre;
            this.status = true;
        }

    }
}
