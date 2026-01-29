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

        public Buch(string titel, string autor, string isbn, int erscheinungsjahr)
        {
            this.titel = titel;
            this.autor = autor;
            this.isbn = isbn;
            this.erscheinungsjahr = erscheinungsjahr;
        }

    }
}
