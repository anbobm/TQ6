//namespace ErsterProjekt
//{
//    internal class Exceptions
//    {
//        static void Main()
//        {
//            File.AppendAllText("C:\\Users\\nicoa\\Desktop\\TQ6\\ErsterProjekt\\Log.txt", $"\n\n{DateTime.Now} - Programm Startet.");
//            bool gueltigeEingabe = false;
//            do
//            {
//                try
//                {
//                    Console.WriteLine("Geben Sie bitte eine Zahl ein: ");
//                    int zahl = int.Parse(Console.ReadLine());

//                    Console.WriteLine($"Das Resultat von 30/{zahl} = {30 / zahl}");
//                    gueltigeEingabe = true;
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine("Ungueltige Eingabe.");
//                    File.AppendAllText("C:\\Users\\nicoa\\Desktop\\TQ6\\ErsterProjekt\\Log.txt", $"\n\n{DateTime.Now} - {ex.ToString()}");
//                }

//            } while (!gueltigeEingabe);

//            File.AppendAllText("C:\\Users\\nicoa\\Desktop\\TQ6\\ErsterProjekt\\Log.txt", $"\n\n{DateTime.Now} - Programm Vorbei.");

//        }
//    }
//}