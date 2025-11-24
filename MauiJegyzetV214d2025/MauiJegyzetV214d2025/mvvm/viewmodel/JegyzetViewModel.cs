using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiJegyzetV214d2025.mvvm.model;
using PropertyChanged;

namespace MauiJegyzetV214d2025.mvvm.viewmodel
{
    [AddINotifyPropertyChangedInterface]
    public class JegyzetViewModel
    {
        public List<Jegyzet> Jegyzetek { get; set; }=new List<Jegyzet>();
        public Jegyzet AktualisJegyzet { get; set; }

        public JegyzetViewModel()
        {
            GetJegyzetek();
        }

        public void GetJegyzetek()
        {
            Jegyzetek = App.JegyzetRepo.GetItems();
        }
    }
}
