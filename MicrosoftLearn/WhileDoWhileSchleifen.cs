

namespace MicrosoftLearn
{
    internal class WhileDoWhileSchleifen
    {
        static void Main()
        {

            //ÜBUNG while/for Schleifen

            //Random random = new Random();
            //int current = 0;

            //do
            //{
            //    current = random.Next(1, 11);
            //    Console.WriteLine(current);
            //} while (current != 7);


            //Random random = new Random();
            //int current = random.Next(1, 11);

            ///*
            //do
            //{
            //    current = random.Next(1, 11);
            //    Console.WriteLine(current);
            //} while (current != 7);
            //*/

            //while (current >= 3)
            //{
            //    Console.WriteLine(current);
            //    current = random.Next(1, 11);
            //}
            //Console.WriteLine($"Last number: {current}");


            //            Random random = new Random();
            //int current = random.Next(1, 11);

            //do
            //{
            //    current = random.Next(1, 11);

            //    if (current >= 8) continue;

            //    Console.WriteLine(current);
            //} while (current != 7);






            //Random random = new Random();
            //int current = random.Next(1, 11);

            //do
            //{
            //    current = random.Next(1, 11);

            //    if (current >= 8) continue;

            //    Console.WriteLine(current);
            //} while (current != 7);

            /*
            while (current >= 3)
            {
                Console.WriteLine(current);
                current = random.Next(1, 11);
            }
            Console.WriteLine($"Last number: {current}");
            */



            //Programmierherausforderung: Schreiben von Code zum Implementieren der Spielregeln
            //Hier sind die Regeln für das Kampfspiel, das Sie in Ihrem Codeprojekt implementieren sollen:

            //Sie müssen entweder die do -while-Anweisung oder die while-Anweisung als äußere Spielschleife verwenden.
            //Der Held bzw.die Heldin und das Monster beginnen mit 10 Gesundheitspunkten.
            //Alle Angriffe haben einen Wert zwischen 1 und 10.
            //Der Held bzw.die Heldin greift zuerst an.
            //Geben Sie die Integritätsmenge, die das Monster verloren hat, und seine verbleibende Integrität aus.
            //Wenn die Integrität des Monsters größer als 0 ist, kann es den Helden angreifen.
            //Geben Sie die Integritätsmenge, die der Held verloren hat, und seine verbleibende Integrität aus.
            //Führen Sie diese Abfolge von Angriffen fort, bis entweder die Integrität des Monsters oder die des Helden null oder weniger ist.
            //Geben Sie den Sieger aus.
            //Stellen Sie sicher, dass eine leere „Program.cs“-Datei in Visual Studio Code geöffnet ist.

            //Öffnen Sie bei Bedarf Visual Studio Code, und führen Sie dann die folgenden Schritte aus, um eine „Program.cs“-Datei im Editor vorzubereiten:

            //Wählen Sie im Menü "Datei " die Option "Ordner öffnen" aus.

            //Verwenden Sie das Dialogfeld „Ordner öffnen“, um zum Ordner CsharpProjects zu navigieren und diesen dann zu öffnen.

            //Wählen Sie im Visual Studio Code EXPLORER - Bereich Program.cs aus.

            //Wählen Sie im Menü Visual Studio Code Selection die Option Alle auswählen aus, und drücken Sie dann die Entfernen-Taste.

            //Schreiben Sie Spielcode, der sämtliche Regeln implementiert.

            //Führen Sie Ihre Anwendung aus, und überprüfen Sie, ob Ihre Ausgabe die Anforderungen erfüllt.

            //Unabhängig davon, wie Sie dies tun, sollte der Code eine ähnliche Ausgabe wie diese ergeben:                                                       

            //    Output
            //Monster was damaged and lost 1 health and now has 9 health.
            //Hero was damaged and lost 1 health and now has 9 health.
            //Monster was damaged and lost 7 health and now has 2 health.
            //Hero was damaged and lost 6 health and now has 3 health.
            //Monster was damaged and lost 9 health and now has -7 health.
            //Hero wins!  

           // Meine Lösung:
            Random random = new Random();

            int heroHealth = 10;
            int monsterHealth = 10;

            while(heroHealth > 0 && monsterHealth > 0)
            {
                // Der Held greift an
                int heroAttack = random.Next(1, 11);
                monsterHealth -= heroAttack;
                Console.WriteLine($"Das Monster wurde getroffen, verlor {heroAttack} Leben und hat noch {monsterHealth} Leben.");

                // Prüfen, ob das Monster noch lebt
                if (monsterHealth <= 0)
                    break;

                // Das Monster greift an
                int monsterAttack = random.Next(1, 11);
                heroHealth -= monsterAttack;
                Console.WriteLine($"Der Held wurde getroffen, verlor {monsterAttack} Leben und hat noch {heroHealth} Leben.");

            } 

            // Der Sieger wird ausgeben
            if (heroHealth > 0)
                Console.WriteLine("Der Held hat gewonnen!");
            else
                Console.WriteLine("Das Monster hat gewonnen!");








            ////Mögliche Lösung:
            //int hero = 10;
            //int monster = 10;

            //Random dice = new Random();

            //do
            //{
            //    int roll = dice.Next(1, 11);
            //    monster -= roll;
            //    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

            //    if (monster <= 0) continue;

            //    roll = dice.Next(1, 11);
            //    hero -= roll;
            //    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

            //} while (hero > 0 && monster > 0);

            //Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");


            /*
             Codeprojekt 1: Schreiben von Code, der ganzzahlige Eingaben überprüft
Dies sind die Bedingungen, die Ihr erstes Programmierprojekt erfüllen muss:

Ihre Lösung muss entweder eine do-while- oder while-Iteration enthalten.

Vor dem Iterationsblock: Ihre Lösung muss eine Console.WriteLine()-Anweisung verwenden, um Benutzer*innen zur Eingabe eines ganzzahligen Werts zwischen 5 und 10 aufzufordern.

Innerhalb des Iterationsblocks:

Ihre Lösung muss eine Console.ReadLine()-Anweisung verwenden, um Eingaben von Benutzer*innen zu erhalten.
Ihre Lösung muss prüfen, ob die Eingabe eine gültige Darstellung einer ganzen Zahl ist.
Wenn der ganzzahlige Wert nicht zwischen 5 und 10 liegt, muss Ihr Code den Benutzer mithilfe einer Console.WriteLine()-Anweisung auffordern, einen ganzzahligen Wert zwischen 5 und 10 einzugeben.
In der Lösung muss sichergestellt werden, dass der ganzzahlige Wert zwischen 5 und 10 liegt, bevor die Iteration beendet wird.
Unter (nach) dem Iterationscodeblock: Ihre Lösung muss Benutzer*innen mithilfe einer Console.WriteLine()-Anweisung darüber informieren, dass ihr Eingabewert akzeptiert wurde.

Stellen Sie sicher, dass eine leere „Program.cs“-Datei in Visual Studio Code geöffnet ist.

Öffnen Sie bei Bedarf Visual Studio Code, und führen Sie dann die folgenden Schritte aus, um eine „Program.cs“-Datei im Editor vorzubereiten:

Klicken Sie im Menü Datei auf Ordner öffnen.

Verwenden Sie das Dialogfeld „Ordner öffnen“, um zum Ordner CsharpProjects zu navigieren und diesen dann zu öffnen.

Wählen Sie im EXPLORER-Bereich von Visual Studio Code die Datei Program.cs aus.

Wählen Sie im Visual Studio Code-Menü Auswahl die Option Alle auswählen aus, und drücken Sie dann die ENTF-Taste.

Schreiben Sie den Code, der die einzelnen Bedingungen für Codeprojekt 1 implementiert.

Führen Sie Ihre Anwendung aus, und überprüfen Sie, ob Ihr Code die Benutzereingabe wie vorgesehen überprüft.

Wenn Sie beispielsweise Ihre Anwendung ausführen, sollte sie Eingabewerte wie „zwei“ und „2“ ablehnen, aber den Eingabewert „7“ akzeptieren.

Für das oben beschriebene Beispiel sollte die Konsolenausgabe wie folgt aussehen:

Output
Enter an integer value between 5 and 10
two
Sorry, you entered an invalid number, please try again
2
You entered 2. Please enter a number between 5 and 10.
7
Your input value (7) has been accepted.             */


            //Meine Lösung:
            //int number = 0;
            //bool valid = false;

            //Console.WriteLine("Bitte gib eine ganze Zahl zwischen 5 und 10 ein und drücke Enter:");

            //while (!valid)
            //{
            //    string input = Console.ReadLine();

            //    if (int.TryParse(input, out number))
            //    {
            //        if (number >= 5 && number <= 10)
            //        {
            //            valid = true;
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Du hast die {number} eingegeben. Bitte gib eine Zahl zwischen 5 und 10 ein.");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ungültige Eingabe. Bitte versuche es erneut.");
            //    }
            //}

