using System;
using System.Threading;

namespace Heizungssystem
{
    // Heizungsklasse
    public class Heizung
    {
        // Attribute
        private string marke;
        private int maxTemperatur;
        private string typ;
        private int aktuelleRaumtemperatur;
        private bool anAusSchaltStatus;

        // Konstruktor
        public Heizung(string marke, int maxTemperatur, string typ, int startTemperatur)
        {
            this.marke = marke;
            this.maxTemperatur = maxTemperatur;
            this.typ = typ;
            this.aktuelleRaumtemperatur = startTemperatur;
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

        public void Hauserwaermen(int gewuenschteRaumtemperatur)
        {
            if (!anAusSchaltStatus)
            {
                Console.WriteLine("Heizung ist aus.");
                return;
            }

            if (gewuenschteRaumtemperatur > maxTemperatur)
            {
                gewuenschteRaumtemperatur = maxTemperatur;
            }

            Console.WriteLine("Aktuelle Raumtemperatur: " + aktuelleRaumtemperatur + " Grad");
            Console.WriteLine("Zieltemperatur: " + gewuenschteRaumtemperatur + " Grad");

            while (aktuelleRaumtemperatur < gewuenschteRaumtemperatur && anAusSchaltStatus)
            {
                aktuelleRaumtemperatur++;
                Console.WriteLine("Raumtemperatur steigt auf: " + aktuelleRaumtemperatur + " Grad");

                Thread.Sleep(500); // simuliert Zeit (0,5 Sekunden)
            }

            Console.WriteLine("Zieltemperatur erreicht.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Objekt erzeugen (Starttemperatur 15 Grad)
            Heizung heizung = new Heizung("08/15", 80, "Wasser", 15);

            heizung.anschalten();
            heizung.Hauserwaermen(20);
            heizung.ausschalten();

            Console.ReadLine();
        }
    }
}