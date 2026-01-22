namespace ErsterProjekt
{
    internal class Program
    {

        static void Main()
        {
            

            Dictionary<int,List<int>> zeitplan = new Dictionary<int,List<int>>();
            zeitplan.Add(0, new List<int>() {20,40 });
            zeitplan.Add(7, new List<int>() { 5,10,15,20,25,30,35, 40,45,50,55 });
            zeitplan.Add(2, new List<int>() { 20, 40 });
            zeitplan.Add(13, new List<int>() { 20, 40 });

            Bus meinBus = new Bus(45, 0.95, 101, zeitplan);

            meinBus.Fahren();

            meinBus.Halten();

            Methoden.Summieren(3, 3, 4);
        }
    }
}