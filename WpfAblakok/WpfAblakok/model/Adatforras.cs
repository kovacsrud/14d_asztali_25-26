using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAblakok.model
{
    public class Adatforras
    {
        public List<Nobel> Nobeldijasok { get; set; }
        //TODO: autók listáját megvalósítani
        //TODO: drónok listáját implementálni

        public Adatforras()
        {
            Nobeldijasok = new Nobellista("nobel.csv", ';').Nobeldijasok;
        }
    }
}
