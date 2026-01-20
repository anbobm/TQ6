namespace ErsterProjekt
{
    internal class Program
    {
        static void Main()
        {

            Bankkonto nicoKonto = new Bankkonto("Nicolas Arevalo Hoelscher");
            nicoKonto.Kontodetails();
            Console.WriteLine("Geben Sie Ihr pin bitte ein:");
            string pin = Console.ReadLine();
            nicoKonto.Einzahlen(100m,pin);
            nicoKonto.Auszahlen(73m, pin);
            nicoKonto.Einzahlen(97m, pin);
            nicoKonto.Einzahlen(2000m, pin);
            nicoKonto.Kontoauszug(pin);
        }
    }
}