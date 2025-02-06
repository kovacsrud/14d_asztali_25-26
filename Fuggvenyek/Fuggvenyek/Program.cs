namespace Fuggvenyek
{
    internal class Program
    {
        //Függvény -> alprogram

        //A void kulccszó jelenti azt, hogy a függvény nem ad vissza értéket
        static void Kiir()
        {
            Console.WriteLine("Függvény");
        }

        //Paraméter használata, 
        static void Kiir(string szoveg)
        {
            Console.WriteLine(szoveg);
        }

        static void Kiir(string szoveg1,string szoveg2)
        {
            Console.WriteLine(szoveg2+" "+szoveg1);
        }

        //Függvény túlterhelés (overloading)=> Ugyanazzal a névvel, de eltérő paraméterlistával deklarálunk függvényeket.

        static void Main(string[] args)
        {
            Console.WriteLine("Függvények");
            Kiir();
            Kiir();
            Kiir();
            Kiir("Valami");
            Kiir("valami", "bármi");
            
        }


    }
}
