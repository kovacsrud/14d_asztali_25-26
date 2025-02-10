namespace Listak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Listák használata");

            List<string> nevek = new List<string>();

            //Új elem hozzáadása a listához:
            nevek.Add("Ubul");
            nevek.Add("Ella");
            nevek.Add("Péter");
            nevek.Add("Géza");

            Console.WriteLine($"A lista hossza:{nevek.Count}");

            //A lista elemei ugyanúgy indexelhetők, mint a tömb elemei
            Console.WriteLine(nevek[0]); ;

            //Lista bejárása for ciklussal
            Nevlista(nevek);

            //Lista bejárása foreach ciklussal
            NevlistaForeach(nevek);

            //A listáról törölhetünk elemet
            nevek.Remove("Péter");

            //Törlés a listáról index alapján
            nevek.RemoveAt(2);

            Nevlista(nevek);

            Console.WriteLine(nevek.Count);

            List<string> masikNevek = new List<string>() { "János", "Zalán", "Júlia" };

            Nevlista(masikNevek);

            //Lista hozzáadása egy másik listához
            masikNevek.AddRange(nevek);

            Nevlista(masikNevek);

            masikNevek.Clear();

            Console.WriteLine(masikNevek.Count);



      
            


        }

        private static void NevlistaForeach(List<string> nevek)
        {
            foreach (var i in nevek)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        private static void Nevlista(List<string> nevek)
        {
            for (int i = 0; i < nevek.Count; i++)
            {
                Console.Write(nevek[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
