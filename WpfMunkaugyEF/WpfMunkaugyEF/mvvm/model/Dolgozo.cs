using System;
using System.Collections.Generic;

namespace WpfMunkaugyEF.mvvm.model;

public partial class Dolgozo
{
    public int Id { get; set; }

    public string Nev { get; set; } = null!;

    public DateOnly SzuletesiDatum { get; set; }

    public string AnyjaNeve { get; set; } = null!;

    public byte[]? DolgozoFoto { get; set; }

    public virtual ICollection<Nyilvantarta> Nyilvantarta { get; set; } = new List<Nyilvantarta>();
}
