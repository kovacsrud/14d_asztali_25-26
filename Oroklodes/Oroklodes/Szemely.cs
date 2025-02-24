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
        public int Magassag { get; set; }
        public int Suly { get; set; }
        public int SzulEv
        {
            get
            {
                return DateTime.Now.Year - Eletkor;
            }
        }

        public Szemely()
        {
            Console.WriteLine("Személy osztály konstruktora");
        }


        public Szemely(string vezeteknev, string keresztnev, string szulHely, int eletkor, int magassag, int suly)
        {
            Vezeteknev = vezeteknev;
            Keresztnev = keresztnev;
            SzulHely = szulHely;
            Eletkor = eletkor;
            Magassag = magassag;
            Suly = suly;
        }

        //A virtual kulccszóval megjelölt metódusok a leszármazott osztályban felülírhatóak.
        public virtual void Mozog()
        {
            Console.WriteLine("A személy mozog");
        }

        public override string ToString()
        {
            return base.ToString()+$" Vezetéknév:{Vezeteknev} "+$"Keresztnév:{Keresztnev} "+$"Születési hely:{SzulHely}";
        }

    }
}
