/*using System;
using System.Collections.Generic;
using System.Text;

namespace ErsterProjekt
{
    internal class WeinachtAufgabe
    {




        //Index               0123456789 10 11 12 13 14 15


        public static void RNASequenz(string rnaSequenz)
        {
            Console.WriteLine("RNA - Proteinen Konvertierer\n===============================================");

            if (rnaSequenz == null || rnaSequenz == "")
            {
                Console.WriteLine("Leere RNA Sequenz.");
                return;
            }

            string proteine = "";

            bool stopGefunden = false;

            int zaehler = 0;

            while (!stopGefunden)
            {
                string codon = rnaSequenz.Substring(zaehler, 3);
                switch (codon)
                {
                    case "AUG":
                        proteine += "Methionin ";
                        break;
                    case "UUU" or "UUC":
                        proteine += "Phenylalanin ";
                        break;
                    case "UUA" or "UUG":
                        proteine += "Leucin ";
                        break;
                    case "UCU" or "UCC" or "UCA" or "UCG":
                        proteine += "Serin ";
                        break;
                    case "UAU" or "UAC":
                        proteine += "Tyrosin ";
                        break;
                    case "UGU" or "UGC":
                        proteine += "Cystein ";
                        break;
                    case "UGG":
                        proteine += "Tryptophan ";
                        break;
                    case "UAA" or "UAG" or "UGA":
                        Console.WriteLine("Stop Sequenz gefunden!");
                        stopGefunden = true;
                        break;
                    default:
                        Console.WriteLine("Keine RNA Sequenz eingegeben. Achten Sie auf Ihre Eingabe bitte!");
                        return;
                }
                zaehler += 3;
                if (zaehler + 3 > rnaSequenz.Length)
                {

                    Console.WriteLine("Keine Stop Sequenz gefunden.");
                    Console.WriteLine("RNA Sequenz vorbei. Programm wird terminiert.");
                    break;
                }
            }

            Console.WriteLine("Gefundene Proteinen: " + proteine);
        }
    }
}*/  