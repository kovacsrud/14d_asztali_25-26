using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WpfCodeWeekCards
{
    public static class CardUtil
    {
        public static BitmapImage GetKartyaImage(byte[] kepadat)
        {
            using (MemoryStream ms = new MemoryStream(kepadat))
            {
                var image = new BitmapImage();
                image.BeginInit();
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.StreamSource = ms;
                image.EndInit();

                return image;
            }
        }

    }
}
