namespace GyakorloFeladatok1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            Console.Write("Adjon meg egy sebességet km/h-ban:");
            int sebessegKmh=Convert.ToInt32(Console.ReadLine());

            //típus kényszerítés
            double sebessegMs = (double)sebessegKmh / 3.6;

            Console.WriteLine($"Sebesség m/s-ban:{sebessegMs:0.00}");

            //2.
            Console.Write("Adja meg a kör átmérőjét:");
            int atmero=Convert.ToInt32(Console.ReadLine());

            //2*r*Pi
            double kerulet = atmero * Math.PI;

            

            //r*r*PI
            double terulet=Math.Pow(atmero/2,2)*Math.PI;

            Console.WriteLine($"Kerület:{kerulet:0.00},Terület:{terulet:0.00}");

            //Szöveg bekérése
            Console.Write("Adjon meg egy szöveget:");
            string szoveg=Console.ReadLine();

            Console.WriteLine($"Szóközökkel:{szoveg.Length},szóközök nélkül:{szoveg.Replace(" ","").Length}");

        }
    }
}
