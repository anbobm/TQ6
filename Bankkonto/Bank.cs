using System;

namespace Bankkonto
{
    /*
     * Die Klasse Bank repraesentiert die Bank selbst.
     * Eine Bank hat Stammdaten wie:
     * - Name
     * - Land
     * - Filiale
     * - BIC
     *
     * Die BIC (Business Identifier Code) identifiziert weltweit eindeutig
     * ein Kreditinstitut (nicht ein einzelnes Konto!).
     */
    public class Bank
    {
        public string Name { get; }
        public string Land { get; }
        public string Filiale { get; }
        public string BIC { get; }

        public Bank(string name, string land, string filiale, string bic)
        {
            if (string.IsNullOrWhiteSpace(bic) || bic.Length < 8)
                throw new ArgumentException("BIC ist ungueltig.");

            Name = name;
            Land = land;
            Filiale = filiale;
            BIC = bic;
        }

        /*
         * Gibt alle relevanten Bankdaten als formatierten Text zurueck.
         * Diese Methode dient rein der Anzeige im Benutzerinterface.
         */
        public string BankDetailsAnzeigen()
        {
            return
                $"Bankname: {Name}\n" +
                $"Land: {Land}\n" +
                $"Filiale: {Filiale}\n" +
                $"BIC: {BIC}";
        }
    }
}