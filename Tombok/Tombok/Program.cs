namespace Tombok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tömb: azonos típusú adatokat tároló adatszerkezet, melynek az elemszáma rögzített
            //A tömb referencia típus, a primitív változók érték típusok
            int[] szamok=new int[5];
            int[] szamok2 = { 123, 44, 31, 13, 788, 199 };

            //Console.WriteLine(szamok[0]);
            //Console.WriteLine(szamok2[0]);

            szamok[0] = 211;
            szamok[1] = 333;
            szamok[2] = 23;
            szamok[3] = 788;
            szamok[4] = 911;
            //szamok[5]=622; => ez hibát okozna, túlindexelés

            int[] szamok3 = szamok2;
            Console.WriteLine(szamok3[0]);
            szamok3[0] = 122;
            Console.WriteLine(szamok3[0]);
            szamok2[0] = 1215;
            Console.WriteLine(szamok3[0]);

        }
    }
}
