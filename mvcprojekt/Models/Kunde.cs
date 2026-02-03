/*using System;
using System.Collections.Generic;
using System.Text;

namespace Mvcprojekt.Models
{
    internal class Kunde
    {
        //Attribute

        public int kundennummer;
        private string name;
        private string adresse;
        private List<Ausleihe> ausgeliehen;
        private const int AUSLEIH_LIMIT = 5;

        // Konstruktor


        public Kunde(int kundennummer, string name, string adresse)
        {
            this.kundennummer = kundennummer;
            this.name = name;
            this.adresse = adresse;
            ausgeliehen = new List<Ausleihe>();
        }



        //methoden
        public bool pruefeAusleihLimit()
        {
            return ausgeliehen.Count < AUSLEIH_LIMIT;
        }



        public bool buchAusleihen(Ausleihe ausleihe)
           
            
        {

            if (!pruefeAusleihLimit())
            {
                Console.WriteLine("ausleihlimit erreicht");
                return false;
            }
            ausgeliehen.Add(ausleihe);
             Console.WriteLine("Buch erfolgreich ausgeliehen.");
            return true;
        }

        public bool buchZureckgeben(Ausleihe ausleihe)
        {
            if (!ausgeliehen.Contains(ausleihe))
            {
                Console.WriteLine("Dieses Buch wurde von diesem Kunden nicht ausgeliehen.");
                    return false;
            }
            ausgeliehen.Remove(ausleihe);
           Console.WriteLine("Buch erfolgreich zurückgegeben");
            return true;
                
        }
        public int anzahlAusleihen()
        {
            return ausgeliehen.Count;
          
        }

    }
}
*/


namespace Mvcprojekt.Models
{
    public class Kunde
    {
        public int Id { get; set; }
        public string ?Name { get; set; }
    }
}