            //Console.WriteLine($"Deine Eingabe ({number}) wurde akzeptiert.");

            //Lösung:
            //string? readResult;
            //string valueEntered = "";
            //int numValue = 0;
            //bool validNumber = false;

            //Console.WriteLine("Enter an integer value between 5 and 10");

            //do
            //{
            //    readResult = Console.ReadLine();
            //    if (readResult != null)
            //    {
            //        valueEntered = readResult;
            //    }

            //    validNumber = int.TryParse(valueEntered, out numValue);

            //    if (validNumber == true)
            //    {
            //        if (numValue <= 5 || numValue >= 10)
            //        {
            //            validNumber = false;
            //            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry, you entered an invalid number, please try again");
            //    }
            //} while (validNumber == false);

            //Console.WriteLine($"Your input value ({numValue}) has been accepted.");

            //readResult = Console.ReadLine();


            /*
             Codeprojekt 2: Schreiben von Code, der Zeichenfolgeeingaben überprüft
            Dies sind die Bedingungen, die Ihr zweites Programmierungsprojekt erfüllen muss:

            Ihre Lösung muss entweder eine do-while- oder while-Iteration enthalten.

            Vor dem Iterationsblock: Ihre Lösung muss Benutzer*innen mithilfe einer Console.WriteLine()-Anweisung zur Eingabe eines von drei Rollennamen auffordern: Administrator, Manager oder Benutzer.

            Innerhalb des Iterationsblocks:

            Ihre Lösung muss eine Console.ReadLine()-Anweisung verwenden, um Eingaben von Benutzer*innen zu erhalten.
            Ihre Lösung muss sicherstellen, dass der eingegebene Wert einer der drei Rollenoptionen entspricht.
            Ihre Lösung sollte die Trim()-Methode für den Eingabewert verwenden, um führende und nachstehende Leerzeichen zu ignorieren.
            Ihre Lösung sollte die ToLower()-Methode für den Eingabewert verwenden, um die Groß- und Kleinschreibung zu ignorieren.
            Wenn der eingegebene Wert mit keiner der Rollenoptionen übereinstimmt, muss im Code eine Console.WriteLine()-Anweisung verwendet werden, mit der Benutzer zur Eingabe eines gültigen Werts aufgefordert werden.
            Unter (nach) dem Iterationscodeblock: Ihre Lösung muss Benutzer*innen mithilfe einer Console.WriteLine()-Anweisung darüber informieren, dass ihr Eingabewert akzeptiert wurde.

            Auskommentieren des gesamten Codes im Visual Studio Code-Editor-Bereich

            Auswählen aller Codezeilen im Code-Editor
            Wählen Sie im Menü Bearbeiten die Option Blockkommentar umschalten aus.
            Schreiben Sie den Code, der die einzelnen Bedingungen für Codeprojekt 2 implementiert.

            Führen Sie Ihre Anwendung aus, und überprüfen Sie, ob Ihr Code die Benutzereingabe wie vorgesehen überprüft.

            Wenn Sie Ihre Anwendung ausführen, sollte sie beispielsweise Eingabewerte wie „Admin“ ablehnen, aber den Eingabewert „Administrator“ akzeptieren.

            Die Konsolenausgabe für dieses Beispiel sollte wie folgt aussehen:

            Output
            Enter your role name (Administrator, Manager, or User)
            Admin
            The role name that you entered, "Admin" is not valid. Enter your role name (Administrator, Manager, or User)
               Administrator
            Your input value (Administrator) has been accepted.*/


            //Meine Lösung:
            //string role = "";
            //bool valid = false;

            //Console.WriteLine("Gib deine bezeichnung ein (Administrator, Manager oder Benutzer)");

            //while (!valid)
            //{
            //    role = Console.ReadLine().Trim().ToLower();

            //    if (role == "administrator" || role == "manager" || role == "user")
            //    {
            //        valid = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Die eingegebene Bezeichnung \"{role}\" ist ungültig. Bitte gib Administrator, Manager oder Benutzer ein.");
            //    }
            //}

            //Console.WriteLine($"Deine Eingabe ({role}) wurde akzeptiert.");


            //Musterlösung:
            //string? readResult;
            //string roleName = "";
            //bool validEntry = false;

            //do
            //{
            //    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
            //    readResult = Console.ReadLine();
            //    if (readResult != null)
            //    {
            //        roleName = readResult.Trim();
            //    }

            //    if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user")
            //    {
            //        validEntry = true;
            //    }
            //    else
            //    {
            //        Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
            //    }

            //} while (validEntry == false);

            //Console.WriteLine($"Your input value ({roleName}) has been accepted.");
            //readResult = Console.ReadLine();









        }



    }
}
