using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiMvvm14d2025.Mvvm.Model;
using PropertyChanged;

namespace MauiMvvm14d2025.Mvvm.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class NevViewModel
    {
        public Nev Nev { get; set; }= new Nev();
    }
}
