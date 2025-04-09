using KRHash;

namespace HashTeszt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateHash hash = new CreateHash();

            string szoveg = "Valami szöveg";
            string szovegHash = hash.MakeHash(HashType.MD5, szoveg);

            Console.WriteLine(szoveg);
            Console.WriteLine(szovegHash);
        }
    }
}
