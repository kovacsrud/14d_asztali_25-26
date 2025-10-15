using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using PropertyChanged;
using WpfCodeWeekCards.Mvvm.Model;

namespace WpfCodeWeekCards.Mvvm.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class KartyaViewModel
    {
        public List<Kartya> Pakli { get; set; }= new List<Kartya>();
        public List<BitmapImage> Hatterek { get; set; } = new List<BitmapImage>();
        public Kartya SelectedKartya { get; set; } = new Kartya();
        public BitmapImage SelectedHatter { get; set; } = new BitmapImage();
        public int Kassza { get; set; } = 1000;
        public int Tet { get; set; } = 100;
        public bool Jatekvege { get; set; } = false;

        ResourceManager rm = new ResourceManager("WpfCodeWeekCards.Kartyak",Assembly.GetExecutingAssembly());
        ResourceManager cardBackManager = new ResourceManager("WpfCodeWeekCards.KartyaBack",Assembly.GetExecutingAssembly());

        public KartyaViewModel()
        {
            ResourceSet rs = rm.GetResourceSet(System.Globalization.CultureInfo.CurrentCulture,true,true);

            foreach (System.Collections.DictionaryEntry kartya in rs)
            {
                string kartyanev = kartya.Key.ToString();
                var kartyakepBin = (byte[])kartya.Value;

                Pakli.Add(new Kartya(kartyanev,kartyakepBin));
            }

            ResourceSet cardBackRs = cardBackManager.GetResourceSet(System.Globalization.CultureInfo.CurrentCulture, true, true);

            foreach (System.Collections.DictionaryEntry kartya in cardBackRs)
            {
                var kartyakepBin = (byte[])kartya.Value;
                Hatterek.Add(CardUtil.GetKartyaImage(kartyakepBin));
            }

            SelectedHatter = Hatterek[1];

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
                Jatekvege = true;
                SelectedHatter = new BitmapImage();
                MessageBox.Show($"Elfogytak a kártyák! Pontszámod:{Kassza}");
                
            }


                return kartya;
        }

    }
}
