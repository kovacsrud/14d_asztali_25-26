namespace ListaFunkciok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista funkciók");
            List<int> szamok=new List<int>();
            Random rand = new Random();

            int darab=rand.Next(100,200+1);

            for (int i = 0; i < darab; i++) {
                szamok.Add(rand.Next(-100,200+1));
            }

            Console.WriteLine($"A lista hossza:{szamok.Count}");

            //Készítsünk egy új listát, amelyik az eredeti listából az 50-nél nagyobbakat tartalmazza.
            List<int> nagyobbMintOtven = szamok.FindAll(x=>x>50);

            Listazas(nagyobbMintOtven);
            
            var kisebbMintNulla=szamok.FindAll(x=>x<0);

            Console.WriteLine(kisebbMintNulla);

            Listazas(kisebbMintNulla);

            //A darabszám értéke megtalálható-e a listában?
            if (szamok.Contains(darab))
            {
                Console.WriteLine($"A darabszám {darab} értéke benne van a listában!");
            } else
            {
                Console.WriteLine($"A darabszám {darab} értéke nincs benne a listában!");
            }

            //Van-e 179-nél nagyobb szám a listában?
            if (szamok.Any(x=>x>179))
            {
                Console.WriteLine("Van 179-nél nagyobb");

            } else
            {
                Console.WriteLine("Nincs 179-nél nagyobb");
            }

            //Van-e 179 és 185 közé eső szám a listában?
            if (szamok.Any(x => x > 179 && x<185))
            {
                Console.WriteLine("Van ilyen");

            }
            else
            {
                Console.WriteLine("Nincs ilyen");
            }



        }

        private static void Listazas(List<int> nevek)
        {
            for (int i = 0; i < nevek.Count; i++)
            {
                Console.Write(nevek[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
