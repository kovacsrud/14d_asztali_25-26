namespace Interfesz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ISikidom> sikidomok=new List<ISikidom>();
            sikidomok.Add(new Kor(11));
            sikidomok.Add(new Kor(26));
            sikidomok.Add(new Kor(33.45));
            sikidomok.Add(new Teglalap(11,26));
            sikidomok.Add(new Teglalap(12, 36));
            sikidomok.Add(new Teglalap(21, 49));

            //Mennyi a síkidomok összes kerülete/területe?
            var osszKerulet = sikidomok.Sum(x=>x.Kerulet());
            
            var osszTerulet = sikidomok.Sum(x=>x.Terulet());

            Console.WriteLine($"Össz.kerület:{osszKerulet:F2}, össz.terület:{osszTerulet:0.00}");

            var korokKerulete = sikidomok.FindAll(x=>x.GetType()==typeof(Kor)).Sum(x=>x.Kerulet());
            Console.WriteLine($"Körök összkerülete:{korokKerulete:F3}");
            var korokTerulete = sikidomok.FindAll(x => x.GetType() == typeof(Kor)).Sum(x=>x.Terulet());
            Console.WriteLine($"Körök összterülete:{korokTerulete:F3}");

            foreach (var i in sikidomok)
            {
                if (i.GetType()==typeof(Kor))
                {
                    Kor kor = (Kor)i;
                    Console.WriteLine($"A kör sugara:{kor.Sugar:F2}, kerülete:{kor.Kerulet():F2}, területe:{kor.Terulet():F2}");

                }
                if (i.GetType()==typeof(Teglalap))
                {
                    Teglalap t = (Teglalap)i;
                    Console.WriteLine($"A téglalap A oldala:{t.AOldal}, B oldala:{t.BOldal}, kerülete: {t.Kerulet()}, területe: {t.Terulet()}");
                }
            }


        }
    }

}
