namespace PatternMatchingSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie bitte eine Punktzahl (0-100) ein.");
            int punktzahl;
            bool erfolgreich = int.TryParse(Console.ReadLine(), out punktzahl);
            if (!erfolgreich)
            {
                Console.WriteLine("Keine Zahl eingegeben.");
                return;
            }

            // Pattern Matching Switch
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
            // 9 Zeilen

            // 22 Zeilen
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

            Console.WriteLine(ausgabe1);



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

            Console.Write("Bitte Alter eingeben: ");
            int alter = Convert.ToInt32(Console.ReadLine());
            //  int alter = int.Parse(Console.ReadLine());

            string ausgabe2 = alter switch
            {
                < 0 or > 130 => "Ungültige Eingabe",
                >= 65 => "Rentner",
                >= 18 => "Erwachsen",
                _ => "Minderjährig"
            };

            Console.WriteLine(ausgabe2);
        }
    }
}
