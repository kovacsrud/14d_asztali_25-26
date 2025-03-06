using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FajlFeldolgozas
{
    public class Hegy
    {
        public string HegycsucsNeve { get; set; }
        public string Hegyseg { get; set; }
        public int Magassag { get; set; }

        public Hegy(string sor,char hatarolo)
        {
            var adatok=sor.Split(hatarolo);
            HegycsucsNeve = adatok[0];
            Hegyseg = adatok[1];
            Magassag = Convert.ToInt32(adatok[2]);
        }
    }
}
