namespace TernaryOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ternary Operator
            //Verwenden wir um kleine if-bedingungen in eine verkuerzte form zu schreiben
            //Syntax: bedingung ? fall true : fall false

            int alter = Convert.ToInt32(Console.ReadLine());
            string ausgabe = (alter < 0 || alter > 130) ? "Ungültige Eingabe" :
                alter >= 65 ? alter >= 80 ? "Opa" : "Rentner"
                : alter >= 18 ? "Erwachsen" : "Minderjährig";
            Console.WriteLine(ausgabe);
        }
    }
}
