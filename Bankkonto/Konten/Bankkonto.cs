using Bankkonto.Buchungen;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Die abstrakte Klasse Bankkonto bildet die Basis fuer alle Kontoarten.
 *
 * Kindklassen:
 * 1. Girokonto
 * 2. Kreditkonto
 * 3. Investmentkonto
 * 4. Tagesgeldkonto
 *
 * Diese Klasse enthaelt nur allgemeine Logik,
 * keine kontoartspezifischen Regeln.
 */

namespace Bankkonto.Konten
{
    public abstract class Bankkonto
    {
        /*
         * Vereinfachter Kontonummernzaehler.
         * In echten Banksystemen waere dies deutlich komplexer.
         */
        private static int naechsteKontonummer = 100000;

        // ===== Eigenschaften =====

        public string Kontoinhaber { get; }
        public string Kontonummer { get; }

        /*
         * Die IBAN (International Bank Account Number)
         * identifiziert ein Konto eindeutig.
         *
         * Aufbau (vereinfacht):
         * - Laenderkennung (z. B. DE)
         * - Pruefziffer
         * - Bankkennung (aus der BIC abgeleitet)
         * - Kontonummer
         */
        public string IBAN { get; }

        public DateTime Eroeffnungsdatum { get; }

        /*
         * Jedes Konto gehoert zu genau einer Bank.
         */
        public Bank Bank { get; }

        public decimal Kontostand { get; protected set; }

        /*
         * Liste aller Buchungen (Einzahlungen, Auszahlungen, Zinsen usw.)
         */
        protected List<Buchung> Buchungen { get; } = new();

        // ===== Konstruktor =====

        /*
         * Beim Erstellen eines Bankkontos wird:
         * - die Bank zugeordnet
         * - eine Kontonummer erzeugt
         * - daraus eine IBAN generiert
         * - optional ein Startguthaben gebucht
         */
        protected Bankkonto(Bank bank, string kontoinhaber, decimal startguthaben = 0m)
        {
            Bank = bank ?? throw new ArgumentNullException(nameof(bank));

            if (string.IsNullOrWhiteSpace(kontoinhaber))
                throw new ArgumentException("Kontoinhaber darf nicht leer sein.");

            if (startguthaben < 0)
                throw new ArgumentException("Startguthaben darf nicht negativ sein.");

            Kontoinhaber = kontoinhaber;
            Kontonummer = (naechsteKontonummer++).ToString();
            IBAN = ErzeugeIban(bank, Kontonummer);
            Kontostand = startguthaben;
            Eroeffnungsdatum = DateTime.Now;

            if (startguthaben > 0)
            {
                Buche(startguthaben, Buchungsart.Einzahlung, "Startguthaben");
            }
        }

        // ===== Oeffentliche Methoden =====

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

            Buche(-betrag, Buchungsart.Ueberweisung, $"Überweisung an {zielkonto.IBAN}");
            zielkonto.Buche(betrag, Buchungsart.Ueberweisung, $"Überweisung von {IBAN}");
        }

        /*
         * Gibt alle wichtigen Kontodaten zur Anzeige aus.
         */
        public string KontodetailsAnzeigen()
        {
            return
                $"Kontoinhaber: {Kontoinhaber}\n" +
                $"IBAN: {IBAN}\n" +
                $"Kontostand: {Kontostand:C}\n" +
                $"Eroeffnet am: {Eroeffnungsdatum:d}\n" +
                $"Bank: {Bank.Name}";
        }

        public string KontoauszugErstellen()
        {
            var sb = new StringBuilder();

            sb.AppendLine(KontodetailsAnzeigen());
            sb.AppendLine("Buchungen:");

            foreach (var buchung in Buchungen)
            {
                sb.AppendLine(buchung.ToString());
            }

            return sb.ToString();
        }

        // ===== Erweiterungspunkt fuer Kindklassen =====

        /*
         * Standardregel:
         * Es darf nur ausgezahlt werden, wenn genug Guthaben vorhanden ist.
         * Kredit- oder Dispo-Logik wird in Kindklassen ueberschrieben.
         */
        protected virtual bool DarfAuszahlen(decimal betrag)
        {
            return Kontostand >= betrag;
        }

        // ===== Hilfsmethoden =====

        protected void PruefeBetrag(decimal betrag)
        {
            if (betrag <= 0)
                throw new ArgumentException("Betrag muss groesser als 0 sein.");
        }

        protected void Buche(decimal betrag, Buchungsart art, string beschreibung)
        {
            Buchungen.Add(new Buchung(DateTime.Now, betrag, art, beschreibung));
        }

        /*
         * Vereinfachte IBAN-Erzeugung fuer Lernzwecke.
         * Diese ist NICHT bankrechtlich korrekt,
         * zeigt aber den grundsaetzlichen Aufbau.
         */
        private static string ErzeugeIban(Bank bank, string kontonummer)
        {
            return $"DE00{bank.BIC.Substring(0, 4)}{kontonummer.PadLeft(10, '0')}";
        }
    }
}
