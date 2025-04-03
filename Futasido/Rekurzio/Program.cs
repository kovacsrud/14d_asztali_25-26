using System.Diagnostics;

namespace Rekurzio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopper = new Stopwatch();
            stopper.Start();
            Kiir(100);
            stopper.Stop();
            Console.WriteLine();
            Console.WriteLine($"Végrahajtás ideje(rek):{stopper.ElapsedTicks}");
            stopper.Reset();

            stopper.Start();
            KiirFor(100);
            stopper.Stop();
            Console.WriteLine();
            Console.WriteLine($"Végrahajtás ideje(for):{stopper.ElapsedTicks}");

        }

        //Rekurzív függvény, a függvény saját magát hívja
        static void Kiir(int szamlalo)
        {
            Console.Write($"Számláló:{szamlalo} ");
            szamlalo--;
            if (szamlalo > 0)
            {
                Kiir(szamlalo);
            }
        }

        static void KiirFor(int szamlalo) {
            for (int i = 0; i < szamlalo; i++)
            {
                Console.Write($"Számláló:{i} ");
            }
        }
    }
}
