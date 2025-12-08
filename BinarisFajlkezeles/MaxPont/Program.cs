using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;

namespace MaxPont
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Van egy játékunk, amely tárolja a legtöbb pontot amit a játékos elért.
            //Oldjuk meg azt, hogy a pontszám legyen eltárolva háttértáron és ne lehessen könnyen manipulálni
            //illetve ha manipulálták a pontszámot, akkor erről adjon jelzést a program és állítsa 0-ra a 
            //max pontszámot

            SHA256 sha256 = SHA256.Create();

            int maxPontszam = 3488;
            

            //Ez így könnyen manipulálható
            File.WriteAllText("max.txt",maxPontszam.ToString());

            var maxPontszamBin=BitConverter.GetBytes(maxPontszam);
            //hash érték generálása
            byte[] maxPontSzamHash = sha256.ComputeHash(maxPontszamBin);

            Console.WriteLine($"SHA256 összeg hossza:{maxPontSzamHash.Length}");
            Console.WriteLine($"Maxpontszambin hossza:{maxPontszamBin.Length}");

            

            //A szám már nem lesz olvasható, de a fájl tartalma továbbra is manipulálható
            File.WriteAllBytes("maxbin.txt",maxPontszamBin);

            var vissza = File.ReadAllBytes("maxbin.txt");

            Console.WriteLine($"Vissza:{BitConverter.ToInt32(vissza)}");

            //Hogyan lehet ellenőrizni? - Ellenőrző összeg használata

            //Fájl formátum: 32 byte ellenőrző összeg, 4 byte adat

            var kiirando = new byte[maxPontSzamHash.Length+maxPontszamBin.Length];

            using (MemoryStream ms=new MemoryStream(kiirando))
            {
                using (BinaryWriter writer=new BinaryWriter(ms))
                {
                    writer.Write(maxPontSzamHash);
                    writer.Write(maxPontszamBin);
                }
                File.WriteAllBytes("record.txt",kiirando);
                Console.WriteLine("Fájl kiírva");
            }


            var rekordAdatok = File.ReadAllBytes("record.txt");

            Console.WriteLine($"Hossz:{rekordAdatok.Length} byte");

            byte[] rekordHash;
            byte[] rekordErtek;

            using (MemoryStream ms=new MemoryStream(rekordAdatok))
            {
                using (BinaryReader reader=new BinaryReader(ms))
                {
                    rekordHash = reader.ReadBytes(32);
                    rekordErtek=reader.ReadBytes(4);
                }
            }


            byte[] ellenorzoHash=sha256.ComputeHash(rekordErtek);

            if (Encoding.UTF8.GetString(rekordHash)==Encoding.UTF8.GetString(ellenorzoHash))
            {
                Console.WriteLine($"Az érték megfelelő:{BitConverter.ToInt32(rekordErtek)}");
            } else
            {
                Console.WriteLine("A rekord értékét manipulálták!");
            }



        }
    }
}
