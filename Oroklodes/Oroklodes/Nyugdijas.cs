using ListaOsztallyal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes
{
    public class Nyugdijas:Szemely
    {
        public int Nyugdij { get; set; }
        public int MikorMentNyugdijba { get; set; }

        public override void Mozog()
        {
            Console.WriteLine("A nyugdíjas lassan mozog.");
        }

        public override string ToString()
        {
            return base.ToString()+$" Nyugdíja:{Nyugdij}"+$" Mikor ment nyugdíjba:{MikorMentNyugdijba}";
        }

    }
}
