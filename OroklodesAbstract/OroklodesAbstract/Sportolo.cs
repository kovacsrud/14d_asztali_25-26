using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OroklodesAbstract
{
    public class Sportolo:Ember
    {
        public string Sportag { get; set; }

        public override void Alszik()
        {
            Console.WriteLine("A sportoló sokat alszik");
        }

        public override void Eszik()
        {
            Console.WriteLine("A sportoló sok fehérjét eszik");
        }

        public override void Iszik()
        {
            Console.WriteLine("A sportoló sportitalt iszik");
        }

        public override void Mozog()
        {
            Console.WriteLine("A sportoló sokat mozog");
        }
    }
}
