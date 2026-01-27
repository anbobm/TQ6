using System;
using System.Collections.Generic;
using System.Text;

namespace Bankkonto.Konten
{
    public class Kreditkonto : Bankkonto
    {
        /// <summary>
        /// Maximale erlaubte Verschuldung (positiver Wert).
        /// Beispiel: 5000 bedeutet, der Kontostand darf bis -5000 gehen.
        /// </summary>
        public decimal Kreditlimit { get; private set; }

        public Kreditkonto(
            string kontoinhaber,
            string kontonummer,
            decimal kreditlimit = decimal.MaxValue)
            : base(kontoinhaber, kontonummer, 0m)
        {
            if (kreditlimit <= 0)
                throw new ArgumentException("Kreditlimit muss größer als 0 sein.");

            Kreditlimit = kreditlimit;
        }

        protected override bool DarfAuszahlen(decimal betrag)
        {
            return Kontostand - betrag >= -Kreditlimit;
        }

        public void SetzeKreditlimit(decimal neuesKreditlimit)
        {
            if (neuesKreditlimit <= 0)
                throw new ArgumentException("Kreditlimit muss größer als 0 sein.");

            Kreditlimit = neuesKreditlimit;
        }
    }
}