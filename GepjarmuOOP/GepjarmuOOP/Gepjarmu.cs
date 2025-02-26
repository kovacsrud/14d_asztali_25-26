using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GepjarmuOOP
{
    public enum Eroforrasok {benzin,diesel,elektromos,CNG};
    public class Gepjarmu
    {
        public Eroforrasok Eroforras { get; set; }
        public int Tomeg { get; set; }
        public int Hossz { get; set; }
        public int MaxSebesseg { get; set; }
    }
}
