using Bankkonto.Buchungen;
using System;

namespace Bankkonto.Buchungen
{
    public class Buchung
    {
        public DateTime Datum { get; }
        public decimal Betrag { get; }
        public Buchungsart Art { get; }
        public string Beschreibung { get; }

        public Buchung(
            DateTime datum,
            decimal betrag,
            Buchungsart art,
            string beschreibung)
        {
            Datum = datum;
            Betrag = betrag;
            Art = art;
            Beschreibung = beschreibung;
        }

        public override string ToString()
        {
            return $"{Datum:yyyy-MM-dd HH:mm} | {Art,-12} | {Betrag,10:C} | {Beschreibung}";
        }
    }
}