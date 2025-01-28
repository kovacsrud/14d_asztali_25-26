namespace StringMuveletek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A string egy olyan típus, amelynek az értéke nem változtatható meg.
            string szoveg = "Valami, bármi, akármi";


            //Látszólag megváltoztatjuk a változó értékét, de a háttérben megszűnik az eredeti változó és egy új jön létre.
            szoveg = "Valami más";

            Console.WriteLine(szoveg);

            //String hossza
            Console.WriteLine(szoveg.Length);

            //Tartalmazás vizsgálata
           // Console.WriteLine(szoveg.Contains("Hétfő"));
            //Console.WriteLine(szoveg.Contains("val"));
            //Console.WriteLine(szoveg.Contains("Val"));

            string keres = "Val";

            Console.WriteLine(szoveg.ToUpper().Contains(keres.ToUpper()));

            Console.WriteLine(keres);

            //Kezdete, vége
            Console.WriteLine(szoveg.StartsWith(keres));
            Console.WriteLine(szoveg.EndsWith(keres));

            //Karakter cseréje a szövegben
            Console.WriteLine(szoveg.Replace('a','x'));
            //Szóköz eltávolítása, idézőjelet kell használni
            Console.WriteLine(szoveg.Replace(" ",""));

            //Szövegrész kiemelése Valami más
            Console.WriteLine(szoveg.Substring(3));

            Console.WriteLine(szoveg.Substring(3,3));

            //Dátum feldolgozása substring-el
            string datum = "2025.01.28";

            string ev = datum.Substring(0, 4);
            Console.WriteLine(ev);
            string honap = datum.Substring(5, 2);
            Console.WriteLine(honap);
            string nap= datum.Substring(8, 2);
            Console.WriteLine(nap);

            Console.WriteLine($"Év:{ev},hónap:{honap},nap:{nap}");

            //szöveg feldarabolása
            //var - a jobb oldali kifejezés alapján megállapítja a C# a bal oldalon álló változónak mi lesz a típusa
            // a feldarabolás után az elemek egy tömbbe kerülnek
            var elemek = datum.Split('.');

            Console.WriteLine(elemek[0]);
            Console.WriteLine(elemek[1]);
            Console.WriteLine(elemek[2]);
            //Tömbelem túlindexelése
            //Console.WriteLine(elemek[3]);

            //Karakter pozíciójának lekérdezése. Ha nincs ilyen karakter, akkor -1 a visszaadott érték
            int pozicio=szoveg.IndexOf('x');
            Console.WriteLine(pozicio);

            //Stringek összefűzése
            string osszeFuzott = szoveg +" "+ datum+"\\";

            Console.WriteLine(osszeFuzott);

            //Karakter típus
            Char betu = 'g';

            //Karakter vizsgálata
            Console.WriteLine(Char.IsLetter(betu));
            Console.WriteLine(Char.IsDigit(betu));
            Console.WriteLine(Char.IsWhiteSpace(betu));




        }
    }
}
