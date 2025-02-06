namespace Adatbekeres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adatbekérés");
            int[] evSzamok=new int[5];

            //Írjunk adatbekérést, amellyel a tömböt feltöltjük. Csak 1973 és 1999 közötti értékeket fogadjunk el. Ha nem jó
            //a bevitt érték, akkor adjunk hibajelzést és kérjük be újra.


            for (int i = 0; i < evSzamok.Length; i++)
            {
                

                Console.Write((i+1)+". Adjon meg egy évszámot 1973 és 1999 között!");
                int beEvszam = Convert.ToInt32(Console.ReadLine());
                while (beEvszam > 1999 || beEvszam<1973 || evSzamok.Contains(beEvszam)) {
                    Console.Write((i+1)+". Hibás érték! Adja meg újra:");
                    beEvszam = Convert.ToInt32(Console.ReadLine());

                }
                evSzamok[i] = beEvszam;

            }

            for (int i = 0; i < evSzamok.Length; i++)
            {
                Console.Write(evSzamok[i]+" ");
            }




        }
    }
}
