namespace Bankkonto
{
    internal class Bankkonto
    {
        //Attribute
        private decimal kontostand;
        //                      DE              89              37040          04405        3201300
        private string iban;//country code - check digit - bank id code - branche code - kontonummer
        private string kontonummer;
        private string kontoinhaber;
        private string bank;
        private string filiale;
        //    PSTB       DE                MU           MU2       => PSTBDEMUMU2
        //Bank code - laendercode - standort stadt - filiale
        private string bic;
        private string pin;


        //Konstruktor
        public Bankkonto(string kontoinhaber, string bank = "SuperBank", string filiale = "Muenchen")
        {
            this.kontoinhaber = kontoinhaber;
            this.bank = bank;
            this.filiale = filiale;
            kontostand = 0;
            pin = PinErstellen();
            //Pin ueberpruefen methode: Console.WriteLine(pin);
            //iban
            //kontonummer
            //bic
            bic = BicErstellen();
            //Anforderungen fuer BIC:
            //Bic soll zuffaelig 4 zeichen erstellen und abspeichern, dann DE abspeichern,
            //dann 2 zuffaelige buchstaben, dann erste 2 buchstaben
            //von filiale und eine zuffaelige zahl zwischen 0-9
        }

        //Methoden
        private string PinErstellen()
        {
            Random random = new Random();
            string neuerPin = "";

            for (int i = 0; i < 4; i++)
            {
                neuerPin += random.Next(0, 10);
            }
            return neuerPin;
        }

        private string BicErstellen()
        {
            Random random = new Random();
            string neuerBic = "";

            // 4 zufaellige Buchstaben
            for (int i = 0; i < 4; i++)
            {
                neuerBic += (char)random.Next('A', 'Z' + 1);
            }

            // Laendercode
            neuerBic += "DE";

            // 2 zufaellige Buchstaben
            for (int i = 0; i < 2; i++)
            {
                neuerBic += (char)random.Next('A', 'Z' + 1);
            }

            // Erste 2 Buchstaben der Filiale
            if (filiale.Length >= 2)
            {
                neuerBic += filiale.Substring(0, 2).ToUpper();
            }
            else
            {
                neuerBic += filiale.ToUpper().PadRight(2, 'X');
            }

            // Zufaellige Zahl zwischen 0-9
            neuerBic += random.Next(0, 10);

            return neuerBic;
        }
    }
}