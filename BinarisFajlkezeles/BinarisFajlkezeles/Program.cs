using System.Text;

namespace BinarisFajlkezeles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var szovegFajl = File.ReadAllBytes("szinek.txt");

            foreach (var bajt in szovegFajl)
            {
                //Console.Write(bajt+" ");
                //Console.Write(Convert.ToString(bajt,2).PadLeft(8,'0')+" ");
            }

            //Console.WriteLine(Encoding.UTF8.GetString(szovegFajl));

            var zipFajl = File.ReadAllBytes("MonthyHallGame.zip");

            foreach(var bajt in zipFajl)
            {
                //Console.Write(Convert.ToString(bajt, 2).PadLeft(8, '0') + " ");
            }

            //Console.WriteLine(Encoding.UTF8.GetString(zipFajl));

            using (MemoryStream ms=new MemoryStream(zipFajl))
            {
                using (BinaryReader br=new BinaryReader(ms))
                {
                    var signature = br.ReadBytes(4);
                    Console.WriteLine($"Signature:{BitConverter.ToString(signature)}");
                    var version = br.ReadBytes(2);
                    Console.WriteLine($"Version:{BitConverter.ToUInt16(version)}");
                    var flags = br.ReadBytes(2);
                    Console.WriteLine($"Flags:{BitConverter.ToUInt16(version)}");
                    var compression= br.ReadBytes(2);
                    Console.WriteLine($"Compression:{BitConverter.ToUInt16(compression)}");
                    var modtime= br.ReadBytes(2);
                    var modtimeInt = BitConverter.ToUInt16(modtime);
                    byte seconds=(byte)((modtimeInt) & 0b_0000_0000_0000_1111);
                    Console.WriteLine($"Seconds:{seconds}");
                    byte minutes = (byte)((modtimeInt>>4) & 0b_0000_0000_0000_1111);
                    Console.WriteLine($"Minutes:{minutes}");
                    Console.WriteLine($"Mod time:{BitConverter.ToUInt16(modtime)}");
                    var moddate= br.ReadBytes(2);
                    Console.WriteLine($"Mod date:{BitConverter.ToUInt16(moddate)}");
                    var crc= br.ReadBytes(4);
                    var compressed= br.ReadBytes(4);
                    var uncompressed= br.ReadBytes(4);
                    var filenameLength = br.ReadBytes(2);
                    var extrafield= br.ReadBytes(2);
                    var filename = br.ReadBytes(BitConverter.ToInt16(filenameLength));
                    Console.WriteLine($"Filename:{Encoding.UTF8.GetString(filename)}");
                    //Hexa
                    Console.WriteLine($"Filename:{BitConverter.ToString(filename)}");

                }
            }

        }
    }
}
