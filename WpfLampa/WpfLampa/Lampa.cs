using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfLampa
{
    public class Lampa:Canvas
    {
        public SolidColorBrush Szin { get; set; }=Brushes.Black;

        public Lampa(int szelesseg,int magassag)
        {
            this.Width = szelesseg;
            this.Height = magassag;
            Szin = Brushes.Orange;

            Ellipse kor = new Ellipse
            {
                Width = this.Width / 3,
                Height = this.Width / 3,
                Fill = Szin
            };
            Canvas.SetLeft(kor, 10);
            Canvas.SetTop(kor, 10);
            this.Children.Add(kor);

        }

    }
}
