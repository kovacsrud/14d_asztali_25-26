namespace Felhasznaloi_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adjon meg egy számot!:");
            int egyikSzam = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Adjon meg egy másik számot!:");
            int masikSzam=Convert.ToInt32(Console.ReadLine());

            //kasztolás avagy típus kényszerítés

            double osszeg=(double)egyikSzam/masikSzam;

            Console.WriteLine($"Az összeg:{osszeg}");
        }
    }
}
