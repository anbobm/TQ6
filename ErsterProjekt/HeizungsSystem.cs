using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ErsterProjekt
{
    public class Heizungsystem

    {
        // Attribute
        public string Marke; public int MaxTemperatur; public string Typ; public int AktuelleTemperatur; public string AnAusSchaltStatus;


        // Konstruktor
        public Heizungsystem(string marke, int maxTemperatur, string typ, int aktuelleTemperatur, string anAusSchaltStatus)
        {
            this.Marke = marke;
            this.MaxTemperatur = maxTemperatur;
            this.Typ = typ; this.AktuelleTemperatur = aktuelleTemperatur; 
            this.AnAusSchaltStatus = anAusSchaltStatus; 
        }
        // Methode: Heizung erwärmt das Haus

        public void Hauserwaermen(int gewuenschteTemp) 
        { 
            if (AnAusSchaltStatus == "aus") 
            { Console.WriteLine("Heizung ist aus. Bitte zuerst anschalten.");
                return; 
            } 
            if (gewuenschteTemp > MaxTemperatur)
            { Console.WriteLine($"Gewünschte Temperatur überschreitet MaxTemperatur von {MaxTemperatur}°C.");
                return; 
            } 
            for (int i = AktuelleTemperatur; i < gewuenschteTemp; i++)
            { 
                AktuelleTemperatur = i; 
                Console.WriteLine($"Unser Haus wird wärmer. Aktuelle Temperatur: {AktuelleTemperatur}°C");
            }
            Console.WriteLine($"Zieltemperatur {gewuenschteTemp}°C erreicht.");
             } // Methode:
          // Heizung ausschalten
           public void Ausschalten()
        { 
            AnAusSchaltStatus = "aus";
            Console.WriteLine("Heizung wurde ausgeschaltet.");
        } // Methode: Heizung anschalten
          public void Anschalten()
        { 
            AnAusSchaltStatus = "an"; 
            Console.WriteLine("Heizung wurde angeschaltet."); 
        }



    }
}
