namespace Ciklusok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ciklusok elöltesztelő,előírt lépésszámú vagy növekményes, hátultesztelő
            //elöltesztelő és hátultesztelő, egy adott feltétel teljesüléséig fut
            //előírt lépésszámú -> mi állítjuk be, hogy hányszor fut leintint


            int[] szamok = {11,244,65,455,998,1233,5677,233,5667 };

            //növekényes ciklus
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write(szamok[i]+" ");
            }

            //foreach - fontos, hogy a foreach ciklusban a bejárt adatszerkezet elemei nem módosíthatóak
            foreach (var elem in szamok)
            {
                Console.WriteLine(elem);
            }

            //elöltesztelő ciklus
            int szamlalo = 0;
            
            while (szamlalo<szamok.Length)
            {
                Console.WriteLine(szamok[szamlalo]);
                szamlalo++;
                //szamlalo=szamlalo+1;
                //szamlalo+=1;
            }

            //hátultesztelő ciklus -> Egyszer mindeféleképpen lefut
            szamlalo = 0;
            do
            {
                Console.WriteLine(szamok[szamlalo]);
                szamlalo++;
            }
            while (szamlalo<szamok.Length);


        }
    }
}
