using System.Text;

namespace Maratonvalto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maratonváltó");
            List<Eredmeny> eredmenyek = new List<Eredmeny>();

            try
            {
                eredmenyek = LoadData.LoadFromCsv("maratonvalto.csv");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);                
            }
            finally
            {
                Console.WriteLine($"Sorok száma:{eredmenyek.Count}");
            }

            Console.WriteLine($"6.feladat:{eredmenyek.Average(x=>x.Ido)}");

            var gyorsak = eredmenyek.FindAll(x => x.Ido / 60<=30);

            try
            {
                FileStream fajl = new FileStream("gyorsak.txt",FileMode.Create);
                using (StreamWriter writer=new StreamWriter(fajl,Encoding.UTF8))
                {
                    foreach (var i in gyorsak)
                    {
                        writer.WriteLine($"{i.Versenyzo.Fid} {i.Versenyzo.Fnev} {i.Ido}");
                    }
                }
                Console.WriteLine("Fájlba írás kész!");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            //Csapatonként

            var csapatstat = eredmenyek.ToLookup(x=>x.Versenyzo.Csapat).OrderBy(x=>x.Sum(y=>y.Ido));

            var gyoztescsapatId = csapatstat.First().Key;

            Console.WriteLine(gyoztescsapatId);

            var gyoztescsapat = eredmenyek.FindAll(x=>x.Versenyzo.Csapat==gyoztescsapatId);

            var gyoztesCsapatIdeje = gyoztescsapat.Sum(x=>x.Ido);

            Console.WriteLine($"Győztes csapat ideje:{gyoztesCsapatIdeje}");

            foreach (var i in gyoztescsapat)
            {
                Console.WriteLine($"{i.Versenyzo.Fnev}");
            }

            

            


        }
    }
}
