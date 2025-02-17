using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztalyok
{
    public class Tanulo2
    {
        //Property: 3 az 1-ben =>változó, beállító függvény, lekérdező függvény
        public string Nev { get; set; }

        private int szulev;
        public int SzulEv { 
            get {
                return DateTime.Now.Year -szulev;
            }
            set
            {
                if (value>DateTime.Now.Year || value<1910)
                {
                    throw new ArgumentException("Hibás születési év!");
                } else
                {
                    szulev = value;
                }
            }
        }
        public int Magassag { get; set; }
        public int Suly { get; set; }
        public string Lakhely { get; set; }


    }
}
