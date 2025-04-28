using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAblakok.model
{
    public class Nobellista
    {
        public List<Nobel> Nobeldijasok { get; set; } = new List<Nobel>();

        public Nobellista(string fajl,char hatarolo,int start=1)
        {
            var adatok = File.ReadAllLines(fajl, Encoding.Default);

            for (int i = start; i < adatok.Length; i++)
            {
                Nobeldijasok.Add(new Nobel(adatok[i], hatarolo));
            }

        }
    }
}
