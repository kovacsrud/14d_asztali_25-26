namespace VezerlesiSzerkezetek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 200;

            //elágazások
            //egyszeres, egyágú
            if (a>90)
            {
                Console.WriteLine("A nagyobb mint 90");
            }

            //egyszeres, kétágú
            if (a>=100)
            {
                Console.WriteLine("A nagyobb vagy egyenlő mint 100");
            }
            else
            {
                Console.WriteLine("A nem nagyobb vagy egyenlő mint 100");
            }

            //többszörös
            if (a<100)
            {
                Console.WriteLine("A kisebb mint 100");
            } else if (a==100)
            {
                Console.WriteLine("A 100");
            }
            else
            {
                Console.WriteLine("A nagyobb mint 100");
            }

            //többszörös elágazás, switch
            int nap = 4;
            switch (nap)
            {
                case 1:
                    Console.WriteLine("Hétfő");
                    break;
                case 2:
                    Console.WriteLine("Kedd");
                    break;
                case 3:
                    Console.WriteLine("Szerda");
                    break;
                case 4:
                    Console.WriteLine("Csütörtök");
                    break;

                default:
                    Console.WriteLine("Nem tudom milyen nap ez!");
                    break;
            }

            

        }
    }
}
