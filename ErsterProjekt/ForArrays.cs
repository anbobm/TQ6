//namespace ErsterProjekt
//{
//    class ForArrays
//    {
//        static void Main()
//        {
//            ////int zaehler = 0;

//            ////while(zaehler < 5)
//            ////{
//            ////    Console.WriteLine(zaehler);
//            ////    zaehler++;
//            ////}
//            ////Index             0       1           2
//            ////Einkaufsliste: ['Apple','Yogurt','Zucchini']
//            ////Schreibt eine For schleife die alle zahlen von 0 bis 10 inklusiv
//            ////aufsummiert. Dann nach der schleife diese Summe ausgeben.


//            ////Gruppe von Daten hauefig Collection benannt.
//            ////Immer plurale variable namen waehlen!

//            ////Mit vordefinierte werte und laenge!
//            ////Indizes               0       1       2         3        4        5       6      7
//            //string[] namen = { "Nicolas", "Ron", "Hannes", "Saba", "Hilmar", "Vache","Rene","Hanane" };

//            //int[] noten = new int[namen.Length];
//            ////IndexOutOfBoundsException

//            //for (int index = 0; index < namen.Length; index++)
//            //{
//            //    Console.WriteLine("Geben Sie bitte die Note von " + namen[index] + " ein:");
//            //    int note = int.Parse(Console.ReadLine());
//            //    noten[index] = note;
//            //}

//            //foreach (string name in namen)
//            //{
//            //    Console.WriteLine("Hallo " + name);
//            //}

//            ////Speicher noten in Datenbank ab!

//            //string[] namen2 = [ "Nicolas", "Ron", "Hannes", "Saba", "Hilmar", "Vache" ];
//            //bool[] garage = [true, false, false];

//            ////Ohne vordefinierte werte aber mit vordefinierte laenge!
//            //string[] geologie101 = new string[20];

//            //geologie101[0] = "Nicolas";
//            //geologie101[1] = "Bob";
//            //geologie101[2] = "Riley";
//            //geologie101[3] = "Angela";
//            //geologie101[19] = "James";
//            ////Stelle 1 = 0
//            ////Stelle 2 = 1


//            //string[] bestellungIDs = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

//            //foreach (string id in bestellungIDs)
//            //{
//            //    if (id.StartsWith("B"))
//            //    {
//            //        Console.WriteLine(id);
//            //        bestellungIDs[bestellungIDs.IndexOf(id)] = "C234";
//            //    }
//            //}

//            //for (int i = 0; i < bestellungIDs.Length; i++)
//            //{
//            //    bestellungIDs[i] = "C234";
//            //}


//            //int[] noten = { 78, 92, 99, 37, 81 };
//            //noten.Average();

//            ////                    72   97   102 102  103
//            //char[] buchstaben = ['H', 'a', 'l', 'l', 'o'];

//            //Array.Sort(buchstaben);
//            //Array.Reverse(buchstaben);
//            //Console.WriteLine();
//            //string wort = new string(buchstaben);
//            //Console.WriteLine(wort);

//            //wort.ToCharArray();

//            string pangram = "The quick brown fox jumps over the lazy dog";
//            //ehT kciuq nworb xof spmuj revo eht yzal god

//            //Split(), ToCharArray(), Array.Reverse() und String.Join()

//            string[] geteiltesSatz = pangram.Split(' ');
//            string[] resultat = new string[geteiltesSatz.Length];

//            for (int i = 0; i < geteiltesSatz.Length; i++)
//            {
//                char[] buchstaben = geteiltesSatz[i].ToCharArray();

//                Array.Reverse(buchstaben);
//                resultat[i] = new string(buchstaben);
//            }

//            string umgedrehtesSatz = String.Join(" ", resultat);

//            Console.WriteLine(umgedrehtesSatz);

//        }





//    }
//}