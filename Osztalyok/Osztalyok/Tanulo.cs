using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztalyok
{
    public class Tanulo
    {
        private string nev;
        private int szulEv;
        private int magassag;
        private int suly;
        private string lakhely;

        //Konstruktor: Automatikusan végrehajtódik, amikor az osztályt példányosítják
        //A konstruktornak nincs visszatérési értéke és nem is void és a nevének meg kell egyeznie az osztály nevével

        public Tanulo()
        {
            
        }

        public Tanulo(string lakhely)
        {
            this.lakhely = lakhely;
        }

        public Tanulo(string nev, int szulEv, int magassag, int suly, string lakhely)
        {
            this.nev = nev;
            this.szulEv = szulEv;
            this.magassag = magassag;
            this.suly = suly;
            this.lakhely = lakhely;
        }

        public int Eletkor()
        {
            //Lekérdezzük az aktuális évet
            return DateTime.Now.Year - szulEv;
        }

        public void SetNev(string nev)
        {
            if (nev.Length<3 ) {
                throw new ArgumentException("Túl rövid a név!");
            } else
            {
                this.nev = nev;
            }
            
        }

        public string GetNev() {
            return nev;
        }
    }
}
