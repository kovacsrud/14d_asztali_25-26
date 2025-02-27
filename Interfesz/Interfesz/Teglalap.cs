using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfesz
{
    public class Teglalap:ISikidom
    {
        public double AOldal { get; }
        public double BOldal { get; }

        public Teglalap(double a,double b)
        {
            AOldal = a;
            BOldal = b;
        }

        public double Kerulet()
        {
            return 2*(AOldal + BOldal);
        }

        public double Terulet()
        {
            return AOldal * BOldal;
        }
    }
}
