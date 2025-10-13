﻿using System.IO;
using System.Windows.Media.Imaging;

namespace WpfCodeWeekCards.Mvvm.Model
{
    public class Kartya
    {
        //Kartyajel 2,3,4,5,6,7,8,9,10,J,Q,K,A
        public string KartyaJel { get; set; }

        //(Suit) Figura  1-club (treff), 2-diamond (káró), 3-heart (kőr), 4-spade (pikk)
        public int Figura { get; set; }

        //2,3,4,5,6,7,8,9,10,11,12,13,14
        public int Szamertek { get; set; }

        //1-fekete, 2-piros
        public int FeketeVagyPiros { get; set; }

        //Kártya képe
        public BitmapImage KartyaKep { get; set; }

        public Kartya()
        {
            
        }

        public Kartya(string kartyanev, byte[] kepadat)
        {
            var kartyaAdatok = kartyanev.Split('_');
            KartyaJel = kartyaAdatok[0];
            Figura = Convert.ToInt32(kartyaAdatok[1]);
            Szamertek = Convert.ToInt32(kartyaAdatok[2]);
            FeketeVagyPiros = Convert.ToInt32(kartyaAdatok[3]);
            KartyaKep = GetKartyaImage(kepadat);
        }

        private BitmapImage GetKartyaImage(byte[] kepadat)
        {
            using (MemoryStream ms=new MemoryStream(kepadat))
            {
                var image=new BitmapImage();
                image.BeginInit();
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.StreamSource = ms;
                image.EndInit();

                return image;
            }
        }
    }
}
