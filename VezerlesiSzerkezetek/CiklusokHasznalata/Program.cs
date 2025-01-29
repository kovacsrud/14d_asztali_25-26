namespace CiklusokHasznalata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] veletlenSzamok = new int[100];
            Random random = new Random();
            Console.WriteLine(random.Next(0,100+1));

            for (int i = 0; i < veletlenSzamok.Length; i++)
            {
                veletlenSzamok[i] = random.Next(1, 200 + 1);
            }

            for (int i = 0; i < veletlenSzamok.Length; i++)
            {
                //Console.Write(veletlenSzamok[i]+" ");
            }


            //Töltsön fel véletlen számokkal egy tömböt, majd írassa ki az elemeket! A tömb elemszáma is egy véletlen szám legyen 50-100 között!

            int[] veletlenSzamTomb = new int[random.Next(50,100+1)];

            for (int i = 0; i < veletlenSzamTomb.Length; i++)
            {
                veletlenSzamTomb[i] = random.Next(1, 200 + 1);
            }

            for (int i = 0; i < veletlenSzamTomb.Length; i++)
            {
                Console.Write(veletlenSzamTomb[i] + " ");
            }
        }
    }
}
