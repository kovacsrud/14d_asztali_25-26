using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OroklodesAbstract
{
    public class Tanulo:Ember
    {
        public int Evfolyam { get; set; }

        public override void Alszik()
        {
            Console.WriteLine("A tanuló keveset alszik");
        }

        public override void Eszik()
        {
            Console.WriteLine("A tanuló sokat eszik egészségtelen dolgokat.");
        }

        public override void Iszik()
        {
            Console.WriteLine("A tanuló sok energiaitalt iszik.");
        }

        public override void Mozog()
        {
            Console.WriteLine("A tanuló keveset mozog");
        }
    }
}
