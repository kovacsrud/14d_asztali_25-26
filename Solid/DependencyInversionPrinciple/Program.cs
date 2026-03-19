namespace DependencyInversionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dependency Inversion Principle (DIP)");

            //A magas szintű modulok ne függjenek alacsony szintű moduloktól. Mindkettő absztrakcióktól függjön.

            //Fixen "bedrótozott" Mysql
            var rosszUserService=new RosszUserService();

            //Nincs fix adatbázis, bármit átadhatok, ami megvalósítja az IDatabase-t
            var userService = new JoUserService(new OracleDB());
            userService.UserMentes("Béla");
        }
    }
}
