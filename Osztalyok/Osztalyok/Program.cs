namespace Osztalyok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Osztályok");
            //Osztály: összetett struktúra, az objektum-orientált programozás alapegysége
            //Az osztály adatokat és függvényeket tartalmazhat. Az osztály függvényeit szokás metódusnak is nevezni.
            //Legtöbbször külön fájlba helyezzük.

            //Bezártság elve (encapsulation). Az osztály elrejti az adatait és a metódusait a külvilág elől, az osztályt csak egy interfészen keresztül lehessen megközelíteni.

            //Osztály példányosítása
            Szemely zoli = new Szemely();
            zoli.nev = "Zoltán";
            zoli.lakhely = "Gyula";
            zoli.szulEv = 1988;
            zoli.suly = 76;
            zoli.magassag = 175;

            Console.WriteLine($"A személy neve:{zoli.nev}");
            Console.WriteLine($"A személy életkora:{zoli.Eletkor()}");

            Szemely ella = new Szemely
            {
                nev = "Ella",
                szulEv = 2004,
                suly = 66,
                lakhely="Eger",
                magassag=176
                
            };

            Console.WriteLine($"A másik személy életkora:{ella.Eletkor()}");

            Tanulo elza = new Tanulo();
            elza.SetNev("Ella");

            Console.WriteLine($"Elza:{elza.GetNev()},{elza.Eletkor()}");

            Tanulo ubul= new Tanulo("Gyula");


            Tanulo zalan = new Tanulo("Zalán",2001,189,76,"Orosháza");
            Console.WriteLine($"Zalán:{zalan.GetNev()},{zalan.Eletkor()}");

            Tanulo2 elek = new Tanulo2
            {
                Lakhely = "Orosháza",
                Magassag = 175,
                Suly = 79,
                Nev = "Elek",
                SzulEv=1978
                
            };

            Console.WriteLine($"Elek:{elek.Nev},{elek.SzulEv},{elek.Lakhely}");
            
            

        }
    }
}
