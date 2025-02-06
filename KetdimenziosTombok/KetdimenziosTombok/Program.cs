namespace KetdimenziosTombok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kétdimenziós tömbök");

            //Deklaráció
            int[,] szamok2d = new int[15,20];
            //Véletlenszám generálása
            Random rnd = new Random();

            Console.WriteLine(szamok2d.GetLength(0));

            //Feltöltés adatokkal
            for (int i = 0; i < szamok2d.GetLength(0); i++)
            {
                for (int j = 0; j < szamok2d.GetLength(1); j++)
                {
                    szamok2d[i, j] = rnd.Next(10, 100);
                }
            }


            //Kiíratás
            for (int i = 0; i < szamok2d.GetLength(0); i++)
            {
                for (int j = 0; j < szamok2d.GetLength(1); j++)
                {
                    Console.Write(szamok2d[i,j]+" ");
                }
                Console.WriteLine();
            }


        }
    }
}
