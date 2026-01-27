
using System;
using System.Collections.Generic;
using System.Text;

namespace ErsterProjekt
{
    internal class Kreditkonto : Bankkonto
    {
        private readonly decimal kreditrahmen;

        public Kreditkonto(
            string kontoinhaber,
            decimal kreditrahmen,
            string bank = "Parkbank",
            string filiale = "Wegberg")
            : base(kontoinhaber, bank, filiale)
        {
            this.kreditrahmen = kreditrahmen;
        }

        public override bool Auszahlen(decimal betrag, string ziel = "==========")
        {
            if (betrag <= 0)
            {
                Console.WriteLine("Ungültiger Betrag.");
                return false;
            }

            // Prüfen, ob Kreditrahmen überschritten wird
            if (kontostand - betrag < -kreditrahmen)
            {
                Console.WriteLine($"Kreditrahmen von {kreditrahmen:F2} EUR überschritten.");
                return false;
            }

            kontostand -= betrag;
            Console.WriteLine($"Auszahlung erfolgt. Neuer Kontostand: {kontostand:F2} EUR");
            return true;
        }
    }
}