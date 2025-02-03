namespace ProgramozasiTetelek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programozási tételek");
            //A programozási tételek gyakran használt algoritmusokat jelentenek
            //megszámlálás, összegzés, kiválasztás, min. ill. max. meghatározás, keresés, szétválogatás

            int[] szamok = { 10, 22, 313, 19, 8, 76, 2004, 31, 13, 52 };

            //megszámlálás 
            //számoljuk meg, hogy hány db 20-nál kisebb szám van a tömmben!

            int husznalKisebbDb = 0;

            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i]<20)
                {
                    husznalKisebbDb++;
                }
            }

            //Visszaállítjuk 0-ra az összeget tartalmazó változót.
            husznalKisebbDb = 0;
            //foreach ciklussal:
            foreach (var szam in szamok)
            {
                if (szam<20)
                {
                    husznalKisebbDb++;
                }
            }

            Console.WriteLine($"Húsznál kisebb számok darabszáma a tömbben:{husznalKisebbDb}");

            //összegzés
            int osszeg = 0;

            for (int i = 0; i < szamok.Length; i++)
            {
                osszeg += szamok[i];
            }

            //foreach ciklussal:

            //Visszaállítjuk 0-ra az összeget tartalmazó változót.
            osszeg = 0;
            foreach(var szam in szamok)
            {
                osszeg += szam;
            }

            Console.WriteLine($"A számok összege:{osszeg}");

            //Eldöntés
            //Határozzuk meg hogy a beolvasott érték benne van-e a tömbben!
            Console.Write("Adjon meg egy számot:");
            int beSzam=Convert.ToInt32(Console.ReadLine());
            bool benneVan=false;
            int keresettIndex = -1;

            for (int i = 0; i < szamok.Length; i++)
            {
                
                if (beSzam == szamok[i])
                {
                    benneVan = true;
                    keresettIndex = i;
                    break;
                    
                }
                Console.Write(i+" ");
            }

            

            if (benneVan) {
                Console.WriteLine($"A keresett érték benne van a tömbben! A {beSzam} a {keresettIndex+1}. elem a tömbben.");
            }
            else
            {
                Console.WriteLine("A keresett érték nem található!");
            }

            //Eldöntés elöltesztelő ciklussal
            keresettIndex = -1;
            benneVan = false;
            int szamlalo = 0;

            while (!benneVan && szamlalo<szamok.Length) {
                if (szamok[szamlalo]==beSzam)
                {
                    benneVan = true;
                    keresettIndex=szamlalo;
                }                  
                szamlalo++;
            }

            if (benneVan)
            {
                Console.WriteLine($"A keresett érték benne van a tömbben! A {beSzam} a {keresettIndex + 1}. elem a tömbben.");
            }
            else
            {
                Console.WriteLine("A keresett érték nem található!");
            }

            //minimum és maximum kiválasztás

            //Egyik lehetséges megadása a kezdő értékeknek
            //int min = Int32.MaxValue;
            //int max = Int32.MinValue;

            //A vizsgált tömb első elemének megadása, mint kezdőérték.
            int min = szamok[0];
            int max = szamok[0];

            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] < min)
                {
                    min = szamok[i];
                }
                if(szamok[i] > max)
                {
                    max = szamok[i]; 
                }
            }
            Console.WriteLine($"Min:{min},max:{max}");

        }
    }
}
