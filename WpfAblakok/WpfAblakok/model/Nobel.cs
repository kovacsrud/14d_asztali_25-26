using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAblakok.model
{
    public class Nobel
    {
        public int Ev { get; set; }
        public string Tipus { get; set; }
        public string Vezeteknev { get; set; }
        public string Keresztnev { get; set; }

        public Nobel(string sor,char hatarolo)
        {
            var adatok = sor.Split(hatarolo);
            Ev = Convert.ToInt32(adatok[0]);
            Tipus = adatok[1];
            Vezeteknev= adatok[2]; 
            Keresztnev = adatok[3];
        }
    }
}
