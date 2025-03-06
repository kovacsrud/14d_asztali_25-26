using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EUcsatlakozas
{
    public class Orszag
    {
        public string OrszagNev { get; set; }
        public DateTime CsatlakozasDatum { get; set; }

        public Orszag(string sor,char hatarolo)
        {
            var adatok = sor.Split(hatarolo);
            OrszagNev = adatok[0];
            CsatlakozasDatum=Convert.ToDateTime(adatok[1]);
        }

    }
}
