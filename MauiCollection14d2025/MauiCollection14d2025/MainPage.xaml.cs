using System.Collections.ObjectModel;

namespace MauiCollection14d2025
{
    public partial class MainPage : ContentPage
    {
       
        ObservableCollection<Hegy> Hegyek {  get; set; }=new ObservableCollection<Hegy>();

        public MainPage()
        {
            InitializeComponent();
        }


        async Task LoadMauiAsset()
        {
            using var stream = await FileSystem.OpenAppPackageFileAsync("hegyekMo.txt");
            using var reader = new StreamReader(stream);
            reader.ReadLine();
            while (!reader.EndOfStream) {
                Hegyek.Add(new Hegy(reader.ReadLine()));
            }
        }

      
    }

}
