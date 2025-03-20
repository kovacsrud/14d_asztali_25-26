using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoOOP
{
    public class Lottojatek
    {
        private int hanySzam;
        private int osszSzam;
        private List<int> tippek=new List<int>();
        private List<int> nyeroSzamok=new List<int>();
        private List<int> sorsoloGomb=new List<int>();

        private int talalat;
        Random random = new Random();

        public Lottojatek(int hanySzam,int osszSzam)
        {
            this.hanySzam = hanySzam;
            this.osszSzam = osszSzam;
            Gombfeltoltes();
            Jatek();
        }

        private void Jatek()
        {
            Tippeles();
            Sorsolas();
            Console.WriteLine($"Találatok száma:{Talalatok()}");
        }

        private void Tippeles()
        {
            for (int i = 0; i < hanySzam; i++)
            {
                Console.Write($"{i+1}.tipp:");
                int temp=Convert.ToInt32(Console.ReadLine());
                while (temp<1 || temp>osszSzam || tippek.Contains(temp))
                {
                    Console.Write($"Hibás tipp, újra!{i+1}:");
                    temp=Convert.ToInt32(Console.ReadLine());
                }
                tippek.Add(temp);
            }
            tippek.Sort();
            Lista(tippek);

        }
        private void Sorsolas()
        {
            for (int i = 0; i < hanySzam; i++)
            {
                int kivalasztott = sorsoloGomb[random.Next(0,sorsoloGomb.Count)];
                nyeroSzamok.Add(kivalasztott);
                sorsoloGomb.Remove(kivalasztott);
            }
            nyeroSzamok.Sort();
            Lista(nyeroSzamok);
        }
        private int Talalatok()
        {
            for (int i = 0; i < tippek.Count; i++)
            {
                if (nyeroSzamok.Contains(tippek[i]))
                {
                    talalat++;
                }
            }
            return talalat;
        }

        private void Lista(List<int> lista)
        {
            Console.WriteLine();
            foreach (int i in lista)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }
              

        private void Gombfeltoltes()
        {
            for (int i = 0; i < osszSzam; i++)
            {
                sorsoloGomb.Add(i+1);                
            }
        }
    }
}
