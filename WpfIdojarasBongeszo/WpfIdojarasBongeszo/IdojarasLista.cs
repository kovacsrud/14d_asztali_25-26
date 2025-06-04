using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfIdojarasBongeszo
{
    public class IdojarasLista
    {
        public List<Idojaras> IdojarasAdatok { get; set; } = new List<Idojaras>();

        public IdojarasLista(string fajl,char hatarolo,int start=1)
        {

            var sorok = File.ReadAllLines(fajl);

            for (int i = start; i < sorok.Length; i++) {
                IdojarasAdatok.Add(new Idojaras(sorok[i], hatarolo));
            }
            
        }
    }
}
