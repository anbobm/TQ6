namespace ErsterProjekt
{
    internal class Program
   {
      static void Main()
       {
            Heizungsystem h = new Heizungsystem("Bosch", 30, "Gas", 18, "aus");

            h.Anschalten();
            h.Hauserwaermen(25);
            h.Ausschalten();

        }
    }
}
