namespace ErsterProjekt
{
    internal class IfBedingungen
    {
        static void Main()
        {

            //Übungen mit if/else if/else:
            //else if 0 - unendlich mal


            //if darf pro block nur 1 mal vorkommen


            //else darf maximal 1 mal vorkommenÜbung 1: Notensystem
            //Der Benutzer gibt eine Punktzahl(0–100) ein.
            //Das Programm soll anhand der Punktzahl eine Note ausgeben:
            //90–100 → „Sehr gut“
            //75–89 → „Gut“
            //60–74 → „Befriedigend“
            //50–59 → „Ausreichend“
            //0–49 → „Nicht bestanden“
            //Alle anderen Werte → „Ungültige Eingabe“




            //Console.Write("Bitte Punktzahl zwischen 0 und 100 eingeben: ");

            //int punkte = Convert.ToInt32(Console.ReadLine());

            //if (punkte < 0 || punkte > 100)
            //{
            //    Console.WriteLine("Ungültige Eingabe");
            //}
            //else if (punkte >= 90)
            //{
            //    Console.WriteLine("Sehr gut");
            //}
            //else if (punkte >= 75)
            //{
            //    Console.WriteLine("Gut");
            //}
            //else if (punkte >= 60)
            //{
            //    Console.WriteLine("Befriedigend");
            //}
            //else if (punkte >= 50)
            //{
            //    Console.WriteLine("Ausreichend");
            //}
            //else 
            //{
            //    Console.WriteLine("Nicht bestanden");


            //Übung 2: Altersprüfung
            //Der Benutzer gibt sein Alter ein.
            //Das Programm soll entscheiden:
            //• Unter 0 → „Ungültiges Alter“
            //• Unter 18 → „Minderjährig“
            //• 18–64 → „Erwachsen“
            //• Ab 65 → „Rentner“

            //Console.Write("Bitte Alter eingeben: ");

            //int alter = Convert.ToInt32(Console.ReadLine());

            //if (alter < 0 || alter > 130)
            //{
            //    Console.WriteLine("Ungültige Eingabe");
            //}
            //else if (alter >= 65)
            //{
            //    Console.WriteLine("Rentner");
            //}
            //else if (alter >= 18)
            //{
            //    Console.WriteLine("Erwachsen");
            //}

            //else
            //{
            //    Console.WriteLine("Minderjährig");
            //}

            //Übung 3: Temperaturbewertung
            //Der Benutzer gibt eine Temperatur in Grad Celsius ein.
            //Das Programm soll Folgendes ausgeben:
            //• Unter 0 → „Sehr kalt“
            //• 0–14 → „Kalt“
            //• 15–24 → „Angenehm“
            //• 25–34 → „Warm“
            //• Ab 35 → „Sehr heiß“

            //Console.Write("Bitte Temperatur in Grad Celsius eingeben: ");

            //double temp = Convert.ToDouble(Console.ReadLine());

            //if (temp >= 35)
            //{
            //    Console.WriteLine("Sehr heiß");
            //}
            //else if (temp >= 25)
            //{
            //    Console.WriteLine("Warm");
            //}
            //else if (temp >= 15)
            //{
            //    Console.WriteLine("Angenehm");
            //}
            //else if (temp >= 0)
            //{
            //    Console.WriteLine("Kalt");
            //}

            //else if (temp < 0)
            //{
            //    Console.WriteLine("Sehr kalt");
            //}

            //Übung 4: Benutzer Authentifizierung
            //Der Benutzer gibt sein Benutzername und Passwort ein. Das Programm soll überprüfen ob seine Zugangsdaten gültig sind.Das echte Benutzername und Passwort müssen wir davor definieren.
            //Bspw: 
            //String benutzername = bob1
            //String passwort = 1234
            //Eingabe => bob1 und 4321
            //Ausgabe: Benutzername oder Passwort falsch.


            string name = "max_mustermann";
            string passwort = "1234";


            Console.Write("Bitte den Benutzername eingeben: ");
            string eingabeName = Console.ReadLine();

            Console.Write("Bitte das Passwort eingeben: ");
            string eingabePasswort = Console.ReadLine();

            if (eingabeName == name && eingabePasswort == passwort)
            {
                Console.WriteLine("Anmeldung war erfolgreich!");
            }
            else
            {
                Console.WriteLine("Benutzername oder Passwort falsch.");
            }






        }

    }
}
