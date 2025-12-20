using System;



namespace WhileDo_DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// WHILE DO SCHLEIFE
            //int summe = 0;
            //int zaehler = 1;
            //string resultat = "0";

            //while (zaehler <= 50)
            //{
            //    summe += zaehler;
            //    resultat += " + " + zaehler;
            //    zaehler++;
            //}

            //Console.WriteLine(resultat + " = " + summe);

            //int verdoppelteSumme = summe * 2;
            //Console.WriteLine("Summe * 2 = " + verdoppelteSumme);



            //// DO WHILE SCHLEIFE
            //int summe2 = 0;
            //int zaehler2 = 1;
            //string resultat2 = "0";

            //do
            //{
            //    summe2 += zaehler2;
            //    resultat2 += " + " + zaehler2;
            //    zaehler2++;
            //}
            //while (zaehler2 <= 50);

            //Console.WriteLine(resultat2 + " = " + summe2);

            //int verdoppelteSumme2 = summe2 * 2;
            //Console.WriteLine("Summe * 2 = " + verdoppelteSumme2);



            /*Übung 1:
                Einmal while und einmal do-while! Am ende beschreiben: Was war besser? Wieso?
                Wir moechten ein kleines program schreiben wo der benutzer
                2 Zahlen eingeben soll. Wir multiplizieren diese 2 Zahlen dann miteinander.
                Dann geben wir das Resultat aus.
            
                Nachdem wir das Resultat ausgegeben haben, sollen wir den benutzer nochmal auffordern 2 Zahlen einzugeben.
                Dies soll so lange erfolgen bis der Benutzer das wort quit eingibt.
                
                Hinweis: Wir haben somit entweder eine Zahl oder einen String.
                Dies bedeutet erstmal ueberpruefen mit tryParse ob die konvertierung erfolgreich war.
                Wenn nicht, dann ob der String = quit ist. Ansonsten verstehen die eingabe nicht.
                Und die schleife startet neu.

                string eingabe = Console.ReadLine();
                false          int.TryParse(eingabe,out = 0)
                
                Beispiel:
                    Console:
                        Wilkommen in unsere kleine Konsolen Applikation!
                        Geben Sie bitte eine Zahl ein die wir mit eine 2te Zahl multiplizieren werden:
                        User:       3
                        Danke! Geben Sie mir jetzt bitte die 2te Zahl:
                        User:       5
                        Super! Das resultat von 3 * 5 = 15!
                        ---Schleife durchgang 1 fertig---
                        Geben Sie bitte eine Zahl ein die wir mit eine 2te Zahl multiplizieren werden:
                        User:       asdfasdf
                        Uppsala! Das ist keine Zahl und wir stoppen nur wenn Sie 'quit' eingeben!
                        ---Schleife durchgang 2 fertig---
                        Geben Sie bitte eine Zahl ein die wir mit eine 2te Zahl multiplizieren werden:
                        User:       quit
                        Bis zum naechsten mal!
                        *Programm Vorbei*
            */


            Console.WriteLine("Wilkommen in unserer kleinen Konsolen-Applikation!");

            while (true)
            {
                Console.WriteLine("Geben Sie bitte eine Zahl ein, die wir mit einer zweiten Zahl multiplizieren werden (oder 'quit'):");
                string? eingabe1 = Console.ReadLine();

                if (eingabe1 == "quit")
                    break;

                if (!int.TryParse(eingabe1, out int zahl1))
                {
                    Console.WriteLine("Ungültige Eingabe.");
                    continue;
                }

                Console.WriteLine("Bitte eine zweite Zahl eingeben (oder quit):");
                string? eingabe2 = Console.ReadLine();

                if (eingabe2 == "quit")
                    break;

                if (!int.TryParse(eingabe2, out int zahl2))
                {
                    Console.WriteLine("Ungültige Eingabe.");
                    continue;
                }

                int ergebnis = zahl1 * zahl2;
                Console.WriteLine("Ergebnis: " + ergebnis);
                Console.WriteLine();
            }

            Console.WriteLine("Programm beendet.");



            do
            {
                Console.WriteLine("Wilkommen in unserer kleinen Konsolen-Applikation!");
                Console.WriteLine("Geben Sie bitte eine Zahl ein, die wir mit einer zweiten Zahl multiplizieren werden (oder 'quit'):");
                string eingabe1 = Console.ReadLine();

                if (eingabe1 == "quit")
                    break;

                if (!int.TryParse(eingabe1, out int zahl1))
                {
                    Console.WriteLine("Ungültige Eingabe.");
                    continue;
                }

                Console.WriteLine("Bitte eine zweite Zahl eingeben (oder quit):");
                string eingabe2 = Console.ReadLine();

                if (eingabe2 == "quit")
                    break;

                if (!int.TryParse(eingabe2, out int zahl2))
                {
                    Console.WriteLine("Ungültige Eingabe.");
                    continue;
                }

                int ergebnis = zahl1 * zahl2;
                Console.WriteLine("Ergebnis: " + ergebnis);
                Console.WriteLine();
            } while (true);

            Console.WriteLine("Programm beendet.");
        }
    }
}