using System.Text;

namespace FajlFeldolgozas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fájl feldolgozás");
            List<Hegy> hegyek=new List<Hegy>();
            try
            {
                var sorok = File.ReadAllLines("hegyekMo.txt",Encoding.Default);

                for (int i = 1; i < sorok.Length; i++)
                {
                    hegyek.Add(new Hegy(sorok[i], ';'));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine($"Sorok száma:{hegyek.Count}");
            //A Mátra hegycsúcsai
            var matra = hegyek.FindAll(x=>x.Hegyseg=="Mátra");
                        

            try
            {
                FileStream fajl = new FileStream("matra.txt",FileMode.Create);                

                using (StreamWriter writer = new StreamWriter(fajl, Encoding.Default))
                {
                    writer.WriteLine("Hegycsúcs neve;Hegység;Magasság");

                    foreach (var i in matra)
                    {
                        writer.WriteLine($"{i.HegycsucsNeve};{i.Hegyseg};{i.Magassag}");
                    }
                }
                
                
                Console.WriteLine("Fájl kiírva!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }



        }
    }
}
