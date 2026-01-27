namespace ErsterProjekt
{
    internal class Program
    {

        static void Main()
        {

            Bank deutscheBank = new Bank("Deutsche Bank", "Berlin Brandenburg", "Berlin", "Hauptstrasse 2");
            deutscheBank.BankMenueOeffnen();

        }
    }
}