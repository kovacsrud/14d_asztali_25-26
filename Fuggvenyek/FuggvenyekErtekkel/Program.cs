namespace FuggvenyekErtekkel
{
    internal class Program
    {
        static int Osszeadas(int a,int b)
        {
            return a + b;
        }

        static double Osszeadas(double a,double b)
        {
            double eredmeny = a + b;

            return eredmeny;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Függvények visszatérési értékkel");
            
            //A visszatérési értékkel rendelkező függvény lehet más függvények bemenete
            Console.WriteLine(Osszeadas(10,20));

            //Szerepelhet értékadó utasításban
            int osszeg = Osszeadas(100, 233);

            Console.WriteLine(osszeg);

            Console.WriteLine(Osszeadas(10.67,78.99));
            
        }
    }
}
