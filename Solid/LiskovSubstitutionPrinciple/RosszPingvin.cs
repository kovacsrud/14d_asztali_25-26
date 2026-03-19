using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public class RosszPingvin : RosszMadar
    {
        public override void Eszik()
        {
            Console.WriteLine("A pingvin eszik.");
        }

        public override void Repul()
        {
            //??? A pingvin nem repül
            throw new NotImplementedException();
        }
    }
}
