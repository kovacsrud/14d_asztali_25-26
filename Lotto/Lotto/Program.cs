namespace Lotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lottó");

            int huzasDb;
            int mennyibolHuzunk;
            Random random = new Random();

            Console.Write("Hány számmal játszunk?:");
            huzasDb = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mennyi számból húzunk?:");
            mennyibolHuzunk = Convert.ToInt32(Console.ReadLine());

            

            int[] tippek = new int[huzasDb];
            int[] nyeroSzamok = new int[huzasDb];

            char valasz;

            do
            {
                TippReset(tippek);

                int talalatok = 0;

                //Tippek bekérése
                Tippeles(huzasDb, mennyibolHuzunk, tippek);

                //Tippek listázása
                TombLista(tippek);

                //Nyerőszámok "sorsolása"
                Sorsolas(huzasDb, mennyibolHuzunk, random, nyeroSzamok);

                Array.Sort(nyeroSzamok);
                //Nyerőszámok listázása
                TombLista(nyeroSzamok);

                //Találatok számának meghatározása

                //talalatok = Talalat1(talalatok, tippek, nyeroSzamok);

                //Egyszerűbb megoldás
                talalatok = Talalat2(talalatok, tippek, nyeroSzamok);

                Console.WriteLine($"Találatok száma:{talalatok}");

                Console.Write("Akar új játékot?(i/n)");
                valasz = Console.ReadKey().KeyChar;
                Console.WriteLine();

            } while (valasz=='i');
        }

        private static void TippReset(int[] tippek)
        {
            for (int i = 0; i < tippek.Length; i++)
            {
                tippek[i] = 0;
            }
        }

        private static int Talalat2(int talalatok, int[] tippek, int[] nyeroSzamok)
        {
            for (int i = 0; i < tippek.Length; i++)
            {
                if (nyeroSzamok.Contains(tippek[i]))
                {
                    talalatok++;
                }
            }

            return talalatok;
        }

        private static int Talalat1(int talalatok, int[] tippek, int[] nyeroSzamok)
        {
            for (int i = 0; i < tippek.Length; i++)
            {
                for (int j = 0; j < nyeroSzamok.Length; j++)
                {
                    if (tippek[i] == nyeroSzamok[j])
                    {
                        talalatok++;
                    }
                }

            }

            return talalatok;
        }

        private static void Sorsolas(int huzasDb, int mennyibolHuzunk, Random random, int[] nyeroSzamok)
        {
            for (int i = 0; i < huzasDb; i++)
            {
                int temp = random.Next(1, mennyibolHuzunk + 1);
                while (nyeroSzamok.Contains(temp))
                {
                    temp = random.Next(1, mennyibolHuzunk + 1);
                }
                nyeroSzamok[i] = temp;

            }
        }

        private static void Tippeles(int huzasDb, int mennyibolHuzunk, int[] tippek)
        {
            for (int i = 0; i < huzasDb; i++)
            {
                Console.Write($"Tipp {i + 1}:");
                int temp = Convert.ToInt32(Console.ReadLine());
                while (temp < 1 || temp > mennyibolHuzunk || tippek.Contains(temp))
                {
                    Console.Write($"Hibás tipp, újra!{i + 1}:");
                    temp = Convert.ToInt32(Console.ReadLine());
                }
                tippek[i] = temp;

            }

            Array.Sort(tippek);
        }

        private static void TombLista(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
