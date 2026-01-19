using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ErsterProjekt
{
    internal class Hund
    {
        public string rasse;
        public string farbe;
        public string besitzer;
        public double gewicht;
        public Hund(string rasse, string farbe, string besitzer, double gewicht)
        {
            this.rasse = rasse;
            this.farbe = farbe;
            this.besitzer = besitzer;
            this.gewicht = 0;

        }
        public static void laufen()
        {
            bool beinbewegung;
            if (beinbewegung = true)
            {
                Console.WriteLine("Der Hund bewegt sich!");
            }
            else
            {
                Console.WriteLine("Der Hund ist so faul wie sein Besitzer");
            }
        }
        public static void bellen()
        {
            bool bellen;
            if (bellen = true)
            {
                Console.WriteLine("Der Hund bellt");
            }
            else
            {
                Console.WriteLine("Der Hund bellt nicht");
            }

        }
        public static void sitzen()
        {
            bool sitzen;
            if (sitzen = true)
            {
                Console.WriteLine("Der Hund sitzt");
            }
            else
            {
                Console.WriteLine("Der Hund sitzt nicht");
            }
        }

        public static void rollen()
        {
            bool rollen;
            if (rollen = true)
            {
                Console.WriteLine("Der Hund rollt sich hin und her");
            }
            else
            {
                Console.WriteLine("Der Hund tut nichts");
            }
        }
    }
}
