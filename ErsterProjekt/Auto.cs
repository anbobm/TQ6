namespace ErsterProjekt
{
    internal class Auto
    {
        //Attribute
        string farbe;
        string modell;
        string hersteller;
        int ps;
        public int maxGeschwindigkeit;
        int aktuelleGeschwindigkeit;

        //Konstruktor -> Wie auto erstellt wird
        public Auto(string farbe, string modell, string marke, int ps, int maxGeschwindigkeit)
        {
            this.farbe = farbe;
            this.modell = modell;
            hersteller = marke;
            this.ps = ps;
            this.maxGeschwindigkeit = maxGeschwindigkeit;
            aktuelleGeschwindigkeit = 0;
        }

        //Methoden
        public void Fahren(int neueGeschwindigkeit)
        {
            for(int i = aktuelleGeschwindigkeit;i<=neueGeschwindigkeit; i += 10)
            {
                aktuelleGeschwindigkeit = i;
                Console.WriteLine($"Wir fahren schneller. Aktuelle Geschwindigkeit: {aktuelleGeschwindigkeit}" );
                if (aktuelleGeschwindigkeit >= maxGeschwindigkeit)
                {
                    Console.WriteLine("Max Geschwindigkeit erreicht.");
                    aktuelleGeschwindigkeit = maxGeschwindigkeit;
                    return;
                }
            }
        }

        public void Bremsen(int distanzZuObstacle)
        {

        }

        public void Parken()
        {

        }
    }
}
