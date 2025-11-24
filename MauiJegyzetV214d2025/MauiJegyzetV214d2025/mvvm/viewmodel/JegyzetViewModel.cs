using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MauiJegyzetV214d2025.mvvm.model;
using PropertyChanged;

namespace MauiJegyzetV214d2025.mvvm.viewmodel
{
    [AddINotifyPropertyChangedInterface]
    public class JegyzetViewModel
    {
        public List<Jegyzet> Jegyzetek { get; set; }=new List<Jegyzet>();
        public Jegyzet AktualisJegyzet { get; set; }
        public ICommand DeleteCommand { get; set; }

        public JegyzetViewModel()
        {
            GetJegyzetek();
        }

        public void GetJegyzetek()
        {
            Jegyzetek = App.JegyzetRepo.GetItems();
            DeleteCommand = new Command(async() =>
            {
                var result = await Application.Current.MainPage.DisplayAlert("Törlés","Biztosan törli?","Igen","Nem");
                if (result)
                {
                    App.JegyzetRepo.DeleteItem(AktualisJegyzet);
                    await Application.Current.MainPage.DisplayAlert("Törlés", App.JegyzetRepo.StatusMsg, "Ok");
                    GetJegyzetek();
                }
            });
        }
    }
}
