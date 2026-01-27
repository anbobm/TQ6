using Bankkonto.Buchungen;
using System;
using System.Collections.Generic;
using System.Text;
/*
 * Wir brauchen zunaechst drei weitere Klassen! Kindklassen von Bankkonto.
 * 1. Kreditkonto: Es soll moeglich sein, dass der kontostand negativ ist.
 * 2. Investmentkonto: Wir duerfen hiervon nicht auszahlen bis der aktueller datum gleich 2060-01-01 ist.
 *                      Zusaetzlich bekommen wir jeden Monat eine erhoehung vom kontostand um 1.25%.
 * 3. Tagesgeldkonto: Eine Tagesgeldkonto darf maximal 500$ pro tag auszahlen, 
 *                      und bekommt jeden monat eine erhoehung vom Kontostand um 0.7%.
 */


namespace Bankkonto.Konten
{
    public abstract class Bankkonto
    {
        // ===== Eigenschaften =====
        public string Kontoinhaber { get; }
        public string Kontonummer { get; }
        public DateTime Eroeffnungsdatum { get; }

        public decimal Kontostand { get; protected set; }

        protected List<Buchung> Buchungen { get; } = new();

        // ===== Konstruktor =====
        protected Bankkonto(string kontoinhaber, string kontonummer, decimal startguthaben = 0m)
        {
            if (string.IsNullOrWhiteSpace(kontoinhaber))
                throw new ArgumentException("Kontoinhaber darf nicht leer sein.");

            if (string.IsNullOrWhiteSpace(kontonummer))
                throw new ArgumentException("Kontonummer darf nicht leer sein.");

            if (startguthaben < 0)
                throw new ArgumentException("Startguthaben darf nicht negativ sein.");

            Kontoinhaber = kontoinhaber;
            Kontonummer = kontonummer;
            Kontostand = startguthaben;
            Eroeffnungsdatum = DateTime.Now;

            if (startguthaben > 0)
            {
                Buche(startguthaben, Buchungsart.Einzahlung, "Startguthaben");
            }
        }

        // ===== Öffentliche Methoden =====

        public virtual void Einzahlen(decimal betrag)
        {
            PruefeBetrag(betrag);

            Kontostand += betrag;
            Buche(betrag, Buchungsart.Einzahlung, "Einzahlung");
        }

        public virtual void Auszahlen(decimal betrag)
        {
            PruefeBetrag(betrag);

            if (!DarfAuszahlen(betrag))
                throw new InvalidOperationException("Auszahlung nicht erlaubt.");

            Kontostand -= betrag;
            Buche(-betrag, Buchungsart.Auszahlung, "Auszahlung");
        }

        public virtual void Ueberweisen(decimal betrag, Bankkonto zielkonto)
        {
            if (zielkonto == null)
                throw new ArgumentNullException(nameof(zielkonto));

            Auszahlen(betrag);
            zielkonto.Einzahlen(betrag);

            Buche(-betrag, Buchungsart.Ueberweisung, $"Überweisung an {zielkonto.Kontonummer}");
            zielkonto.Buche(betrag, Buchungsart.Ueberweisung, $"Überweisung von {Kontonummer}");
        }

        public string KontoauszugErstellen()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Kontoinhaber: {Kontoinhaber}");
            sb.AppendLine($"Kontonummer: {Kontonummer}");
            sb.AppendLine($"Kontostand: {Kontostand:C}");
            sb.AppendLine("Buchungen:");

            foreach (var buchung in Buchungen)
            {
                sb.AppendLine(buchung.ToString());
            }

            return sb.ToString();
        }

        // ===== Erweiterungspunkt für Kindklassen =====

        protected virtual bool DarfAuszahlen(decimal betrag)
        {
            return Kontostand >= betrag;
        }

        // ===== Hilfsmethoden =====

        protected void PruefeBetrag(decimal betrag)
        {
            if (betrag <= 0)
                throw new ArgumentException("Betrag muss größer als 0 sein.");
        }

        protected void Buche(decimal betrag, Buchungsart art, string beschreibung)
        {
            Buchungen.Add(new Buchung(DateTime.Now, betrag, art, beschreibung));
        }
    }
}