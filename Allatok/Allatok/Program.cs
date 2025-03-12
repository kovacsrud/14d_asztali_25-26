namespace Allatok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Allat> allatok = new List<Allat>();

            allatok.Add(new Emlos("B","mókus",2,true));
            allatok.Add(new Emlos("C", "róka", 3, true));
            allatok.Add(new Hullo("D", "python", 2, false));
            allatok.Add(new Hullo("E", "vipera", 4, true));
            allatok.Add(new Madar("F", "kolibri", 2, 20));
            allatok.Add(new Madar("G", "pelikán", 3, 140));

            foreach (var i in allatok)
            {
                if (i.GetType()==typeof(Emlos))
                {
                    Emlos emlos = (Emlos)i;
                    Console.WriteLine(emlos.IsSzoros);
                }
            }

        }
    }
}
