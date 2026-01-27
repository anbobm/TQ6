using System;
using System.Collections.Generic;
using System.Text;

namespace Bankkonto.Konten
{
    public class Girokonto : Bankkonto
    {
        public decimal Dispolimit { get; private set; }

        public Girokonto(
            string kontoinhaber,
            string kontonummer,
            decimal startguthaben = 0m,
            decimal dispolimit = 0m)
            : base(kontoinhaber, kontonummer, startguthaben)
        {
            if (dispolimit < 0)
                throw new ArgumentException("Dispolimit darf nicht negativ sein.");

            Dispolimit = dispolimit;
        }

        protected override bool DarfAuszahlen(decimal betrag)
        {
            return Kontostand - betrag >= -Dispolimit;
        }

        public void SetzeDispolimit(decimal neuesDispolimit)
        {
            if (neuesDispolimit < 0)
                throw new ArgumentException("Dispolimit darf nicht negativ sein.");

            Dispolimit = neuesDispolimit;
        }
    }
}