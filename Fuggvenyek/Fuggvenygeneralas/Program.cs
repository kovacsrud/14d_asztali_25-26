namespace Fuggvenygeneralas
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Függvények generálása");

            int elemSzam = 111;

            int[] szamok = new int[elemSzam];
            Random rnd = new Random();

            //feltöltés
            TombFeltoltes(szamok, rnd,-5000,6000);



            //elemek listázása
            TombLista(szamok);

            //Írjon függvényeket, melyekkel meghatározható a tömb elemeinek az összege, átlaga, min ill. max értéke
            Console.WriteLine(TombOsszeg(szamok));

            Console.WriteLine($"Az elemek összege:{TombOsszeg(szamok)}");
            Console.WriteLine($"Az elemek átlaga:{TombAtlag(szamok)}");
            Console.WriteLine($"Az elemek minimuma:{TombMin(szamok)}");
            Console.WriteLine($"Az elemek maximuma:{TombMax(szamok)}");

            Console.WriteLine($"C# eszközével az összeg:{szamok.Sum()}");
            Console.WriteLine($"C# eszközével az átlag:{szamok.Average()}");
            Console.WriteLine($"C# eszközével a minimum:{szamok.Min()}");
            Console.WriteLine($"C# eszközével a maximum:{szamok.Max()}");



        }

        private static int TombMin(int[] szamok)
        {
            int min = szamok[0];

            for (int i = 0; i < szamok.Length; i++)
            {
                if(szamok[i] < min)
                {
                    min = szamok[i];
                }
            }
            return min;
        }

        private static int TombMax(int[] szamok)
        {
            int max = szamok[0];

            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] > max)
                {
                    max = szamok[i];
                }
            }
            return max;
        }

        private static double TombAtlag(int[] szamok)
        {
            double atlag=(double)TombOsszeg(szamok)/szamok.Length;

            return atlag;
        }

        private static int TombOsszeg(int[] szamok)
        {
            int osszeg = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                osszeg += szamok[i];
            }

            return osszeg;
        }

        private static void TombLista(int[] szamok)
        {
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write(szamok[i] + " ");
            }
            Console.WriteLine();
        }

        private static void TombFeltoltes(int[] szamok, Random rnd,int alsoHatar,int felsoHatar)
        {
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rnd.Next(alsoHatar, felsoHatar+1);
            }
        }
    }
}
