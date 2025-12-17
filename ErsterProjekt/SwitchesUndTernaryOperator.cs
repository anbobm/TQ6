
/*
namespace ErsterProjekt
{
    class SwitchesUndTernaryOperator
    {
     static void Main()
        {*/

            //Switches sind fuer Fallunterscheidungen
            //Einen Switch bezieht sich auf ein Konkreten Wert.

            //Console.WriteLine("Geben Sie bitte ein Name ein: ");
            //string? name = Console.ReadLine();

            //switch (name)
            //{
            //    case "Nicolas":
            //        Console.WriteLine("Hallo Nicolas");
            //        break;
            //    case "Hilmar":
            //        Console.WriteLine("Hallo Hilmar");
            //        break;
            //    case "Saba":
            //        Console.WriteLine("Hallo Saba");
            //        break;
            //    case "Ron":
            //        Console.WriteLine("Hallo Ron");
            //        break;
            //    default:
            //        Console.WriteLine("Ungueltige Eingabe");
            //        break;
            //}

            /*
            «400 Bad Request» => Lade die Seite neu in 5 minuten
            «403 Forbidden» => Fragen Sie den Administrator fuer weitere Rechte
            «404 Not Found» => Bitte ueberpruefen Sie die URL
            «500 Internal Server Error» => Server hat probleme. PANIK!!!
            «502 Bad Gateway» => Schalte dein VPN an.
            «503 Service Unavailable» => Dies hat zuletzt vor 20 Jahren funktioniert. Wo warst du die ganze Zeit???
             */

           /* Console.WriteLine("Was fuer ein Fehler hast du bekommen?");
            string? fehlerCode = Console.ReadLine()*/

            /*switch (fehlerCode)
            {
                case "400":
                    Console.WriteLine("Lade die Seite neu in 5 Minuten.");
                    break;
                case "403":
                    Console.WriteLine("Fragen Sie den Administrator fuer weitere Rechte");
                    break;
                case "404":
                    Console.WriteLine("Bitte ueberpruefen Sie die URL");
                    break;
                case "500":
                    Console.WriteLine("Server hat probleme. PANIK!!!");
                    break;
                case "502":
                    Console.WriteLine("Schalte dein VPN an.");
                    break;
                case "503":
                    Console.WriteLine("Dies hat zuletzt vor 20 Jahren funktioniert. Wo warst du die ganze Zeit???");
                    break;
                default:
                    Console.WriteLine("Unbekannte Fehler Meldung...");
                    break;
            }*/









            // Aufgabe 1:
            // Wir schreiben ein kleinen Programm.
            // Die Benutzerin gibt Ihr alter ein.
            // Wenn die Benutzerin 18 => Du darfst jetzt Auto fahren.
            // Wenn die Benutzerin 16 => Du darfst dein erstes Bier trinken.
            // Wenn die Benutzerin 17 => Du darfst jetzt waehlen.
            // Alle andere faelle => Hier passiert garnichts.


            //Console.WriteLine("Bitte Alter eingeben und Enter drücken!");
            //string? alter = Console.ReadLine();

            //switch (alter)
            //{
            //    case "18":
            //        Console.WriteLine("Du darfst jetzt Auto fahren.");
            //        break;
            //    case "16":
            //        Console.WriteLine("Du darfst dein erstes Bier trinken.");
            //        break;
            //    case "17":
            //        Console.WriteLine("Du darfst jetzt waehlen.");
            //        break;







            //}






            //Aufgabe 2
            //Der Benutzer gibt eine Punktzahl(0–100) ein.
            //Das Programm soll anhand der Punktzahl eine Note ausgeben:
            //90–100 → „Sehr gut“
            //75–89 → „Gut“
            //60–74 → „Befriedigend“
            //50–59 → „Ausreichend“
            //0–49 → „Nicht bestanden“
            //Alle anderen Werte → „Ungültige Eingabe“


            //Aufgabe 2
            //Der Benutzer gibt eine Punktzahl(0–100) ein.
            //Das Programm soll anhand der Punktzahl eine Note ausgeben:
            //90–100 → „Sehr gut“
            //75–89 → „Gut“
            //60–74 → „Befriedigend“
            //50–59 → „Ausreichend“
            //0–49 → „Nicht bestanden“
            //Alle anderen Werte → „Ungültige Eingabe“

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
              //9 Zeilen

              //24 Zeilen
              string ausgabe1 = "";
              switch (punktzahl)
              {
                  case < 0 or > 100:
                      ausgabe1 = "Ungültige Eingabe";
                      break;
                  case <= 49:
                      ausgabe1 = "Nicht bestanden";
                      break;
                  case <= 59:
                      Console.WriteLine("Ausreichend");
                      break;
                  case <= 74:
                      Console.WriteLine("Befriedigend");
                      break;
                  case <= 89:
                      Console.WriteLine("Gut");
                      break;
                  default:
                      Console.WriteLine("Sehr gut");
                      break;
              }

              Console.WriteLine(ausgabe1);*/

            //Aufgabe 3: Folgendes zu einen Switch oder Pattern Matching Switch Konvertieren.
            //            Console.Write("Bitte Alter eingeben: ");

            //            int alter = Convert.ToInt32(Console.ReadLine());

            //            if (alter < 0 || alter > 130)
            //            {
            //                Console.WriteLine("Ungültige Eingabe");
            //            }
            //            else if (alter >= 65)
            //            {
            //                Console.WriteLine("Rentner");
            //            }
            //            else if (alter >= 18)
            //            {
            //                Console.WriteLine("Erwachsen");
            //            }

            //            else
            //            {
            //                Console.WriteLine("Minderjährig");
            //            }










/*

        }
    }
}*/
