namespace ErsterProjekt
{
    internal class Program
   {
      static void Main()
       {
            Bankkonto nicoKonto = new Bankkonto("Nicolas Arevalo Hoelscher");
            nicoKonto.kontodetails();
            Console.WriteLine("Geben Sie Ihr pin bitte ein:");
            string? pin = Console.ReadLine();
            nicoKonto.Einzahlen(100.50m, pin);
            nicoKonto.Auszahlen(20.50m, pin);
            nicoKonto.Kontoauszug(pin);
            nicoKonto.KontostandAnzeigen(pin);
           




        }
    }
}
