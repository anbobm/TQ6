//namespace ErsterProjekt
//{
//    internal class IfBedingungen
//    {
//        static void Main()
//        {
//            Console.WriteLine("Bedingungen Uebungen!");

//            // Aufgabe 1
//            //Der Benutzer gibt eine Punktzahl(0–100) ein.
//            //Das Programm soll anhand der Punktzahl eine Note ausgeben:
//            //90–100 → „Sehr gut“
//            //75–89 → „Gut“
//            //60–74 → „Befriedigend“
//            //50–59 → „Ausreichend“
//            //0–49 → „Nicht bestanden“
//            //Alle anderen Werte → „Ungültige Eingabe“

//            double punkte;
//            Console.WriteLine("Geben Sie ihre Punktzahl ein:");
//            punkte = Convert.ToDouble(Console.ReadLine());


//            //Loesung 1
//            //if (punkte < 0 || punkte > 100)
//            //{
//            //    Console.WriteLine("Ungültige Eingabe");
//            //}
//            //else
//            //{
//            //    if (punkte < 100)
//            //    {
//            //        if (punkte < 89)
//            //        {
//            //            if (punkte < 74)
//            //            {
//            //                if (punkte > 49)
//            //                {
//            //                    Console.WriteLine("Ausreichend");
//            //                }
//            //                else
//            //                {
//            //                    Console.WriteLine("Nicht Bestanden!");
//            //                }
//            //            }
//            //            else
//            //            {
//            //                Console.WriteLine("Gut");
//            //            }
//            //        }
//            //        else
//            //        {
//            //            Console.WriteLine("Sehr gut");
//            //        }
//            //    }
//            //}


//            //Loesung 2
//            if (punkte < 0 || punkte > 100)
//            {
//                Console.WriteLine("Ungültige Eingabe");
//            }
//            else if (punkte >= 90)
//            {
//                Console.WriteLine("Sehr gut");
//            }
//            else if (punkte >= 75)
//            {
//                Console.WriteLine("Gut");
//            }
//            else if (punkte >= 60)
//            {
//                Console.WriteLine("Befriedigend");
//            }
//            else if (punkte >= 50)
//            {
//                Console.WriteLine("Ausreichend");
//            }
//            else
//            {
//                Console.WriteLine("Nicht Bestanden!");
//            }

//            //Übung 2:
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



//        }
//    }
//}
