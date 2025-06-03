using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfLampa;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        Rajzolas();
    }

    private async Task Rajzolas()
    {
        int lampaSzelesseg = 100;
        int lampaMagassag = 100;
        int kozep = (int)canvasLampa.Width / 2;
        int koz = 5;
        SolidColorBrush pirosLampaSzin = Brushes.Red;
        SolidColorBrush sargaLampaSzin = Brushes.Yellow;
        SolidColorBrush zoldLampaSzin = Brushes.Green;
        SolidColorBrush feketeLampaSzin = Brushes.Black;

        Ellipse pirosLampa = new Ellipse
        {
            Width = lampaSzelesseg,
            Height = lampaMagassag,
            Fill = pirosLampaSzin
        };
        Canvas.SetLeft(pirosLampa,kozep-(pirosLampa.Width/2));
        Canvas.SetTop(pirosLampa, 10);
        canvasLampa.Children.Add(pirosLampa);


        Ellipse sargaLampa = new Ellipse
        {
            Width = lampaSzelesseg,
            Height = lampaMagassag,
            Fill = feketeLampaSzin
        };

        Canvas.SetLeft(sargaLampa, kozep - (sargaLampa.Width/2));
        Canvas.SetTop(sargaLampa,10+koz+sargaLampa.Height);
        canvasLampa.Children.Add(sargaLampa);

        Ellipse zoldLampa = new Ellipse
        {
            Width=lampaSzelesseg,
            Height=lampaMagassag,
            Fill = feketeLampaSzin
        };

        Canvas.SetLeft(zoldLampa, kozep - (zoldLampa.Width / 2));
        Canvas.SetTop(zoldLampa, 10 + koz + sargaLampa.Height + koz + zoldLampa.Height);
        canvasLampa.Children.Add(zoldLampa);

        //Thread.Sleep(15000); //Blokkolja a program fő szálát, tehát az ablak nem tud megjelenni :(

        await Task.Delay(10000);
        sargaLampa.Fill = sargaLampaSzin;
        await Task.Delay(1000);
        pirosLampa.Fill = feketeLampaSzin;
        sargaLampa.Fill = feketeLampaSzin;
        zoldLampa.Fill = zoldLampaSzin;
        await Task.Delay(5000);
        zoldLampa.Fill = feketeLampaSzin;
        sargaLampa.Fill = sargaLampaSzin;
        await Task.Delay(2000);
        sargaLampa.Fill = feketeLampaSzin;
        pirosLampa.Fill = pirosLampaSzin;

    }
}