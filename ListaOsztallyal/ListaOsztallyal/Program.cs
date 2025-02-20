namespace ListaOsztallyal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vezeteknevek = ["Kovács", "Kiss", "Nagy", "Zsiga", "Kósa", "Chlebnyiczki", "Szabó"];
            string[] keresztnevek = ["Elemér", "Anna", "Zoltán", "Ella", "Ákos", "Ágnes", "Janka", "Dániel"];
            string[] varosok = ["Gyula", "Orosháza", "Szeged", "Sopron", "Miskolc", "Pécs", "Baja", "Debrecen"];

            //Személy-> vezeteknev,keresztnev,szül.hely,életkor =>Összetett típust készítünk
            List<Szemely> szemelyek = new List<Szemely>();

            int adatokSzama = 200;
            Random rand = new Random();

            for (int i = 0; i < adatokSzama; i++)
            {
                Szemely szemely = new Szemely
                {
                    Vezeteknev = vezeteknevek[rand.Next(0, vezeteknevek.Length)],
                    Keresztnev = keresztnevek[rand.Next(0, keresztnevek.Length)],
                    SzulHely = varosok[rand.Next(0, varosok.Length)],
                    Eletkor = rand.Next(1, 101)

                };
                szemelyek.Add(szemely);
            }

            //foreach (var i in szemelyek)
            //{
            //    Console.WriteLine($"{i.Vezeteknev} {i.Keresztnev},{i.SzulHely},{i.SzulEv},{i.Eletkor}");
            //}
            //Adatok kiszűrése a listából
            //Szűrjük ki és jelenítsük meg a "Zsiga" vezetéknevű embereket a listából

            var zsigak = szemelyek.FindAll(x => x.Vezeteknev == "Zsiga");
            Console.WriteLine($"Zsigák száma:{zsigak.Count}");
            SzemelyLista(zsigak);

            //Van-e a listán lévők között Zsiga Anna nevű?

            var zsigaAnna = szemelyek.Find(x=>x.Vezeteknev=="Zsiga" && x.Keresztnev=="Anna");

            if (zsigaAnna == null)
            {
                Console.WriteLine("Nincs ilyen!");
            } else
            {
                Console.WriteLine($"Kora:{zsigaAnna.Eletkor}");
            }

            //Másik megoldás
            if (szemelyek.Any(x=>x.Vezeteknev=="Zsiga" && x.Keresztnev=="Anna"))
            {
                Console.WriteLine("Van ilyen nevű ember a listán.");
            } else
            {
                Console.WriteLine("Nincs ilyen nevű ember a listán.");
            }

            //Ágnesek átlag életkora
            var agnesAtlagKor = szemelyek.FindAll(x=>x.Keresztnev=="Ágnes").Average(x=>x.Eletkor);
            Console.WriteLine($"Ágnesek átlagéletkora:{agnesAtlagKor:0.00}");

            //Keressük meg a legidősebb Ágnest és írjuk ki az adatait!


            var agnesek = szemelyek.FindAll(x=>x.Keresztnev=="Ágnes");
            var maxAgnesKor=agnesek.Max(x=>x.Eletkor);

            var legidosebbAgnes = agnesek.Find(x=>x.Eletkor==maxAgnesKor);
            Console.WriteLine($"Legidősebb ágnes:{legidosebbAgnes?.Eletkor}");

            //Legidősebb Ágnes máshogy
            // ágnesek kiszűrése először

            var legidosebbAgnesV2 = agnesek.Find(x=>x.Eletkor==agnesek.Max(y=>y.Eletkor));
            Console.WriteLine($"Legidősebb ágnes:{legidosebbAgnesV2?.Eletkor}");

            //Hány éves a legfiatalabb szegedi személy?

            var szegediek = szemelyek.FindAll(x => x.SzulHely == "Szeged");

            var legfiatalabbSzegedi = szegediek.Find(x => x.Eletkor == szegediek.Min(y => y.Eletkor));
            Console.WriteLine($"A legfiatalabb szegedi:{legfiatalabbSzegedi?.Vezeteknev} {legfiatalabbSzegedi?.Keresztnev},{legfiatalabbSzegedi?.Eletkor}");

            //Listázzuk ki városonként az emberek számát!
            //Összesítések: ToLookUp()

            //Összesítés a Key azaz a SzulHely szerint növekvő sorrendbe rendezve
            var stat = szemelyek.ToLookup(x => x.SzulHely).OrderBy(x => x.Key);

            //Összesítés a megszámlálás darabszáma szerint növekvő sorrendbe rendezve
            // var stat = szemelyek.ToLookup(x=>x.SzulHely).OrderBy(x=>x.Count());

            foreach (var i in stat)
            {
                Console.WriteLine($"{i.Key},{i.Count()},Legidősebb:{i.Max(x=>x.Eletkor)}");
            }

            var stat2 = szemelyek.ToLookup(x=>new {x.Vezeteknev,x.Keresztnev }).OrderBy(x=>x.Key.Vezeteknev).ThenByDescending(x=>x.Key.Keresztnev);

            foreach(var i in stat2)
            {
                Console.WriteLine($"{i.Key.Vezeteknev} {i.Key.Keresztnev} - {i.Count()}");
            }

            //Stat az összesítés kulcsa: keresztnév,szülhely azaz az adott születési helyen hány megadott keresztnevű ember van

            var stat3 = szemelyek.ToLookup(x => new { x.SzulHely, x.Keresztnev }).OrderBy(x=>x.Key.SzulHely);

            foreach (var i in stat3)
            {
                Console.WriteLine($"{i.Key.SzulHely} {i.Key.Keresztnev} - {i.Count()}");
            }



        }

        private static void SzemelyLista(List<Szemely> lista)
        {
            foreach (var i in lista)
            {
                Console.WriteLine($"{i.Vezeteknev} {i.Keresztnev},{i.SzulHely},{i.SzulEv},{i.Eletkor}");
            }
        }
    }
}
