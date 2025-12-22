using System.ComponentModel;

namespace ErsterProjekt
{
    internal class BedingungUebungUndSchleifen
    {
        static void Main()
        {

            //Random zufallszahlGenerator = new Random();

            //int zufallsZahl = zufallszahlGenerator.Next();

            //Console.WriteLine(zufallsZahl);



            ////Übung von microsoft.learn

            //string permission = "Admin|Manager";
            //int level = 55;

            //string nachricht = "";

            //if (permission.Contains("Admin") && level > 55)
            //    nachricht = "Welcome, Super Admin user.";
            //else if (permission.Contains("Admin"))
            //    nachricht = "Welcome, Admin user.";
            //else if (permission.Contains("Manager") && level >= 20)
            //    nachricht = "Contact an Admin for access.";
            //else
            //    nachricht = "You do not have sufficient privileges";

            //Console.WriteLine(nachricht);



            //Schleifen:

            //int zahl = 1;

            //while (zahl < 100)
            //{
            //    zahl += 10;

            //    if (zahl > 30 && zahl < 50)
            //    {
            //        Console.WriteLine("Diese Zahlen moegen wir nicht!");
            //        continue;
            //    }

            //    Console.WriteLine("Die Aktuelle Zahl ist: " + zahl);
            //}
            //Console.WriteLine("Schleife Vorbei!");






            //Von Nico gepullt:

            //string benutzername = "Bob123";

            //Console.WriteLine("Geben Sie bitte Ihr neues Passwort ein:");
            //string? passwort = Console.ReadLine();

            //while (passwort.Length < 10)
            //{
            //    Console.WriteLine("Versuchen Sie es bitte nochmals. Das Passwort muss mind. 10 Zeichen enthalten.");
            //    passwort = Console.ReadLine();
            //}

            //Console.WriteLine($"Dein Konto wurde erstellt. " +
            //    $"Sie haben folgende Zugangsdaten definiert:" +
            //    $"\nBenutzername: {benutzername}\n" +
            //    $"Passwort: {passwort}");


            //int zahl = 1;

            //while (zahl < 100)
            //{
            //    Console.WriteLine("Die Aktuelle Zahl ist: " + zahl);

            //    if (Console.ReadLine() == "quit")
            //    {
            //        Console.WriteLine("Die Schleife wird terminiert!");
            //        break;
            //    }
            //}

            //int zahl = 1;

            //while (zahl < 100)
            //{
            //    zahl += 10;

            //    if (zahl > 30 && zahl < 50)
            //    {
            //        Console.WriteLine("Diese Zahlen moegen wir nicht!");
            //        continue;
            //    }

            //    Console.WriteLine("Die Aktuelle Zahl ist: " + zahl);
            //}
            //Console.WriteLine("Schleife Vorbei!");

            //HA:
            //Es soll einen PAP erstellt werden und dannach ein programm geschrieben.
            //Ein Benutzer soll einen Konto erstellen.
            //Es gelten folgende regeln:
            //1.Das Benutzername muss mind. 5 Zeichen lang sein.
            //2.Das Passwort muss mind. 10 Zeichen lang sein und mit das buchstabe 'A' beginnen.
            //Sobald eine von diese Faelle nicht stimment, dann soll der Benutzer erneut die Daten eingeben.
            //Hinweis 1 schleife fuer Benutzername 1 schleife fuer passwort


            //string username;
            //string password;


            //Console.WriteLine("Bitte Benutzername mit mindestens 5 Zeichen erstellen:");
            //username = Console.ReadLine();

            //while (username.Length < 5)
            //{
            //    Console.WriteLine("Name zu kurz, bitte mindestens 5 Zeichen eingeben.");

            //    username = Console.ReadLine();
            //}


            //Console.WriteLine("Bitte Passwort mit mindestens 10 Zeichen erstellen und das erste Zeichen muss ein'A' sein:");

            //password = Console.ReadLine();

            //while (password.Length < 10 || !password.StartsWith("A"))
            //{
            //    Console.WriteLine("Passwort ungültig, bitte mindestens 10 Zeichen eingeben und das erste Zeichen muss ein 'A' sein.");

            //    password = Console.ReadLine();
            //}

            //Console.WriteLine("\nKonto erfolgreich erstellt!");



            //Aufgabe die summe aller werte von 1 bis <= 50 brechnen.
            //Dannach soll die gesamtsumme * 2 multipliziert werden
            //Und auf die Konsole ausgegeben werden.
            //Bitte einmal mit while und einmal mit do-while loesen.
            //Super Herausforderung. Die Ausgabe soll wie folgt aussehen:
            //0 + 1 + 2 + 3 = 6 Hinweis: resultat string verwenden!

            //int summe = 0;

            //int zaehler = 1;

            //while (zaehler <= 30)
            //{
            //    //0 + 1 + 2 + 3 + 4
            //}

            //While-Schleife
            //int summe = 0;

            //int zaehler = 1;

            //string resultat = "0";

            //while (zaehler <= 50)
            //{
            //    summe += zaehler;
            //    resultat += " + " + zaehler;
            //    zaehler++;
            //}

            //Console.WriteLine($"{resultat} und das Ganze dann multipliziert mit 2 ergibt = {summe * 2}");

            //Do-While-Schleife
            //int summe = 0;

            //int zaehler = 1;

            //string resultat = "0";

            //do
            //{
            //    summe += zaehler;




            //von Hamnnes
            //int summe = 0;
            //int zaehler = 1;
            //string resultat = "0";

            //do
            //{
            //    summe += zaehler;
            //    resultat += " + " + zaehler;
            //    zaehler++;
            //}
            //while (zaehler <= 50);

            //int ergebnis = summe * 2;

            //Console.WriteLine(resultat + " = " + ergebnis);


            //Tip von Ron
            //while (bedingung)
            //{
            //    // auszuführender Code
            //}



            //do
            //{
            //    // auszuführender Code
            //} while (bedingung)






            /*Uebung 1:
 * Einmal while und einmal do-while! Am ende beschreiben: Was war besser? Wieso?
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


Bspw:
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



            

            //Aufgabe mit While-Schleife
            
            //Console.WriteLine("Willkommen in unserer kleinen Konsolen-Applikation, in der wir 2 Zahlen multiplizieren!");

            //bool programm_laeuft = true;

            //while (programm_laeuft) 
            //{ 
              
            //    Console.WriteLine("Wenn das Programm abgebrochen werden soll, bitte quit eingeben! Bitte nun die erste Zahl eingeben:");

            //    string eingabe1 = Console.ReadLine();

            //    if (!int.TryParse(eingabe1,out int zahl1))

            //    { 

            //        if (eingabe1.ToLower() == "quit") 
            //        {
            //            Console.WriteLine("Bis zum nächsten Mal !");
            //            Console.WriteLine("Programm vorbei !");

            //            programm_laeuft = false;
            //        }
            
            //        else
            //        {
            //            Console.WriteLine("Uppsala! Das ist keine Zahl und wir stoppen nur wenn Sie 'quit' eingeben!");
            //        }

            //        continue;
            //    }

            //    Console.WriteLine("Bitte nun die zweite Zahl eingeben:");

            //    string eingabe2 = Console.ReadLine();

            //    if (!int.TryParse(eingabe2, out int zahl2))
            //    {
            //        if (eingabe2.ToLower() == "quit")
            //        {
            //            Console.WriteLine("Bis zum nächsten Mal!");
            //            Console.WriteLine("Programm vorbei!");

            //            programm_laeuft = false; 
            //        }
            //        else
            //        {
            //            Console.WriteLine("Uppsala! Das ist keine gültige Zahl!");
            //        }
            //        continue; 
            //    }

            //    int resultat = zahl1 * zahl2;
            //    Console.WriteLine($"Das Ergebnis von {zahl1} x {zahl2} = {resultat}!");
            //}





            //Aufgabe mit Do-While-Schleife

            Console.WriteLine("Willkommen in unserer kleinen Konsolen-Applikation, in der wir 2 Zahlen multiplizieren!");

            bool programm_laeuft = true;

            do
            {

                Console.WriteLine("Wenn das Programm abgebrochen werden soll, bitte quit eingeben! Bitte nun die erste Zahl eingeben:");

                string eingabe1 = Console.ReadLine();

                if (!int.TryParse(eingabe1, out int zahl1))

                {

                    if (eingabe1.ToLower() == "quit")
                    {
                        Console.WriteLine("Bis zum nächsten Mal !");
                        Console.WriteLine("Programm vorbei !");

                        programm_laeuft = false;
                    }

                    else
                    {
                        Console.WriteLine("Uppsala! Das ist keine Zahl und wir stoppen nur wenn Sie 'quit' eingeben!");
                    }

                    continue;
                }

                Console.WriteLine("Bitte nun die zweite Zahl eingeben:");

                string eingabe2 = Console.ReadLine();

                if (!int.TryParse(eingabe2, out int zahl2))
                {
                    if (eingabe2.ToLower() == "quit")
                    {
                        Console.WriteLine("Bis zum nächsten Mal!");
                        Console.WriteLine("Programm vorbei!");

                        programm_laeuft = false;
                    }
                    else
                    {
                        Console.WriteLine("Uppsala! Das ist keine gültige Zahl!");
                    }
                    continue;
                }

                int resultat = zahl1 * zahl2;
                Console.WriteLine($"Das Ergebnis von {zahl1} x {zahl2} = {resultat}!");
            } while (programm_laeuft);

            //zusammenfassung des Programms: Ich setze eine bool-Variable programm_laeuft und gehe
            //in die Schlefe. hier überprüfe ich ob die eingegeben Werte Zahlen sind, wenn nein wird geprüft ob die Eingabe
            //quit war(umgewandelt auf Kleinschreibung,falls es jemand groß schreibt), dann wird das programm beendet andernfalls
            //ist die Eingabe ungültig und die Schleife startet wieder.Wenn ja werden eingabe 1 und eingabe 2
            //als int in zahl1 und zahl2 gespeichert und am Schluss multipliziert und ausgegeben!

            //Was war besser? Mit While-Schleife oder mit Do-While-Schleife?
            //Bei der Ausgabe habe ich keinen Unterschied bemerkt,beides gleich, aber ich denke da die Schleife ja sowieso mind.
            //einmal ausgeführt wird, ist der Code mit einer Do-While Variante sauberer und übersichtlicher!

        }
    }
}
    
      
