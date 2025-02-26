namespace GepjarmuOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<Munkagep> munkagepek=new List<Munkagep>();
            List<Szemelyszallito> szemelyszallitok=new List<Szemelyszallito>();

            munkagepek.Add(new Munkagep {
                Alkalmazas=AlkalmazasTerulet.anyagmozgatás,
                Eroforras=Eroforrasok.diesel,
                Hossz=6,
                IsKozforgalom=true,
                MaxSebesseg=20,
                Tomeg=3500
            });
            munkagepek.Add(new Munkagep
            {
                Alkalmazas = AlkalmazasTerulet.gépgyártás,
                Eroforras = Eroforrasok.diesel,
                Hossz = 4,
                IsKozforgalom = true,
                MaxSebesseg = 20,
                Tomeg = 2500
            });

            szemelyszallitok.Add(new Szemelyszallito {
                Alvazszam="AZT00000R345",
                Motorszam="BLB66745",
                Eroforras=Eroforrasok.elektromos,
                Hossz=4,
                MaxSebesseg=180,
                SzallithatoSzemelyek=4,
                Tomeg=1400
            });

           
        }
    }
}
