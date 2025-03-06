namespace Maradek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maradékos osztás");

            //Maradékos osztásnál arra vagyunk kíváncsiak, hogy mennyi lesz a maradék a művelet elvégzése után.
            //a maradékos osztás jele a %
            Console.WriteLine(13%6);

            int[] szamok = { 2, 33, 45, 12, 13, 78, 66, 59, 34 };

            //Minden páros helyen lévő szám

            for (int i = 0; i < szamok.Length; i++)
            {
                if (i%2==0)
                {
                    Console.Write(szamok[i]+" ");
                }
                
            }

            Console.WriteLine();
            //Írjon ciklust, amely kilistázza a 2-vel osztható számokat
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] % 2 == 0) {
                    Console.Write(szamok[i]+" ");
                }
            }
            

        }
    }
}
