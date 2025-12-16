//namespace ErsterProjekt
//{
//    internal class Program
//    {
//        static void Main()
//        {



            //Aufgabe:

            //Schreib ein Programm, welches den Nutzer nach zwei Zahlen fragt und anschließend
            //die Summe, die Differenz, das Produkt und den Quotienten der zwei Zahlen ausgibt.

            //Console.WriteLine("Bitte die erste Zahl eingeben und Enter drücken:");
            //int zahl1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Bitte die zweite Zahl eingeben und Enter drücken:");
            //int zahl2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Die Summe von {zahl1} und {zahl2} ist {zahl1 + zahl2}");
            //Console.WriteLine($"Die Differenz von {zahl1} und {zahl2} ist {zahl1 - zahl2}");
            //Console.WriteLine($"Das Produkt von {zahl1} und {zahl2} ist {zahl1 * zahl2}");
            //Console.WriteLine($"Der Quotient von {zahl1} und {zahl2} ist {(double)zahl1 / zahl2}");


            //Aufgabe:Temperatur Umwandlung

            //int fahrenheit = 82;

            //decimal celsius = (fahrenheit - 32m) * 5m / 9m;

            //Console.WriteLine($"Die Temperatur ist {celsius} Grad Celsius.");


            //int celsius = 28;

            //decimal fahrenheit = celsius * 9m / 5m + 32;

            //Console.WriteLine($"Die Temperatur ist {fahrenheit} Grad Fahrenheit.");



            //Console.Write("Bitte Temperatur in Celsius eingeben und Enter drücken: ");

            //decimal celsius = Convert.ToDecimal(Console.ReadLine());

            //decimal fahrenheit = celsius * 9m / 5m + 32m;

            //Console.WriteLine($"Die Temperatur ist {fahrenheit} Grad Fahrenheit.");



            //Aufgabe: Hypotenuse berechnen

            //Console.Write("Bitte Größe der Kathete a in cm eingeben und Enter drücken: ");

            //double a = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Bitte Größe der Kathete b in cm eingeben und Enter drücken: ");

            //double b = Convert.ToDouble(Console.ReadLine());

            //double c = Math.Sqrt(a * a + b * b);

            //Console.WriteLine($"Die Hypotenuse ist {c} cm");


            //Aufgabe:
            //Der Nutzer soll drei ganze Zahlen(Punkte) eingeben, z.B. 1, 20 und 17.
            //Daraus soll die Durchschnittspunktzahl berechnet werden und in der Form 
            //"DerDurschnitt von 1, 21 und 17 ist 13" ausgegeben werden.

            //Anschließend soll mit `Console.WriteLine($"Bestanden: {bestanden}");` ausgegeben werden:
            //"Bestanden: True", falls die Durchschnittspunkte mindestens 50 sind, ansonsten
            //"Bestanden: False".Definiere dazu eine boolesche Variable `bestanden`, die den entsprechenden
            //Wahrheitswert enthält.

            //Zusatz: der Durchschnitt soll auf 2 Nachkommastellen genau angegeben werden. 
            //(https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings)

            //Console.Write("Bitte die erste Punktzahl eingeben: ");
            //int punkte1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Bitte die zweite Punktzahl eingeben: ");
            //int punkte2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Bitte die dritte Punktzahl eingeben: ");
            //int punkte3 = Convert.ToInt32(Console.ReadLine());

            //double durchschnitt = (punkte1 + punkte2 + punkte3) / 3.0;
            //Console.WriteLine($"Der Punkte-Durchschnitt ist: {durchschnitt :F2}");

            //bool bestanden = durchschnitt >= 50;

            //Console.WriteLine(!bestanden ? $"Prüfung geschafft? {bestanden}"
            //                  : $"Prüfung geschafft? {bestanden}");


            // Aufgabe mit if/else

            //Console.WriteLine("Erste Zahl?");
            //int erste = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Zweite Zahl?");
            //int zweite = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Dritte Zahl?");
            //int dritte = Convert.ToInt32(Console.ReadLine());

            //double durchschnitt = (erste + zweite + dritte) / 3.0;
            //Console.WriteLine($"Der Durchschnitt von {erste}, {zweite} und {dritte} ist {durchschnitt:F2}");

            //if (durchschnitt >= 50)
            //{
            //    Console.WriteLine("Du hast bestanden!");
            //}
            //else
            //{
            //    Console.WriteLine("Du hast nicht bestanden!");
            //}


            //Aufgabe:
            //Schreibe ein Programm zum Üben von hexadezimalen Ziffern.
            //Nach dem Starten wird eine Zufallszahl zwischen 10(hexadezimal A) und 15(hexadezimal F) 
            //ausgewählt(siehe letzte Übung, Random.Next(...)).Diese wird dann in hexadezimaler Form 
            //ausgegeben(Formatspezifizierer X).Anschließend soll der Nutzer die gleiche Zahl in dezimaler 
            //Form eingeben.Hat der Nutzer die hexadezimale Ziffer richtig in ihre dezimale Form übersetzt, 
            //soll "Richtig!", ansonsten "Falsch!" ausgegeben werden.


            //(Optional: Nützlicher ist dieses Programm, wenn es nach der letzten Ausgabe direkt wieder von
            //vorn beginnt und eine neue Zufallszahl wählt. Das würde man mit einer Schleife erreichen, 
            //die ihr erst diese Woche kennenlernt. Wenn ihr die entsprechenden Anweisungen in einen
            //solchen Block schreibt:


            //Random zufall = new Random();

            //// Hier wird eine Zufallszahl zwischen 10 und 15 generiert!
            //int zahl = zufall.Next(10, 16);

            //// Ausgabe in Hexadezimal!
            //Console.WriteLine("Hexadezimale Zahl: " + zahl.ToString("X"));

            //Console.Write("Gib die dezimale Zahl dazu ein und drücke Enter: ");
            //int eingabe = Convert.ToInt32(Console.ReadLine());

            //if (eingabe == zahl)
            //{
            //    Console.WriteLine("Die Antwort ist richtig!");
            //}
            //else
            //{
            //    Console.WriteLine("Die Antwort ist falsch!");











//        }
//    }
//}
