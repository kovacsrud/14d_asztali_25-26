using ListaOsztallyal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes
{
    public class Dolgozo : Szemely
    {

        //base =>az ős osztály valamelyik metódusának hívása
        public Dolgozo(string vezeteknev, string keresztnev, string szulHely, int eletkor, int magassag, int suly,string munkahely,int havifizetes) : base(vezeteknev, keresztnev, szulHely, eletkor, magassag, suly)
        {
        }

        public Dolgozo()
        {
            Console.WriteLine("Dolgozó osztály konstruktora");
        }

        public string Munkahely { get; set; }
        public int HaviFizetes { get; set; }

        public int EvesFizetes()
        {
            return HaviFizetes*12;
        }

        public override void Mozog()
        {
            Console.WriteLine("A dolgozó célirányosan mozog.");
        }
    }
}
