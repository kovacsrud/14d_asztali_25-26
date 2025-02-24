using ListaOsztallyal;
using System.Security.Cryptography.X509Certificates;

namespace Oroklodes
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Dolgozo dolgozo = new Dolgozo
            {
                Vezeteknev = "Nagy",
                Keresztnev = "István",
                Eletkor = 26,
                SzulHely = "Szolnok",
                Munkahely = "Csőd.Zrt",
                HaviFizetes = 340000,
                Magassag = 178,
                Suly = 76
            };

            //Dolgozo dolgozo2 = new Dolgozo("Korcsok", "Béla", "Gyula", 34, 182, 78, "Csőd Zrt.", 312000);

            Console.WriteLine(dolgozo.SzulEv);
            Console.WriteLine(dolgozo.EvesFizetes());

            dolgozo.Mozog();

            Nyugdijas nyugdijas= new Nyugdijas {
                Eletkor=78,
                Vezeteknev="Kereszti",
                Keresztnev="András",
                SzulHely="Szeged",
                Magassag=176,
                MikorMentNyugdijba=2014,
                Nyugdij=250000,
                Suly=89
            };

            nyugdijas.Mozog();

            Console.WriteLine(dolgozo.ToString());
            Console.WriteLine(nyugdijas.ToString());

            //Készítsenek egy Sportolo osztályt
            //Sportag
            //TestZsirSzazalek
            //Felülírni a Mozog() metódust
            //Készítsen egy Sportol() metódust
            
        }
    }
}
