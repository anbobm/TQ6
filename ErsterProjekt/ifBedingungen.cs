

using System;

namespace ErsterProjekt
{
    internal class ifBedingungen
    {
        static void Main()
        {
            /*
                        Random zufallszahlGenerator = new Random();

                        int zufallsZahl = zufallszahlGenerator.Next();

                        Console.WriteLine(zufallsZahl);*/
            /*
                        string myName = "Luiz";*/
            /*
                        if (myName == "Luiz")
                        {
                            Console.WriteLine("Hallo Luiz!");
                        }
                        else
                        {
                            Console.WriteLine("Du bist nicht Luiz.");
                        }*/




            /*

                        Console.WriteLine("a" == "a");
                        Console.WriteLine("a" == "A");
                        Console.WriteLine(1 == 2);

                        string myValue = "a";
                        Console.WriteLine(myValue == "a");*/
            /*
                        string value1 = " a";
                        string value2 = "A ";
                        Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());*/
            /*
                        Console.WriteLine("a" != "a");
                        Console.WriteLine("a" != "A");
                        Console.WriteLine(1 != 2);

                        string myValue = "a";
                        Console.WriteLine(myValue != "a");*/
            /*
                        Console.WriteLine(1 > 2);
                        Console.WriteLine(1 < 2);
                        Console.WriteLine(1 >= 1);
                        Console.WriteLine(1 <= 1);*/

            /*
                        string pangram = "The quick brown fox jumps over the lazy dog.";
                        Console.WriteLine(pangram.Contains("fox")==false);
                        Console.WriteLine(!pangram.Contains("cow"));*/

            /*    int a = 7;
                int b = 6;
                Console.WriteLine(a != b); // output: True
                string s1 = "Hello";
                string s2 = "Hello";
                Console.WriteLine(s1 != s2); // output: False*/

            /*
                        int saleAmount = 1001;
                        int discount = saleAmount > 1000 ? 100 : 50; *//*Das ist der bedingte Operator(auch ternary operator .Er ist eine Kurzform von if/else.*//*
                        Console.WriteLine($"Discount: {discount}"); *//*Wenn saleAmount > 1000 dann nimm 100 sonst nimm 50.*/

            /* Random coin = new Random();
             int flip = coin.Next(0, 2);
             Console.WriteLine((flip == 0) ? "head" : "teils");


            /*  Console.WriteLine("Geben Sie bitte eine Punktzahl (0-100) ein.");
              int punktzahl;
              bool erfolgreich = int.TryParse(Console.ReadLine(), out punktzahl);
              if (!erfolgreich)
              {
                  Console.WriteLine("Keine Zahl eingegeben.");
                  return;
              }
              //Pattern Matching Switch
             string ausgabe = punktzahl switch
             {
                 < 0 or > 100 => "Ungültige Eingabe",
                 <= 49 => "Nicht bestanden",
                 <= 59 => "Ausreichend",
                 <= 74 => "Befriedigend",
                 <= 89 => "Gut",
                 _ => "Sehr gut"
             };
             Console.WriteLine(ausgabe);
 */
            /*string permission = "Admin|Manager";
            int level = 55;*/
/*
            Console.WriteLine("bitte geben sie permission ein:");
            string permission = Console.ReadLine();

            Console.WriteLine("bitte gib die level ein:");
            int level;
            bool erfolgreich = int.TryParse(Console.ReadLine(), out level);
            if (!erfolgreich)
            {
                Console.WriteLine("Keine level eingegeben.");
                return;
            }
            
            
            if (permission == "Admin" && level == 55)
            {
                Console.WriteLine("Welcome, Super Admin user.");
            }

           

            else if (permission == "Manager")
                if (level>=20)
                {
                    Console.WriteLine("Contact an Admin for access.");
                }
                else
                {

                    Console.WriteLine("You do not have sufficient privileges.");

                }

            else
            {
                Console.WriteLine("You do not have sufficient privileges.");
            }*/


/*
            string permission = "Admin|Manager";
            int level = 55;

            string nachricht = "";

            if (permission.Contains("Admin") && level > 55)
                nachricht = "Welcome, Super Admin user.";
            else if (permission.Contains("Admin"))
                nachricht = "Welcome, Admin user.";
            else if (permission.Contains("Manager") && level >= 20)
                nachricht = "Contact an Admin for access.";
            else
                nachricht = "You do not have sufficient privileges";

            Console.WriteLine(nachricht);*/







        }



    }
}
