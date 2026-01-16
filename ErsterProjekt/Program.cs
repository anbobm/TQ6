namespace ErsterProjekt
{
    internal class Program
    {
        static void Main()
        {

            Auto meinAuto = new Auto("Rot", "Polo", "VW", 120, 200);
            Auto sabasAuto = new Auto("Schwarz","Touran","VW",200,120);
            Auto ronsAuto = new Auto("NeonKnallPinkSuperVersion","Bully","VW",180,160);
            Console.ForegroundColor = ConsoleColor.Magenta;
            ronsAuto.Fahren(300);





        }
    }
}