using System.Text;

namespace Telekocsi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Kocsi> kocsik=new List<Kocsi>();
            try
            {
                var sorok = File.ReadAllLines("telekocsi_autok.csv",Encoding.UTF7);

                for (int i = 1; i < sorok.Length; i++)
                {
                    kocsik.Add(new Kocsi(sorok[i],';'));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine($"Sorok száma:{kocsik.Count}");
            Console.WriteLine(kocsik[16].Indulas);

            //Kérjen be egy indulási települést a program és írja ki, hogy található-e ilyen a fájlban
            Console.Write("Adjon meg egy indulási települést!");
            string beIndulas=Console.ReadLine();

            if (kocsik.Any(x=>x.Indulas.ToLower()==beIndulas.ToLower()))
            {
                Console.WriteLine("Van ilyen indulási település!");
            } else
            {
                Console.WriteLine("Nincs ilyen indulási település!");
            }

            if (kocsik.Any(x=>x.Indulas.ToLower().Contains(beIndulas.ToLower())))
            {
                Console.WriteLine("Van ilyen indulási település!");
            } else
            {
                Console.WriteLine("Nincs ilyen indulási település!");
            }

            var mennySzerSzerepel = kocsik.FindAll(x => x.Indulas.ToLower() == beIndulas.ToLower()).Count;

            Console.WriteLine($"{beIndulas} település {mennySzerSzerepel} alkalommal szerepel kiinduló településként.");

            //Mennyiszer szerepel a bekért település a céltelepülések között?
            var mennyiSzerCel = kocsik.FindAll(x=>x.Cel.ToLower()==beIndulas.ToLower()).Count;

            Console.WriteLine($"{beIndulas} település {mennyiSzerCel} alkalommal szerepel cél településként.");

            //Készítsen statisztikát, hogy az induló települések hányszor szerepelnek a fájban.
            var stat = kocsik.ToLookup(x=>x.Indulas).OrderBy(x=>x.Key);

            foreach (var i in stat)
            {
                Console.WriteLine($"{i.Key} - {i.Count()}");
            }

            //Készítsen statisztikát, hogy a cél települések hányszor szerepelnek a fájban.

            var statCel=kocsik.ToLookup(x=>x.Cel).OrderBy(x=>x.Key);
            Console.WriteLine("=========================================");

            foreach(var i in statCel)
            {
                Console.WriteLine($"{i.Key} - {i.Count()}");
            }

            //Kérjünk be egy betűt, az ezzel kezdődő rendszámú autóakat tartalmazó adatokat írjuk fájlba!
            Console.Write("Adjon meg egy betűt!:");
            char betu = Console.ReadKey().KeyChar;

            var szures = kocsik.FindAll(x=>x.Rendszam.StartsWith(betu));

            if (szures.Count() > 0)
            {
                try
                {
                    FileStream fajl = new FileStream("rendszamok.txt",FileMode.Create);

                    using (StreamWriter writer = new StreamWriter(fajl, Encoding.Default))
                    {
                        writer.WriteLine($"Indulás;Cél;Rendszám;Telefonszám;Féröhely");

                        foreach (var i in szures)
                        {
                            writer.WriteLine($"{i.Indulas};{i.Cel};{i.Rendszam};{i.Telefonszam};{i.Ferohely}");
                        }
                    }
                    Console.WriteLine("Fájlba írás kész!");
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);                    
                }
            } else
            {
                Console.WriteLine("Nincs ilyen rendszám!");
            }


        }
    }
}
