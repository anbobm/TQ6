namespace ErsterProjekt
{
    internal class Program
   {
      static void Main()
       {
            /*Bank superBank = new Bank("Super Bank", "Muenchen1", "Muenchen", "Leopold str.11");
            superBank.BankMenueOeffnen();*/


            //Bankkonto nicoKonto = new Bankkonto("Nicolas Arevalo Hoelscher");
            //nicoKonto.Kontodetails();
            //Console.WriteLine("Geben Sie Ihr pin bitte ein:");
            //string pin = Console.ReadLine();
            //nicoKonto.Einzahlen(100m,pin);
            //nicoKonto.Auszahlen(73m, pin);
            //nicoKonto.Einzahlen(97m, pin);
            //nicoKonto.Einzahlen(2000m, pin);
            //nicoKonto.Kontoauszug(pin);

            Schule schule = new Schule();
            schule.AddSchueler(new Person("Saba", 22));
            schule.AddSchueler(new Person("Anna", 30));
            schule.AddSchueler(new Person("Tom", 18));
            schule.SchuelerDetails();
            Schueler s1 = new Schueler("Saba", 43, "12A");
            s1.Ausgabe();


        }
    }
}
