namespace Valtozok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Változók a C# nyelvben");

            //A C# erősen típusos nyelv. Minden változóhoz meg kell adnunk a változó típusát

            //Egész számok. A típusok közötti különbséget az jelenti, hogy mekkora méretű adatot képesek tárolni.

            //Byte 8-bit, előjel nélkül

            byte bajt = 14;

            Console.WriteLine(Convert.ToString(bajt,2).PadLeft(8,'0'));
            Console.WriteLine($"Min:{Byte.MinValue},Max:{Byte.MaxValue}");


            //short 16bit, előjeles, előjel nélküli
            short bajtok = -3455;
            Console.WriteLine(Convert.ToString(bajtok, 2).PadLeft(16, '0'));
            Console.WriteLine($"Min:{short.MinValue},Max:{short.MaxValue}");

            ushort bajtok2 = 65535;
            Console.WriteLine(Convert.ToString(bajtok2, 2).PadLeft(16, '0'));
            Console.WriteLine($"Min:{ushort.MinValue},Max:{ushort.MaxValue}");

            int simaEgeszElojeles = 34556;
            Console.WriteLine($"Min:{int.MinValue},Max:{int.MaxValue}");
            Console.WriteLine(Convert.ToString(simaEgeszElojeles, 2).PadLeft(32, '0'));

            uint simaEgeszElojelnelkul = 145667;
            Console.WriteLine($"Min:{uint.MinValue},Max:{uint.MaxValue}");
            Console.WriteLine(Convert.ToString(simaEgeszElojelnelkul, 2).PadLeft(32, '0'));

            long hosszuElojeles = 232342342343244444;
            Console.WriteLine($"Min:{long.MinValue},Max:{long.MaxValue}");
            ulong hosszuElojelnelkuli = 2344324234234242342;
            Console.WriteLine($"Min:{ulong.MinValue},Max:{ulong.MaxValue}");

            Int128 int128 = 33324332442343;
            Console.WriteLine($"Min:{Int128.MinValue},Max:{Int128.MaxValue}");
            UInt128 uint128 = 4947234923797429;
            Console.WriteLine($"Min:{UInt128.MinValue},Max:{UInt128.MaxValue}");


            //Nem egész (lebegőpontos)

            //Egyszeres pontosságú
            float nemEgeszFloat=124.123456789012345678901234567890f;

            //Kétszeres pontosságú
            double nemEgeszDouble = 124.123456789012345678901234567890;

            //Decimális

            decimal nemEgeszDecimal = 124.123456789012345678901234567890m;

            Console.WriteLine(nemEgeszFloat);
            Console.WriteLine(nemEgeszDouble);
            Console.WriteLine(nemEgeszDecimal);

            //Logikai

            bool logikai = false;

            //Karakter, egyetlen karaktert tud tárolni. Betű, szám, írásjel, spec. karakter.

            char karakter = 'C';

            //Szöveg típus
            string szoveg = "Valami, bármi, akármi.";

            Console.WriteLine(szoveg.Length);



            Console.ReadKey();

            

        }
    }
}
