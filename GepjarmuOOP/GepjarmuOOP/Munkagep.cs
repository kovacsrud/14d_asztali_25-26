using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GepjarmuOOP
{
    public enum AlkalmazasTerulet {építőipar,fémipar,gépgyártás,anyagmozgatás };
    public class Munkagep:Gepjarmu
    {
        public AlkalmazasTerulet Alkalmazas { get; set; }
        public bool IsKozforgalom { get; set; }
    }
}
