using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaOsztallyal
{
    public class Szemely
    {
        public string Vezeteknev { get; set; }
        public string Keresztnev { get; set; }
        public string SzulHely { get; set; }
        public int Eletkor { get; set; }
        public int SzulEv { 
            get {
                return DateTime.Now.Year - Eletkor;
            }
        }


    }
}
