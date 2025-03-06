using System.Text;
using System.Xml;

namespace EUcsatlakozas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Orszag> orszagok = new List<Orszag>();
            try
            {
                var sorok = File.ReadAllLines("EUcsatlakozas.txt",Encoding.UTF7);
                for (int i = 0; i < sorok.Length; i++)
                {
                    orszagok.Add(new Orszag(sorok[i],';'));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine($"3.feladat: EU tagállamainak száma:{orszagok.Count} db");

            var csatlakozott2007 = orszagok.FindAll(x=>x.CsatlakozasDatum.Year==2007).Count;

            Console.WriteLine($"4.feladat: 2007-ben {csatlakozott2007} ország csatlakozott.");

            var hun = orszagok.Find(x=>x.OrszagNev=="Magyarország");

            if (hun!=null)
            {
                Console.WriteLine($"5.feladat: Magyarország csatlakozásának dátuma:{hun.CsatlakozasDatum.Year}.{hun.CsatlakozasDatum.Month}.{hun.CsatlakozasDatum.Day}");
            }

            if (orszagok.Any(x=>x.CsatlakozasDatum.Month==5))
            {
                Console.WriteLine("6.feladat: Volt májusban csatlakozás!");
            } else
            {
                Console.WriteLine("6.feladat: Nem volt májusban csatlakozás!");
            }

            //foreach (var o in orszagok) {
            //    Console.WriteLine(o.OrszagNev);
            //}

            var utolsoTagallam = orszagok.FindAll(x=>x.CsatlakozasDatum==orszagok.Max(y=>y.CsatlakozasDatum));

            if (utolsoTagallam.Count>1)
            {
                Console.WriteLine("Több ilyen is van!");
            } else
            {
                Console.WriteLine($"7. feladat: Legutoljára csatlakozott ország:{utolsoTagallam.First().OrszagNev}");
            }

            //Statisztika
            var stat = orszagok.ToLookup(x=>x.CsatlakozasDatum.Year);

            foreach (var i in stat)
            {
                Console.WriteLine($"{i.Key} - {i.Count()} ország");
            }


            Console.WriteLine("==============================================");

            //Szótáras
            Dictionary<int,int> dstat = new Dictionary<int,int>();

            for (int i = 0; i < orszagok.Count; i++)
            {
                if (dstat.ContainsKey(orszagok[i].CsatlakozasDatum.Year))
                {
                    dstat[orszagok[i].CsatlakozasDatum.Year] = dstat[orszagok[i].CsatlakozasDatum.Year] + 1;

                } else
                {
                    dstat[orszagok[i].CsatlakozasDatum.Year] = 1;
                }
            }

            foreach (KeyValuePair<int,int> i in dstat)
            {
                Console.WriteLine($"{i.Key} - {i.Value} ország");
            }

        }
    }
}
