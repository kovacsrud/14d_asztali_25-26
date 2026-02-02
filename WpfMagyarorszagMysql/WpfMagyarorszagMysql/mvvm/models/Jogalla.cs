using System;
using System.Collections.Generic;

namespace WpfMagyarorszagMysql.mvvm.models;

public partial class Jogalla
{
    public int Suly { get; set; }

    public string Jogallas { get; set; } = null!;

    public virtual ICollection<Telepulesek> Telepuleseks { get; set; } = new List<Telepulesek>();
}
