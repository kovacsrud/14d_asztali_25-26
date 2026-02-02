using System;
using System.Collections.Generic;

namespace WpfMagyarorszagMysql.mvvm.models;

public partial class Megyek
{
    public string Kod { get; set; } = null!;

    public string Nev { get; set; } = null!;

    public virtual ICollection<Telepulesek> Telepuleseks { get; set; } = new List<Telepulesek>();
}
