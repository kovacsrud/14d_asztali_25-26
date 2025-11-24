using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiJegyzetV214d2025.interfaces;
using SQLite;

namespace MauiJegyzetV214d2025.mvvm.model
{
    [System.ComponentModel.DataAnnotations.Schema.Table("jegyzetek")]
    public class Jegyzet:TableData
    {
        [NotNull]
        public string Cim { get; set; }
        [NotNull]
        public string Szoveg { get; set; }
        [NotNull]
        public DateTime Datum { get; set; }
    }
}
