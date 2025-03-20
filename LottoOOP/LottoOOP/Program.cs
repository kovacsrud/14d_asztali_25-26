namespace LottoOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hány számmal játszunk?");
            int hanySzam=Convert.ToInt32(Console.ReadLine());
            Console.Write("Hány számból húzunk?");
            int osszSzam= Convert.ToInt32(Console.ReadLine());

            Lottojatek lotto = new Lottojatek(hanySzam,osszSzam);
            Lottojatek masiklotto = new Lottojatek(hanySzam,osszSzam);
            
           

        }
    }
}
