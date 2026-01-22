using System;
using System.Collections.Generic;
using System.Text;

namespace ErsterProjekt
{
    public class Methoden
    {
        public static bool IsPrime(int n) 
        {
            if (n == 0)
            {
                return false;
            }

            n = Math.Abs(n);

            if(n == 1)
            {
                return true; 
            }

            for (int zaehler = 2; zaehler < n; zaehler++)
            {
                if (n % zaehler == 0)
                {
                    return false;
                }
            }
            return true;
        }

        //gerade zahlen => immer positiv am ende
        //ungerade zahlen => negative am ende
        //5! => 5*4*3*2*1
        //20! => 20*19*18..*2*1
        public static long Factorial(int n)
        {
            if (n == 0) 
            {
                return 0;
            }

            long resultat = 1;

            bool istNegative = false;

            if (n < 0)
            {
                n = Math.Abs(n);
                istNegative = true;
            }

            for (int zahl = n; zahl > 1; zahl--)
            {
                resultat *= zahl;
            }

            if (n % 2 != 0)
            {
                resultat *= -1;
            }

            return resultat;
        }


        public static void PrintPrimesInRange(int start, int end)
        {
            string resultat = $"Die Primzahlen im Bereich von {start} bis {end} sind: ";
            List<int> primZahlen = PrimesInRange(start, end).Item2;
            foreach(int zahl in primZahlen)
            {
                resultat += $"{zahl} ";
            }
            Console.WriteLine(resultat);
        }

        private static (int,List<int>) PrimesInRange(int start, int end)
        {
            List<int> primZahlen = new List<int>();

            for (int i = start; i < end; i++)
            {
                if (IsPrime(i))
                {
                    primZahlen.Add(i);
                }
            }

            return (primZahlen.Count, primZahlen);
        }

        public static int CountPrimesInRange(int start, int end)
        {
            return PrimesInRange(start, end).Item1;
        }

        public static int SumOfDigits(int n)
        {
            int querSumme = 0;

            string zahlInTextForm = "" + n;
            
            for(int i = 0; i<zahlInTextForm.Length; i++)
            {
                querSumme += int.Parse(zahlInTextForm.Substring(i, 1));
            }
            
            return querSumme;
        }




        public static void Begruessung(string vorname)
        {
            Console.WriteLine($"Wilkommen {vorname}!!!");
        }

        //access modifier (public/private/internal/protected/protected private)
        //Static brauchen wir immer
        //Rueckgabe Typ (Typ von information die wir moeglicherweise abspeichern wollen, void wenn nicht).
        //Name der Methode. Immer mit einen Grossen Buchstabe am anfang
        public static int Summieren(int a, int b)
        {
            Console.WriteLine($"Die summe von {a} und {b} ist: {a+b}");

            return a + b;
        }
        public static int Summieren(int a, int b, int c)
        {
            Console.WriteLine($"Die summe von {a} und {b} und {c} ist: {a + b + c}");

            return a + b;
        }

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
}
