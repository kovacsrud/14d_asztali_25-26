namespace OroklodesAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Sportolo sportolo = new Sportolo {
                Nev="Ubul",
                Magassag=181,
                Sportag="atlétika",
                Suly=76,
                SzuletesiEv=2004
            };

            Tanulo tanulo = new Tanulo {
                Nev="Alex",
                SzuletesiEv=2006,
                Evfolyam=5,
                Magassag=177,
                Suly=68
            };

            List<Sportolo> sportolok = new List<Sportolo>();
            List<Tanulo> tanulok = new List<Tanulo>();
            List<Ember> emberek = new List<Ember>();

            sportolok.Add(sportolo);
            tanulok.Add(tanulo);

            emberek.Add(sportolo);
            emberek.Add(tanulo);

            foreach (var i in emberek)
            {
                if(i.GetType() == typeof(Sportolo))
                {
                    Sportolo sporTolo= (Sportolo)i;
                    Console.WriteLine($"{sporTolo.Sportag}");
                }


                //Console.WriteLine($"{i.ToString()}");
            }

        }
    }
}
