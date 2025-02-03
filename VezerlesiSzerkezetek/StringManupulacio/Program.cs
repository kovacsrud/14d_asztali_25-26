namespace StringManupulacio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string szoveg = "Hello World";

            for (int i = 0; i < szoveg.Length; i++)
            {
                Console.WriteLine(szoveg[i]);
                if (szoveg[i] == 'l')
                {
                    //nem lehet módosítani a stringet
                    //szoveg[i]=Char.ToUpper(szoveg[i]);
                }
            }

            char[] szovegChars=szoveg.ToCharArray();

            for (int i = 0; i < szovegChars.Length; i++)
            {
                if (szovegChars[i]=='l')
                {
                    szovegChars[i] = Char.ToUpper(szovegChars[i]);
                }
            }

            Console.WriteLine(szovegChars);

            szoveg = new string(szovegChars);

            Console.WriteLine(szoveg);

            string modositando = "ValAmi, BáRmi, AkáRmi";

            //írjon ciklust, amely a stringben a nagybetűst kisbetűsre, a kisbetűst pedig nagybetűsre cseréli

            char[] modositandoCh=modositando.ToCharArray();
            for (int i = 0; i < modositandoCh.Length; i++)
            {
                if (Char.IsLower(modositandoCh[i]))
                {
                    modositandoCh[i] = Char.ToUpper(modositandoCh[i]);
                } else
                {
                    modositandoCh[i]=Char.ToLower(modositandoCh[i]);
                }
            }

            Console.WriteLine(modositandoCh);

            //Írjon programot, amely meghatározza a szövegben található számjegyek összegét!

            string szovegEsSzam = "Ebben az 1 szövegben 2 vannak számok 4";

            char[] szovegEsSzamChar=szovegEsSzam.ToCharArray();

            int osszeg = 0;

            for (int i = 0; i < szovegEsSzamChar.Length; i++)
            {
                if (Char.IsNumber(szovegEsSzamChar[i]))
                {
                    osszeg += (int)Char.GetNumericValue(szovegEsSzamChar[i]);
                }
            }

            Console.WriteLine($"Az összeg:{osszeg}");
        }
    }
}
