using System.IO;
using System.Text;

namespace Fajlok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fájlok kezelése");
            
            //Ha a finally blokkban akarjuk zárni a fájlt, akkor itt kell deklarálni.
            StreamReader reader=null;
            //Fájl betöltés és beolvasás soronként
            try
            {
                FileStream file = new FileStream("hegyekMo.txt", FileMode.Open);
                reader = new StreamReader(file, Encoding.Default);
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    Console.WriteLine(reader.ReadLine());
                }
                //reader.Close();
            }
            catch(FileNotFoundException) {
                Console.WriteLine("A fájl nem található!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                
            }

            //Fájl betöltés és beolvasás a using blokkal
            try
            {
                FileStream fajl = new FileStream("hegyek.txt",FileMode.Open);
                //A using blokk gondoskodik a fájl lezárásáról és az általa használt hely felszabasításáról is.
                using (StreamReader sr=new StreamReader(fajl,Encoding.Default))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

        }
    }
}
