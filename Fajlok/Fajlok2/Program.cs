using System.IO;
using System.Text;

namespace Fajlok2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fájlok kezelése 2.");
            try
            {
                var hegyek = File.ReadAllLines("hegyekMo.txt",Encoding.Default);

                for (int i = 1; i < hegyek.Length; i++)
                {
                    Console.WriteLine(hegyek[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine("===================================================");

            //Fájl beolvasása egyetlen változóba,try catch nélkül
            string hegyFajl = "";

            if (File.Exists("hegyekMo.txt"))
            {
                hegyFajl = File.ReadAllText("hegyekMo.txt");
            } else
            {
                Console.WriteLine("A fájl nem található");
            }

            Console.WriteLine(hegyFajl);


        }
    }
}
