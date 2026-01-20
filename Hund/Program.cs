using System;

namespace Hund
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hund meinHund = new Hund("Labrador", "Schwarz", "Max", 32.5);

            meinHund.Laufen();
            meinHund.Bellen();
            meinHund.Sitzen();
            meinHund.Rollen();
        }
    }

    public class Hund
    {
        // Eigenschaften
        public string Rasse { get; set; }
        public string Farbe { get; set; }
        public string Besitzer { get; set; }
        public double Gewicht { get; set; }

        // Konstruktor
        public Hund(string rasse, string farbe, string besitzer, double gewicht)
        {
            Rasse = rasse;
            Farbe = farbe;
            Besitzer = besitzer;
            Gewicht = gewicht;
        }

        // Methoden
        public void Laufen()
        {
            Console.WriteLine("Der Hund läuft.");
        }

        public void Bellen()
        {
            Console.WriteLine("Der Hund bellt.");
        }

        public void Sitzen()
        {
            Console.WriteLine("Der Hund sitzt.");
        }

        public void Rollen()
        {
            Console.WriteLine("Der Hund rollt.");
        }
    }
}