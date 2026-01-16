using System;

namespace Heizungssystem
{
    // Heizungsklasse
    public class Heizung
    {
        // Attribute
        private string marke;
        private int maxTemperatur;
        private string typ;
        private int aktuelleTemperatur;
        private bool anAusSchaltStatus;

        // Konstruktor
        public Heizung(string marke, int maxTemperatur, string typ)
        {
            this.marke = marke;
            this.maxTemperatur = maxTemperatur;
            this.typ = typ;
            this.aktuelleTemperatur = 0;
            this.anAusSchaltStatus = false;
        }

        // Methoden
        public void anschalten()
        {
            anAusSchaltStatus = true;
            Console.WriteLine("Heizung angeschaltet.");
        }

        public void ausschalten()
        {
            anAusSchaltStatus = false;
            Console.WriteLine("Heizung ausgeschaltet.");
        }

        public void Hauserwaermen(int gewuenschteTemp)
        {
            if (!anAusSchaltStatus)
            {
                Console.WriteLine("Heizung ist aus.");
                return;
            }

            if (gewuenschteTemp > maxTemperatur)
            {
                aktuelleTemperatur = maxTemperatur;
            }
            else
            {
                aktuelleTemperatur = gewuenschteTemp;
            }

            Console.WriteLine("Aktuelle Temperatur: " + aktuelleTemperatur + " Grad");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Objekt erzeugen
            Heizung heizung = new Heizung("08/15", 80, "Wasser");

            // Heizung benutzen
            heizung.anschalten();
            heizung.Hauserwaermen(25);
            heizung.ausschalten();

            Console.ReadLine();
        }
    }
}