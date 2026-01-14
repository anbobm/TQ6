/*using System;
using System.Collections.Generic;
using System.Text;

namespace ErsterProjekt
{
class blackjack
    {
         static void main() 
        {
            List<string> zahlenkarten = new List<string>()
            {
             "2","3","4","5","6","7","8","9","10",
                "Bube","Dame","König","Ass"
            };

            Random random = new Random();
            string spielerkarte1 = zahlenkarten[random.Next(zahlenkarten.Count)];
            string spielerkarte2 = zahlenkarten[random.Next(zahlenkarten.Count)];

            using System;
            using System.Collections.Generic;
            using System.Text;

namespace ErsterProjekt
    {
        internal class Blackjack
        {
            public static List<string> stappel = new List<string>();

            static void Main()
            {
                BlackjackGameLoop();
            }

            public static void BlackjackGameLoop()
            {
                StappelErstellen();

                List<string> spielerKarten = new List<string>();
                List<string> dealerKarten = new List<string>();

                spielerKarten.Add(KarteZiehen());
                spielerKarten.Add(KarteZiehen());
                Console.Write("Deine Karten: ");
                KartenSehen(spielerKarten);

                dealerKarten.Add(KarteZiehen());
                Console.Write("Dealer Karte: ");
                KartenSehen(dealerKarten);
                dealerKarten.Add(KarteZiehen());
                if (HandAuswerten(dealerKarten) > 21)
                {
                    Console.WriteLine("Dealer hat verloren.");
                    return;
                }

                if (HandAuswerten(spielerKarten) != 21)
                {
                    bool standEingegeben = false;
                    while (!standEingegeben)
                    {
                        Console.WriteLine("Geben Sie Stand (s) oder Hit (h) ein:");
                        string eingabe = Console.ReadLine().ToLower();
                        if (eingabe == "s")
                        {
                            standEingegeben = true;
                            continue;
                        }
                        else if (eingabe == "h")
                        {
                            spielerKarten.Add(KarteZiehen());
                            Console.Write("Deine Karten: ");
                            KartenSehen(spielerKarten);
                            if (HandAuswerten(spielerKarten) > 21)
                            {
                                Console.WriteLine("Sie haben verloren.");
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Leider nicht verstanden.");
                            Console.WriteLine("Geben Sie bitte nur h oder s ein.");
                        }
                    }
                }

                while (HandAuswerten(dealerKarten) < 17)
                {
                    dealerKarten.Add(KarteZiehen());
                }


                Console.Write("Deine Karten: ");
                KartenSehen(spielerKarten);

                Console.Write("Dealer Karte: ");
                KartenSehen(dealerKarten);


                if (HandAuswerten(dealerKarten) > 21 || HandAuswerten(dealerKarten) < HandAuswerten(spielerKarten))
                {
                    Console.WriteLine("Sie haben gewonnen!");
                }
                else if (HandAuswerten(dealerKarten) == HandAuswerten(spielerKarten))
                {
                    Console.WriteLine("Langweilig...");
                }
                else
                {
                    Console.WriteLine("Sie haben verloren...");
                }
            }

            static void KartenSehen(List<string> karten)
            {
                Console.Write("{");
                foreach (string karte in karten)
                {

                    if (karte == karten.ElementAt(karten.Count - 1))
                    {
                        Console.Write(karte);
                    }
                    else
                    {
                        Console.Write(karte + ", ");
                    }
                }
                Console.WriteLine("} - Aktuelle Punktzahl: " + HandAuswerten(karten));
            }

            static string KarteZiehen()
            {
                Random random = new Random();
                int gezogeneKarteIndex = random.Next(0, stappel.Count);

                string unsereKarte = stappel.ElementAt(gezogeneKarteIndex);
                stappel.Remove(unsereKarte);

                return unsereKarte;
            }

            static List<string> StappelErstellen()
            {
                stappel = new List<string>();
                List<string> zahlenkarten = new List<string>()
              {
               "2","3","4","5","6","7","8","9","10",
                  "Bube","Dame","König","Ass"
              };

                for (int i = 0; i < 4; i++)
                {
                    stappel.AddRange(zahlenkarten);
                }

                return stappel;
            }

            static int HandAuswerten(List<string> karten)
            {
                int summe = 0;
                foreach (string karte in karten)
                {
                    int wert = karte switch
                    {
                        "2" => 2,
                        "3" => 3,
                        "4" => 4,
                        "5" => 5,
                        "6" => 6,
                        "7" => 7,
                        "8" => 8,
                        "9" => 9,
                        "10" or
                        "Bube" or
                        "Dame" or
                        "König" => 10,
                        "Ass" => 11
                    };
                    summe += wert;
                }
                return summe;
            }
            *//*
             * Moderne Variante der Methode.
             * static int KarteAuswerten(string karte) => karte switch
            {
                "2" => 2,
                "3" => 3,
                "4" => 4,
                "5" => 5,
                "6" => 6,
                "7" => 7,
                "8" => 8,
                "9" => 9,
                "10" or
                "Bube" or
                "Dame" or
                "König" => 10,
                "Ass" => 11
            };
             *//*
            bool gueltigeEingabe = false;
            do
            {
                try
                {
                    Console.WriteLine("Geben Sie bitte eine Zahl ein: ");
                    double zahl = double.Parse(Console.ReadLine());

            Console.WriteLine($"Das Resultat von 30/{zahl} = {30 / zahl}");
                    gueltigeEingabe = true;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Sie duerfen nicht durch 0 teilen.");
                    Console.WriteLine(ex.ToString());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Sie muessen nur Zahlen eingeben!");
                    Console.WriteLine(ex.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

            } while (!gueltigeEingabe) ;

        }
    }


}
    }
}*/
