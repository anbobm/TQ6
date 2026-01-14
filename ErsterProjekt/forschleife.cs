/*using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ErsterProjekt
{
    internal class forschleife
    {
    static void Main()
        {*/





            /* for (int i = 0; i < 10; i++)
             {
                 Console.WriteLine(i);
                 if (i == 7) break;
             }*/

            /* for (int i = 0; i< 10; i += 3)
              {
                  Console.WriteLine(i);
              }*/
            /* string[] names = { "alex", " eddie", " david", "micael" };*/
            /*

                  string[] fraudulentOrderIDs = new string[3];
                  fraudulentOrderIDs[0] = "A123";
                  fraudulentOrderIDs[1] = "B456";
                  fraudulentOrderIDs[2] = "C789";
                  *//*   fraudulentOrderIDs[3] = "D000";*//*
            string[] fraudulentOrderIDs = ["A123", "B456", "C789"];
            Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
            Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");
            fraudulentOrderIDs[0] = "F000";

            Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");*/

            /*
                        string[] names = { "Rowena", "Robin", "Bao" };
                        foreach (string name in names)
                        {
                            Console.WriteLine(name);
                        }*/

            /* int[] inventory = { 200, 450, 700, 175, 250 };
             int sum = 0;
             int bin = 0;
             foreach (int items in inventory)
             {
                 sum += items;
                 bin++;
                 Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
                 *//*  Console.WriteLine($"We have {sum} items in inventory.");*//*
             }

             Console.WriteLine($"We have {sum} items in inventory.");*/
            /*     string []name = { "B123", "C234", "A345" , "C15", "B177", "G3003","C235", "B179"};
                 foreach (string n in name)
                 {
                     if (n.StartsWith("B")) 
                     {
                         Console.WriteLine($"{n}the name starts with 'B'!");
                     }
                 }*/


            /*
                        Console.WriteLine("RNA - Proteinen Konvertierer\n===============================================");
                        Console.WriteLine("Geben Sie bitte eine RNA sequenz ein: ");
                        string? rnaSequenz = Console.ReadLine();

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

                        Console.WriteLine("Gefundene Proteinen: " + proteine);*/
            /*
                        Console.WriteLine("bitte ein zahl eingeben:");
                        int number = int.Parse(Console.ReadLine());
                        if (number % 2 == 0)
                        {
                            Console.WriteLine($"{number} die zahl ist gerade");



                        }
                        else
                        {
                            Console.WriteLine($"{number} die zahl ist ungerade");
                        }*/

            /*     string[] pallets = ["B14", "A11", "B12", "A13"];
                 Console.WriteLine("Sorted...");
                 Array.Sort(pallets);
                 foreach (string pallet in pallets)
                 {
                     Console.WriteLine($"-- {pallet}");
                 }*/
            /*
                        Console.WriteLine("");
                        Console.WriteLine("Reversed...");
                        Array.Reverse(pallets);
                        foreach (var pallet in pallets)
                        {
                            Console.WriteLine($"-- {pallet}");
                        }*/
            /*

                        string[] pallets = ["B14", "A11", "B12", "A13"];
                        Console.WriteLine("");

                        Console.WriteLine($"Before: {pallets[0].ToLower()}");
                        Array.Clear(pallets, 0,2);
                       *//* Console.WriteLine($"After: {pallets[0].ToLower()}");*/ /*funktioniert nicht weil keine objekt gibts auf Null*//*

                        Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
                        foreach (var pallet in pallets)
                        {
                            Console.WriteLine($"-- {pallet}");
                        }
                        Console.WriteLine("");
                        Array.Resize(ref pallets, 6);
                        Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

                        pallets[4] = "C01";
                        pallets[5] = "C02";

                        foreach (var pallet in pallets)
                        {
                            Console.WriteLine($"-- {pallet}");
                        }
                        Console.WriteLine("");
                        Array.Resize(ref pallets, 3);
                        Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

                        foreach (var pallet in pallets)
                        {
                            Console.WriteLine($"-- {pallet}");
                        }*/

            /*
                        string value = "abc123";
                        char[] valueArray = value.ToCharArray();
                        Array.Reverse(valueArray);
                       string result = new string(valueArray);
                        Console.WriteLine(result);*/
            /*
                        string value = "abc123";
                        char[] valueArray = value.ToCharArray();
                        Array.Reverse(valueArray);
                        // string result = new string(valueArray);
                        string result = String.Join(",", valueArray);
                        Console.WriteLine(result);



                        string[] items = result.Split(',');
                        foreach (string item in items)
                        {
                            Console.WriteLine(item);
                        }*/
            /*
                        string pangram = "The quick brown fox jumps over the lazy dog";

                        string[] items = pangram.Split(' ');
                        List<string> reversedWords = new List<string>();
                        foreach (string item in items)
                        {

                            char[] letters = item.ToCharArray();
                            Array.Reverse(letters);
                            string reversed = new string(letters);
                            reversedWords.Add(reversed);



                        }
                        string result = string.Join(" ", reversedWords);
                        Console.WriteLine(result);*/








































































































































/*


        }

    }
}*/
