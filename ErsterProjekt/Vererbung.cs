using System;
using System.Collections.Generic;
using System.Text;

namespace ErsterProjekt
{
    public enum ArtBewegung
    {
        Gleis,
        Strasse,
        Wasser
    }
    internal class OeffentlichesNahverker
    {
        //Eigenschaften/Attribute
        int maxKapazitaet;
        double zuverlaessigkeit;
        protected string linie;
        Dictionary<int, List<int>> zeitplan;
        bool aktiv;
        ArtBewegung art;

        public OeffentlichesNahverker(int maxKapazitaet, double zuverlaessigkeit, string linie, bool aktiv, Dictionary<int, List<int>> zeitplan, ArtBewegung art)
        {
            this.maxKapazitaet = maxKapazitaet;
            this.zuverlaessigkeit = zuverlaessigkeit;
            this.linie = linie;
            this.zeitplan = zeitplan;
            this.aktiv = aktiv;
            this.art = art;
        }

        //Methoden/Funktionen
        public void PersonenBefoerdern()
        {
            Console.WriteLine($"{linie} befördert Personen.");
        }
        public bool LeerFahrt()
        {
            maxKapazitaet = 0;
            return true;
        }
        public void Fahren()
        {
            Console.WriteLine($"{linie} fährt los.");
        }
        public virtual void Halten()
        {
            Console.WriteLine($"Wir halten an einer Haltestelle.");
        }

        public bool Wartung()
        {
            aktiv = !aktiv;
            return aktiv;
        }
    }

    internal class Bus : OeffentlichesNahverker
    {
        int linieNummer;
        public Bus(int maxKapazitaet, double zuverlaessigkeit, int linieNummer, Dictionary<int, List<int>> zeitplan) : base(maxKapazitaet, zuverlaessigkeit, "B" +linieNummer, false, zeitplan, ArtBewegung.Strasse)
        {
            this.linieNummer = linieNummer;
        }
        public override void Halten()
        {
            Console.WriteLine($"{linie} hält an einer Haltestelle.");
        }
    }

    internal class Zug
    {

    }

}
