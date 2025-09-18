using MvvmDronokMobilok.mvvm.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MvvmDronokMobilok.mvvm.viewmodel
{
    public class MDViewModel
    {
        public List<Dron> Dronok { get; set; }=new List<Dron>();
        public List<Mobil> Mobilok { get; set; } = new List<Mobil>();

        public Dron SelectedDron { get; set; } = new Dron();
        public Mobil SelectedMobil { get; set; } = new Mobil();

        public MDViewModel()
        {
            try
            {
                var sorok = File.ReadAllLines(VMConfig.DronFajl, Encoding.Default);

                for (int i = VMConfig.Start; i < sorok.Length; i++)
                {
                    Dronok.Add(new Dron(sorok[i], VMConfig.DronHatarolo));
                }

                var adatok = File.ReadAllLines(VMConfig.MobilFajl, Encoding.Default);

                for (int i = VMConfig.Start; i < adatok.Length; i++)
                {
                    Mobilok.Add(new Mobil(adatok[i], VMConfig.MobilHatarolo));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);                
            }
            
        }

    }
}
