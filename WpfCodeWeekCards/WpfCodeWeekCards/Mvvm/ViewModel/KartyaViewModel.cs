using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using PropertyChanged;
using WpfCodeWeekCards.Mvvm.Model;

namespace WpfCodeWeekCards.Mvvm.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class KartyaViewModel
    {
        public List<Kartya> Pakli { get; set; }= new List<Kartya>();
        public Kartya SelectedKartya { get; set; } = new Kartya();
        public int Kassza { get; set; } = 1000;
        public int Tet { get; set; } = 10;

        ResourceManager rm = new ResourceManager("WpfCodeWeekCards.Kartyak",Assembly.GetExecutingAssembly());

        public KartyaViewModel()
        {
            ResourceSet rs = rm.GetResourceSet(System.Globalization.CultureInfo.CurrentCulture,true,true);

            foreach (System.Collections.DictionaryEntry kartya in rs)
            {
                string kartyanev = kartya.Key.ToString();
                var kartyakepBin = (byte[])kartya.Value;

                Pakli.Add(new Kartya(kartyanev,kartyakepBin));
            }

        }

        public Kartya GetRandomKartya()
        {
            Kartya kartya = new Kartya();
            Random rnd = new Random();

            if (Pakli.Count > 0)
            {
                var veletlenSzam=rnd.Next(0,Pakli.Count);
                kartya = Pakli[veletlenSzam];
                Pakli.RemoveAt(veletlenSzam);
            } else
            {
                MessageBox.Show("Elfogytak a kártyák!");
            }


                return kartya;
        }

    }
}
