//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Text;

//namespace ErsterProjekt
//{
//    internal class WeihnachtAufgabe5
//    {


//        static void Mathe(int a, int b)
//        {
//            int summe = a + b;
//            Console.WriteLine(summe);
//        }

//        static void Main()
//        {
//            //RNA: "AUGUUUUCUUAAAUG" =>
//            //Codons: "AUG", "UUU", "UCU", "UAA", "AUG" =>
//            //Protein: "Methionin", "Phenylalanin", "Serin"
//            //Beachten Sie, dass das Stoppcodon "UAA" die Übersetzung beendet und das letzte
//            //Methionin nicht in die Proteinsequenz übersetzt wird.
//            //Nachstehend sind die Codons und die daraus resultierenden Aminosäuren
//            //aufgeführt, die für die Übung benötigt werden:

//            //Codon Protein
//            //AUG Methionin
//            //UUU, UUC Phenylalanin
//            //UUA, UUG Leucin
//            //UCU, UCC, UCA, UCG Serin
//            //UAU, UAC Tyrosin
//            //UGU, UGC Cystein
//            //UGG Tryptophan
//            //UAA, UAG, UGA STOP

//            Console.WriteLine("RNA - Proteinen Konvertierer\n===============================================");
//            Console.WriteLine("Geben Sie bitte eine RNA sequenz ein: ");
//            string? rnaSequenz = Console.ReadLine(); //Fuer Testing. Dannach mit Console.ReadLine() ersetzen.
//            //Index               0123456789 10 11 12 13 14 15
//            if (rnaSequenz == null || rnaSequenz == "")
//            {
//                Console.WriteLine("Leere RNA Sequenz.");
//                return;
//            }

//            //Hallo => hat 5 zeichen
//            string proteine = "";

//            bool stopGefunden = false;

//            int zaehler = 0;

//            while (!stopGefunden)
//            {
//                string codon = rnaSequenz.Substring(zaehler, 3);
//                //Console.WriteLine("Codon: " + codon);
//                //Spaeter schleife mit zaehler erstellen. Jeweils um 3 erhoehen.

//                //Alternative - Patternmatching switch
//                //Kurzform von normalen switch.
//                //proteine += codon switch
//                //{
//                //    "AUG" => "Methionin ",
//                //    "UUU" or "UUC" => "Phenylalanin ",
//                //    "UUA" or "UUG" => "Leucin"
//                //};

//                switch (codon)
//                {
//                    case "AUG":
//                        proteine += "Methionin ";
//                        break;
//                    case "UUU" or "UUC":
//                        proteine += "Phenylalanin ";
//                        break;
//                    case "UUA" or "UUG":
//                        proteine += "Leucin ";
//                        break;
//                    case "UCU" or "UCC" or "UCA" or "UCG":
//                        proteine += "Serin ";
//                        break;
//                    case "UAU" or "UAC":
//                        proteine += "Tyrosin ";
//                        break;
//                    case "UGU" or "UGC":
//                        proteine += "Cystein ";
//                        break;
//                    case "UGG":
//                        proteine += "Tryptophan ";
//                        break;
//                    case "UAA" or "UAG" or "UGA":
//                        Console.WriteLine("Stop Sequenz gefunden!");
//                        stopGefunden = true;
//                        break;
//                    default:
//                        Console.WriteLine("Keine RNA Sequenz eingegeben. Achten Sie auf Ihre Eingabe bitte!");
//                        return;
//                }
//                zaehler += 3;
//                if (zaehler + 3 > rnaSequenz.Length)
//                {

//                    Console.WriteLine("Keine Stop Sequenz gefunden.");
//                    Console.WriteLine("RNA Sequenz vorbei. Programm wird terminiert.");
//                    break;
//                }
//            }




//            Console.WriteLine("Gefundene Proteinen: " + proteine);




//        }





//    }
//}
