namespace LottoListaval
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

            int talalatok = 0;

            List<int> tippek = new List<int>();
            List<int> nyeroSzamok = new List<int>();
            List<int> sorsoloGomb = new List<int>();

            GombFeltoltes(mennyibolHuzunk, sorsoloGomb);



            //Tippek bekérése
            Tippeles(huzasDb, mennyibolHuzunk, tippek);
            int huzasokSzama = 0;

            while (talalatok!=5) {

                talalatok = 0;

                //Listazas(tippek);

                //Nyerőszámok sorsolása
                Sorsolas(huzasDb, random, nyeroSzamok, sorsoloGomb);
                //Listazas(nyeroSzamok);

                //Találatok megtározása
                talalatok = Talalat(talalatok, tippek, nyeroSzamok);

                if (talalatok >0 ) {
                    Console.WriteLine(talalatok);
                }
                

                //Console.WriteLine($"Találatok száma:{Talalat(talalatok, tippek, nyeroSzamok)}");

                //Visszatesszük a számokat
                sorsoloGomb.AddRange(nyeroSzamok);
                //Kiürítjük a nyerőszámok listát
                nyeroSzamok.Clear();

                huzasokSzama++;

            }

            Console.WriteLine($"Ennyi évbe telt:{(double)huzasokSzama/52:0.00}");



        }

        private static void Sorsolas(int huzasDb, Random random, List<int> nyeroSzamok, List<int> sorsoloGomb)
        {
            for (int i = 0; i < huzasDb; i++)
            {
                //Ki kell választani a sorsoló gömbből egy számot és átrakni a nyeroszamok listára
                int kivalasztottSzam = sorsoloGomb[random.Next(0, sorsoloGomb.Count)];
                nyeroSzamok.Add(kivalasztottSzam);
                sorsoloGomb.Remove(kivalasztottSzam);
            }
            nyeroSzamok.Sort();
        }

        private static void Tippeles(int huzasDb, int mennyibolHuzunk, List<int> tippek)
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
                //tippek[i] = temp;
                tippek.Add(temp);
            }
            tippek.Sort();
        }

        private static int Talalat(int talalatok, List<int> tippek, List<int> nyeroSzamok)
        {
            for (int i = 0; i < tippek.Count; i++)
            {
                if (nyeroSzamok.Contains(tippek[i]))
                {
                    talalatok++;
                }
            }

            return talalatok;
        }

        private static void GombFeltoltes(int mennyibolHuzunk, List<int> sorsoloGomb)
        {
            for (int i = 0; i < mennyibolHuzunk; i++)
            {
                sorsoloGomb.Add(i + 1);
            }
        }

        private static void Listazas(List<int> tomb)
        {
            for (int i = 0; i < tomb.Count; i++)
            {
                Console.Write(tomb[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
