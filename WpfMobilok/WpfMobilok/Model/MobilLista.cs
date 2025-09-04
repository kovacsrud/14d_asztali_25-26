﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMobilok.Model
{
    public class MobilLista
    {
        public List<Mobil> Mobilok { get; set; } = new List<Mobil>();

        public MobilLista(string fajl,char hatarolo,int start=1)
        {
            var adatok = File.ReadAllLines(fajl, Encoding.Default);

            for (int i = start; i < adatok.Length; i++)
            {
                Mobilok.Add(new Mobil(adatok[i],';'));
            }
            
        }
    }
}
