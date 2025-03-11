using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idojaras
{
    public class IdojarasLista
    {
        public List<IdojarasAdat> IdojarasAdatok { get; set; } = new List<IdojarasAdat>();

        public IdojarasLista(string fajl,char hatarolo,int start=1)
        {
            //Hibakezelés?
            var sorok=File.ReadAllLines(fajl,Encoding.Default);

            for (int i = start; i < sorok.Length; i++)
            {
                IdojarasAdatok.Add(new IdojarasAdat(sorok[i], hatarolo));
            }
        }
    }
}
