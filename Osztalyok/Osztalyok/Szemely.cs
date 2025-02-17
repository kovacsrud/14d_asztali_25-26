using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztalyok
{
    public class Szemely
    {
       public string nev;
       public int szulEv;
       public int magassag;
       public int suly;
       public string lakhely;


        public int Eletkor()
        {
            //Lekérdezzük az aktuális évet
            return DateTime.Now.Year-szulEv;
        }

    }
}
