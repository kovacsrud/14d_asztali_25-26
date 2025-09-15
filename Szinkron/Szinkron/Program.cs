using System.Text;

namespace Szinkron
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Szinkronhang> szinkronhangok = new List<Szinkronhang>();

            try
            {
                szinkronhangok = SzinkronBetolt.LoadFromJson("szinkronhangok.json");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine(szinkronhangok.Count);

            //Korhatáros, nem korhatáros
            var korhataros = szinkronhangok.Count(x=>x.Film.Korhataros==true);
            var nemKorhataros = szinkronhangok.Count(x=>x.Film.Korhataros==false);
            Console.WriteLine($"Korhatáros:{korhataros},nem korhatáros:{nemKorhataros}");

            var stat = szinkronhangok.ToLookup(x=>new {x.Film.FilmAz,x.Film.Cim});

            //foreach (var i in stat)
            //{
            //    Console.WriteLine($"{i.Key.FilmAz}-{i.Key.Cim}-{i.Count()} db");
            //}

            try
            {
                FileStream fajl = new FileStream("szinkronstat.txt",FileMode.Create);

                using (StreamWriter writer=new StreamWriter(fajl,Encoding.UTF8))
                {
                    foreach (var i in stat)
                    {
                        writer.WriteLine($"{i.Key.FilmAz}-{i.Key.Cim}-{i.Count()} db");
                    }
                }
                Console.WriteLine("A szinkronstat állomány létrehozva.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.Write("Szinkronszínész neve:");
            var szineszNeve=Console.ReadLine();

            var szineszAdat = szinkronhangok.FindAll(x=>x.MagyarHang==szineszNeve);

            if (szineszAdat.Count > 0)
            {
                foreach (var i in szineszAdat)
                {
                    Console.WriteLine($"{i.Szinesz},{i.Film.Cim},{i.Szerep},{i.Film.Ev}");
                }
            } else 
            {
                Console.WriteLine("Nincs ilyen szinkronszínész az adatok között!");
            }

            Console.ReadLine();
        }
    }
}
