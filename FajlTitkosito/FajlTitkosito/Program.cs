using System.Security.Cryptography;
using System.Text;

namespace FajlTitkosito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Titkosítás");


            //Szükséges adatok
            //A titkosítandó szöveg
            //Eredeti fájlnév
            //Inicializációs vektor
            //tartalom hash
            //titkosított tartalom

            //Fájl formátuma
            //IV - 16 byte//fájlnév hossza 4byte//fájlnév - változó//tartalom hash - 32byte//tartalom hossza -4byte //titkosított tartalom -változó

            string fajlnev = "titkos.txt";
            string kulcs = "Titok_12";
            string titkositando = "Szigorúan titkos tartalom";

            //Titkosító algoritmus
            Aes aes=Aes.Create();

            //Hash
            SHA256 sha256=SHA256.Create();

            byte[] binKulcs=sha256.ComputeHash(Encoding.UTF8.GetBytes(kulcs));
            byte[] tartalomHash = sha256.ComputeHash(Encoding.UTF8.GetBytes(titkositando));
            byte[] fajlnevBin=Encoding.UTF8.GetBytes(fajlnev);
            byte[] titkositandoBin = Encoding.UTF8.GetBytes(titkositando);
            int fajlnevHossz=fajlnevBin.Length;
            aes.Key = binKulcs;
            aes.GenerateIV();

            ICryptoTransform titkosito = aes.CreateEncryptor(binKulcs, aes.IV);
            byte[] titkositott = titkosito.TransformFinalBlock(titkositandoBin,0,titkositandoBin.Length);

            string kodoltSzoveg = Encoding.UTF8.GetString(titkositott);
            int tartalomHossz = titkositott.Length;

            Console.WriteLine(kodoltSzoveg);

            var kodoltAdatok = new byte[aes.IV.Length+fajlnevHossz+fajlnevBin.Length+tartalomHash.Length+tartalomHossz+titkositott.Length];

            using (MemoryStream ms=new MemoryStream(kodoltAdatok))
            {
                using (BinaryWriter writer=new BinaryWriter(ms))
                {
                    writer.Write(aes.IV);
                    writer.Write(fajlnevHossz);
                    writer.Write(fajlnevBin);
                    writer.Write(tartalomHash);
                    writer.Write(tartalomHossz);
                    writer.Write(titkositott);
                }
                File.WriteAllBytes("titkositott.bin",kodoltAdatok);
                Console.WriteLine("Fájl kiírva");
            }



        }
    }
}
