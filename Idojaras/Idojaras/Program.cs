namespace Idojaras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IdojarasAdat> IdojarasAdatok= new List<IdojarasAdat>();
            try
            {
                IdojarasLista idojarasLista = new IdojarasLista("idojaras.csv",';');
                //Ha az első sor is fel akarom dolgozni a fájlból, akkor így példányosítok
                //IdojarasLista idojarasLista = new IdojarasLista("idojaras.csv",';',0);
                IdojarasAdatok = idojarasLista.IdojarasAdatok;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine($"Sorok száma:{IdojarasAdatok.Count}");

            //Melyik volt a legmelegebb nap?
            
            var maxHo = IdojarasAdatok.Max(y => y.Homerseklet);

            var legmelegebbNap = IdojarasAdatok.Find(x=>x.Homerseklet==maxHo);
            if (legmelegebbNap!=null)
            {
                Console.WriteLine($"A legmelegebb nap:{legmelegebbNap.Ev}.{legmelegebbNap.Honap}.{legmelegebbNap.Nap} {legmelegebbNap.Ora} - {legmelegebbNap.Homerseklet}");
            }

            //Határozzuk meg minden egyes nap átlaghőmérsékletét

            //Összesítés összetett kulccsal
            var atlaghoStat = IdojarasAdatok.ToLookup(x=>new {x.Ev,x.Honap,x.Nap});

            foreach (var i in atlaghoStat)
            {
                Console.WriteLine($"{i.Key.Ev}.{i.Key.Honap}.{i.Key.Nap} - {i.Average(x=>x.Homerseklet)} - {i.Max(x=>x.Homerseklet)} - {i.Min(x=>x.Homerseklet)}");
            }

        }
    }
}
