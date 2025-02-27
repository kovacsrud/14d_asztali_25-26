using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OroklodesAbstract
{
    //Az absztrakt osztály csak örökítési célokat szolgál, nem lehet példányosítani
    public abstract class Ember
    {
        public string Nev { get; set; }
        public int Suly { get; set; }
        public int Magassag { get; set; }
        public int SzuletesiEv { get; set; }

        public int Eletkor()
        {
            return DateTime.Now.Year - SzuletesiEv;
        }
        //Eszik, iszik, mozog, alszik
        public abstract void Eszik();
        public abstract void Iszik();
        public abstract void Mozog();
        public abstract void Alszik();

        public override string ToString()
        {
            return base.ToString()+$" {Nev},{Suly},{Magassag},{SzuletesiEv}";
        }


    }
}
